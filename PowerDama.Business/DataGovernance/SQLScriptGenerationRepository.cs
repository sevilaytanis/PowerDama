using PowerDama.Core.Base;
using PowerDama.Core.Helpers;
using PowerDama.Repository.DataGovernance;
using PowerDama.Types.DataGovernance;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Transactions;
using static PowerDama.Types.DataGovernance.SqlScriptTemplateItem;

namespace PowerDama.Business.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public class SQLScriptGenerationRepository : ISQLScriptGenerationRepository
    {
        #region Sabitler

        public const string PRIMARY_KEY_CREATE_SCRIPT = ",{0} CONSTRAINT pk{1} PRIMARY KEY {3} ({2})";
        public const string PRIMARY_KEY_ADD_SCRIPT = "ALTER TABLE [{1}].[{2}].[{3}]{0} ADD CONSTRAINT pk{3} PRIMARY KEY ({4}){0}GO{0}";
        public const string PRIMARY_KEY_DROP_SCRIPT = @"DECLARE @C VARCHAR(100)
                                                        SELECT @C = CONSTRAINT_NAME FROM {1}.INFORMATION_SCHEMA.TABLE_CONSTRAINTS
                                                        WHERE CONSTRAINT_TYPE = 'PRIMARY_KEY' AND TABLE_SCHEMA = '{2}' AND TABLE_NAME = '{3}'
                                                        IF @C IS NOT NULL
                                                        BEGIN
                                                            EXEC('ALTER TABLE [{1}].[{2}].[{3}] DROP CONSTRAINT ' + @C)
                                                        END
                                                        GO";
        public const string NULL = "NULL";
        public const string NOT_NULL = "NOT NULL";
        public const string SPACE = " ";
        public const string IDENTITY_N_N = "IDENTITY({0}, {1})";

        public static class ConstValues
        {
            public const int TERMID_FOR_ID = 8;
            public const string DOR = ".";
            public const string TABLE_TYPE = "TABLETYPE";
            public const string DTG = "DTG";
            public const string DEFAULT_LOF_DB = "BOALog";
            public const string LOG_SUFFIX = "Log";
            public const string LOG_TABLE_REQUIRED_FIELD_1 = "BeginDate";
            public const string LOG_TABLE_REQUIRED_FIELD_2 = "EndDate";
            public const string DATA_TYPE_DATETIME = "DATETIME";

            //ParamTypes
            public const string LISTTYPE_PARAMTYPE = "ListType";
            public const string UNLIKEDTERMS_PARAMTYPE = "UnLinkedTerms";
            public const string SENSITIVITY_PARAMTYPE = "SENSITIVITY";
            public const string DATAMASK_PARAMTYPE = "DATAMASK";
            public const string SUBSETOPERATOR_PARAMTYPE = "SubsetOperator";
            public const string LOGDB_PARAMTYPE = "LOGDB";
            public const string KVKKSEARCHTERM_PARAMTYPE = "KVKKSearchTerm";
            public const string SCRIPTINVENTORYTYPE_PARAMTYPE = "ScriptInventoryType";
            public const string SCRIPTGROUP_PARAMTYPE = "ScriptGroup";
            public const string SENSITIVITYHINT_PARAMTYPE = "SensitivityHint";
            public const string SENSITIVITYHINT2_PARAMTYPE = "SensitivityHint2";
        }

        #endregion

        public String AlterTableScript(TableWithColumns request, ObservableCollection<ColumnList> columns)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTypeString"></param>
        /// <returns></returns>
        public Boolean CheckDataType(string dataTypeString)
        {
            var sqlBaseTypes = new List<string>() { "bit", "bigint", "binary", "date", "datetime", "datetime2", "datetimeoffset", "float", "int", "money", "real", "smalldatetime", "smallint", "smallmoney", "time", "tinyint", "uniqueidentifier", "varbinary" };
            var sqlBaseTypes2 = new List<string>() { "binary", "char", "decimal", "nchar", "numeric", "nvarchar", "varbinary", "varchar" };

            if (!String.IsNullOrEmpty(sqlBaseTypes.Find(x => x.ToUpperInvariant() == dataTypeString.ToUpperInvariant())))
            {
                return true;
            }
            else
            {
                foreach (var item in sqlBaseTypes2)
                {
                    if (dataTypeString.ToUpperInvariant().StartsWith(item.ToUpperInvariant()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="columns"></param>
        /// <param name="isPrimaryKeyChanged"></param>
        /// <param name="isPrimaryKeyNullable"></param>
        /// <param name="isIdentityColumnChanged"></param>
        /// <returns></returns>
        public Boolean CheckIfTableStructureChanged(TableWithColumns request, ObservableCollection<ColumnList> columns, out bool isPrimaryKeyChanged, out bool isPrimaryKeyNullable, out bool isIdentityColumnChanged)
        {
            bool CHANGED = true, NOT_CHANGED = false, status = NOT_CHANGED;
            isPrimaryKeyChanged = false;
            isIdentityColumnChanged = false;
            isPrimaryKeyNullable = false; //primary key alanı null olamaz
            var existingTableColumnList = request.TableColumnList;

            if (existingTableColumnList.Count != columns.Count)
            {
                status = CHANGED;
            }
            foreach (var draftColumn in columns.OrderBy(x => x.Order))
            {
                var existingColumn = (TableColumn)existingTableColumnList.ToList().Find(x => x.ColumnName == draftColumn.ColumnName);
                if (existingColumn == null)
                {
                    status = CHANGED;
                }
                else
                {
                    if (existingColumn.IsKey != draftColumn.IsKey)
                    {
                        isPrimaryKeyChanged = true;
                        status = CHANGED;
                    }

                    if (existingColumn.DataType != draftColumn.DataType)
                    {
                        status = CHANGED;
                    }

                    if ((draftColumn.IsKey == 0) && (existingColumn.Nullable != draftColumn.NullableProxy))
                    {
                        status = CHANGED;
                    }

                    if ((draftColumn.IsKey == 1) && (draftColumn.NullableProxy == 1))
                    {
                        isPrimaryKeyNullable = true;
                    }

                    if (existingColumn.IsIdentity == 1)
                        if (existingColumn.DataType != draftColumn.DataType || (existingColumn.Nullable != draftColumn.NullableProxy))
                            isIdentityColumnChanged = true;
                }
            }
            return status;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="columns"></param>
        /// <param name="isLogTable"></param>
        /// <returns></returns>
        public String CreateTableScript(Table request, ObservableCollection<ColumnList> columns, bool isLogTable = false)
        {
            var sqlScriptItemList = new List<SqlScriptTemplateItem>();
            List<string> primaryKeyColumns = null;
            string primaryKeyScript = null;

            foreach (var column in columns.OrderBy(x => x.Order))
            {
                var sqlScriptItem = new SqlScriptTemplateItem()
                {
                    Command = ScriptCommand.CreateTable,
                    ColumnName = column.ColumnName,
                    FullDefinition = SetFullDefinition(column, ScriptCommand.CreateTable, isLogTable)
                };

                if (column.IsKey == 1)
                {
                    if (primaryKeyColumns == null)
                        primaryKeyColumns = new List<string>();

                    primaryKeyColumns.Add(column.ColumnName);
                }
                sqlScriptItemList.Add(sqlScriptItem);
            }

            if (primaryKeyColumns != null)
            {
                string _primaryKeyColumn = string.Join(", ", primaryKeyColumns);

                if (isLogTable)
                {
                    _primaryKeyColumn = "";

                    if (primaryKeyColumns.Count > 2)
                    {
                        for (int i = 2; i <= primaryKeyColumns.Count - 1; i++)
                        {
                            _primaryKeyColumn += string.Concat(primaryKeyColumns[i], " ASC, ");
                        }
                    }

                    _primaryKeyColumn += string.Concat(primaryKeyColumns[0], " ASC, ");
                    _primaryKeyColumn += string.Concat(primaryKeyColumns[1], " ASC");
                }

                primaryKeyScript = string.Format(PRIMARY_KEY_CREATE_SCRIPT, Environment.NewLine, request.TableName, _primaryKeyColumn, (isLogTable) ? "CLUSTERED" : "");
            }

            var createTableTemplate = new SqlTemplates.CreateTableTemplate(request.Dbname, request.SchemaName, request.TableName, sqlScriptItemList, primaryKeyScript);

            return createTableTemplate.TransformText();
        }

        public String CreateTriggerScriptsForLog(Table table, Table logTable, string primaryColumnName)
        {
            var script = new StringBuilder();

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlScript"></param>
        /// <param name="serverName"></param>
        /// <param name="databaseName"></param>
        /// <param name="isTransactional"></param>
        /// <returns></returns>
        public BaseResponseType ProcessTableDesignApprovalScript(string sqlScript, string serverName, string databaseName, bool isTransactional)
        {
            string connectionString = String.Empty;
            SqlConnection connection = null;
            BaseResponseType response = new BaseResponseType();

            try
            {
                #region connect to DB
                connectionString = ConnectionHelper.GetConnectionString(Server.Mssql, serverName, databaseName);
                #endregion

                if (isTransactional)
                {
                    using (TransactionScope ts = new TransactionScope())
                    {
                        connection = new SqlConnection(connectionString);
                        BaseResponseType dbItems = ProcessTableDesignScript(sqlScript, connection);
                        if (!dbItems.Success)
                        {
                            response = dbItems;
                            ts.Dispose();
                            return response;
                        }
                        ts.Complete();
                    }
                }
                else
                {
                    connection = new SqlConnection(connectionString);
                    BaseResponseType dbItems = ProcessTableDesignScript(sqlScript, connection);
                    if (!dbItems.Success)
                    {
                        response = dbItems;
                        return response;
                    }
                    else
                        response.ErrorMessage = dbItems.ErrorMessage;
                }
            }
            catch (SqlException ex)
            {
                response.ErrorMessage = ex.Message;
                response.Success = false;
                LogHelper.FileLog(ex.Message);
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.Success = false;
                LogHelper.FileLog(ex.Message);
            }

            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringBuilder"></param>
        /// <param name="databaseName"></param>
        public void SetDatabaseContext(StringBuilder stringBuilder, string databaseName)
        {
            stringBuilder.AppendLine();
            stringBuilder.Append(String.Concat("USE", databaseName));
            stringBuilder.AppendLine();
            stringBuilder.Append("GO");
            stringBuilder.AppendLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="command"></param>
        /// <param name="isLogTable"></param>
        /// <returns></returns>
        public String SetFullDefinition(ColumnList columns, ScriptCommand command, bool isLogTable = false)
        {
            var definition = new StringBuilder();
            definition.Append(columns.DataType);
            definition.Append(SPACE);

            if (columns.IsIdentity == 1 && !isLogTable && command != ScriptCommand.AlterColumn)
            {
                string identity;
                if (columns.IdentitySpecifications != null)
                {
                    identity = String.Format(IDENTITY_N_N, columns.IdentitySpecifications.Increment, columns.IdentitySpecifications.Seed);
                }
                else
                {
                    identity = String.Format(IDENTITY_N_N);
                }

                definition.Append(identity);
                definition.Append(SPACE);
            }
            if (columns.IsKey != 1 && columns.IsIdentity != 1 && columns.Nullable.HasValue && columns.Nullable.Value == 1)
            {
                definition.Append(NULL);
            }
            else
            {
                definition.Append(NOT_NULL);
            }

            return definition.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valueType"></param>
        /// <param name="lenght"></param>
        /// <param name="precision"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        public String SetSqlType(string valueType, string lenght, string precision, string scale)
        {
            string type = valueType.ToUpperInvariant();
            string _type = valueType.ToUpperInvariant();

            if (valueType.ToUpperInvariant().StartsWith("NUMERIC") || valueType.ToUpperInvariant().StartsWith("DECIMAL"))
            {
                type = _type + "(" + precision + "," + scale + ")";
            }
            else if (valueType.ToUpperInvariant().StartsWith("CHAR") || valueType.ToUpperInvariant().StartsWith("VARCHAR") || valueType.ToUpperInvariant().StartsWith("NCAHR") || valueType.ToUpperInvariant().StartsWith("NVARCHAR"))
            {
                if (lenght.Equals("-1"))
                {
                    lenght = "MAX";
                }
                type = _type + "(" + lenght + ")";
            }

            return type;
        }

        /// <summary>
        /// Private Method
        /// </summary>
        /// <param name="sqlScript"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        private BaseResponseType ProcessTableDesignScript(string sqlScript, SqlConnection connection)
        {
            var response = new BaseResponseType();
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandTimeout = Convert.ToInt32(60000);
            
            try
            {
                command.CommandType = CommandType.Text;
                string sqlBatch = "";
                sqlScript = sqlScript + Environment.NewLine + "GO";

                foreach (var line in sqlScript.Split(new string[2] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (line.ToUpperInvariant().Trim() == "GO")
                    {
                        if (sqlBatch.Trim() == "")
                            continue;
                        command.CommandText = sqlBatch;
                        if (command.Connection.State != ConnectionState.Open)
                            command.Connection.Open();
                        command.ExecuteNonQuery();
                        sqlBatch = String.Empty;
                    }
                    else
                    {
                        sqlBatch += line + "\n";
                    }
                }
            }
            catch (SqlException ex)
            {
                response.ErrorMessage = ex.Message;
                response.Success = false;
                LogHelper.FileLog(ex.Message);
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.Success = false;
                if (ex.InnerException != null)
                {
                    response.ErrorMessage = ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        response.ErrorMessage = ex.InnerException.InnerException.Message;
                }
                LogHelper.FileLog(ex.Message);
            }

            return response;
        }
    }
}
