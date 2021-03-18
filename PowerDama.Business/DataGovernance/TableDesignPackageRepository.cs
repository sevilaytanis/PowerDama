using Dapper;
using PowerDama.Core.Base;
using PowerDama.Core.Helpers;
using PowerDama.Repository.DataGovernance;
using PowerDama.Types.DataGovernance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PowerDama.Business.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public class TableDesignPackageRepository : ITableDesignPackageRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<TableDesignPackage> Add(TableDesignPackage request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                DBName = request.Dbname,
                DevelopmentLocation = request.DevelopmentLocation,
                SchemaName = request.SchemaName,
                TableName = request.TableName,
                Status = request.Status,
                UserName = request.UserName,
                HostName = request.HostName,
                HostIP = request.HostIp,
                RejectReason = request.RejectReason,
                Script = request.Script
            });
            #endregion

            #region return object value
            var data = new BaseResponse<TableDesignPackage>();
            data.Value = new TableDesignPackage();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<TableDesignPackage>("DTG.ins_TableDesignPackage", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                data.Success = true;
                data.InfoMessage = Messages.Successfull;
                #endregion

                #region close to DB
                connection.db.Close();
                #endregion
            }
            catch (Exception ex)
            {
                #region close to DB
                connection.db.Close();
                #endregion

                #region Write Log to text file
                LogHelper.FileLog(ex.Message);
                #endregion

                #region return Exception
                data.Success = false;
                data.ErrorMessage = ex.Message;
                #endregion
            }
            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="schemaName"></param>
        /// <param name="tableName"></param>
        /// <param name="isDraftControl"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        public BaseResponse<List<CheckTableResult>> CheckTableDesign(string dbName, string schemaName, string tableName, byte isDraftControl, byte languageId)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                DBName = dbName,
                SchemaName = schemaName,
                TableName = tableName,
                IsDraftControl = isDraftControl,
                LanguageId = languageId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<List<CheckTableResult>>();
            data.Value = new List<CheckTableResult>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<CheckTableResult>("DTG.sel_CheckTableDesign", parameters, commandType: CommandType.StoredProcedure).ToList();
                data.Success = true;
                data.InfoMessage = Messages.Successfull;
                #endregion

                #region close to DB
                connection.db.Close();
                #endregion
            }
            catch (Exception ex)
            {
                #region close to DB
                connection.db.Close();
                #endregion

                #region Write Log to text file
                LogHelper.FileLog(ex.Message);
                #endregion

                #region return Exception
                data.Success = false;
                data.ErrorMessage = ex.Message;
                #endregion
            }
            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlScript"></param>
        /// <returns></returns>
        public BaseResponse<Int32> ExecuteTableDesignScript(string sqlScript)
        {
            #region return object value
            BaseResponse<Int32> sp = null;
            int affectedRowCount = 0;
            string sqlBatch = String.Empty;
            sqlScript = sqlScript + Environment.NewLine + "GO";
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                foreach (var line in sqlScript.Split(new string[2] { "\n" , "\r" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (line.ToUpperInvariant().Trim() == "GO")
                    {
                        if (sqlBatch.Trim() == String.Empty)
                            continue;

                        sp.Value = connection.db.Query<int>(sqlBatch, commandType: CommandType.Text).FirstOrDefault();
                        if (!sp.Success)
                        {
                            affectedRowCount += sp.Value;
                            return sp;
                        }
                        sqlBatch = String.Empty;
                    }
                    else
                    {
                        sqlBatch += line + "\n";
                    }
                }
                #endregion

                sp.Value = affectedRowCount;
                
                #region close to DB
                connection.db.Close();
                #endregion
            }
            catch (Exception ex)
            {
                #region close to DB
                connection.db.Close();
                #endregion

                #region Write Log to text file
                LogHelper.FileLog(ex.Message);
                #endregion

                #region return Exception
                sp.Success = false;
                sp.ErrorMessage = ex.Message;
                #endregion
            }
            return sp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<TableDesignPackage>> Get(TableDesignPackage request)
        {
            #region return object value
            var data = new BaseResponse<List<TableDesignPackage>>();
            data.Value = new List<TableDesignPackage>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<TableDesignPackage>("DTG.sel_TableDesignPackage", commandType: CommandType.StoredProcedure).ToList();
                data.Success = true;
                data.InfoMessage = Messages.Successfull;
                #endregion

                #region close to DB
                connection.db.Close();
                #endregion
            }
            catch (Exception ex)
            {
                #region close to DB
                connection.db.Close();
                #endregion

                #region Write Log to text file
                LogHelper.FileLog(ex.Message);
                #endregion

                #region return Exception
                data.Success = false;
                data.ErrorMessage = ex.Message;
                #endregion
            }
            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<TableDesignPackage> Remove(TableDesignPackage request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                TableDesignPackageId = request.TableDesignPackageId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<TableDesignPackage>();
            data.Value = new TableDesignPackage();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<TableDesignPackage>("DTG.del_TableDesignPackage", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                data.Success = true;
                data.InfoMessage = Messages.Successfull;
                #endregion

                #region close to DB
                connection.db.Close();
                #endregion
            }
            catch (Exception ex)
            {
                #region close to DB
                connection.db.Close();
                #endregion

                #region Write Log to text file
                LogHelper.FileLog(ex.Message);
                #endregion

                #region return Exception
                data.Success = false;
                data.ErrorMessage = ex.Message;
                #endregion
            }
            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        public BaseResponse<List<TableDesignPackage>> GetByColumns(TableDesignPackage item, DateTime? startDate, DateTime? endDate, byte languageId)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                DBName = item.Dbname,
                SchemaName = item.SchemaName,
                TableName = item.TableName,
                Status = item.Status,
                UserName = item.UserName,
                HostName = item.HostName,
                StartDate = startDate,
                EndDate = endDate,
                LanguageId = languageId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<List<TableDesignPackage>>();
            data.Value = new List<TableDesignPackage>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<TableDesignPackage>("DTG.sel_TableDesignPackageByColumns", parameters, commandType: CommandType.StoredProcedure).ToList();
                data.Success = true;
                data.InfoMessage = Messages.Successfull;
                #endregion

                #region close to DB
                connection.db.Close();
                #endregion
            }
            catch (Exception ex)
            {
                #region close to DB
                connection.db.Close();
                #endregion

                #region Write Log to text file
                LogHelper.FileLog(ex.Message);
                #endregion

                #region return Exception
                data.Success = false;
                data.ErrorMessage = ex.Message;
                #endregion
            }
            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<TableDesignPackage> Update(TableDesignPackage request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                DBName = request.Dbname,
                TableDesignPackageId = request.TableDesignPackageId,
                DevelopmentLocation = request.DevelopmentLocation,
                SchemaName = request.SchemaName,
                TableName = request.TableName,
                Status = request.Status,
                UpdateUserName = request.UpdateUserName,
                UpdateHostName = request.UpdateHostName,
                HostIP = request.HostIp,
                RejectReason = request.RejectReason,
                Script = request.Script
            });
            #endregion

            #region return object value
            var data = new BaseResponse<TableDesignPackage>();
            data.Value = new TableDesignPackage();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<TableDesignPackage>("DTG.upd_TableDesignPackage", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                data.Success = true;
                data.InfoMessage = Messages.Successfull;
                #endregion

                #region close to DB
                connection.db.Close();
                #endregion
            }
            catch (Exception ex)
            {
                #region close to DB
                connection.db.Close();
                #endregion

                #region Write Log to text file
                LogHelper.FileLog(ex.Message);
                #endregion

                #region return Exception
                data.Success = false;
                data.ErrorMessage = ex.Message;
                #endregion
            }
            return data;
        }

        public BaseResponse<TableDesignPackage> GetById(int tableDesignPackageId)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                TableDesignPackageId = tableDesignPackageId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<TableDesignPackage>();
            data.Value = new TableDesignPackage();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<TableDesignPackage>("DTG.upd_TableDesignPackageById", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                data.Success = true;
                data.InfoMessage = Messages.Successfull;
                #endregion

                #region close to DB
                connection.db.Close();
                #endregion
            }
            catch (Exception ex)
            {
                #region close to DB
                connection.db.Close();
                #endregion

                #region Write Log to text file
                LogHelper.FileLog(ex.Message);
                #endregion

                #region return Exception
                data.Success = false;
                data.ErrorMessage = ex.Message;
                #endregion
            }
            return data;
        }
    }
}
