using PowerDama.Core.Base;
using PowerDama.Types.DataGovernance;
using System;
using System.Collections.ObjectModel;
using System.Text;

namespace PowerDama.Repository.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISQLScriptGenerationRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlScript"></param>
        /// <param name="serverName"></param>
        /// <param name="databaseName"></param>
        /// <param name="isTransactional"></param>
        /// <returns></returns>
        BaseResponseType ProcessTableDesignApprovalScript(string sqlScript, string serverName, string databaseName, bool isTransactional);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valueType"></param>
        /// <param name="lenght"></param>
        /// <param name="precision"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        String SetSqlType(string valueType, string lenght, string precision, string scale);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="command"></param>
        /// <param name="isLogTable"></param>
        /// <returns></returns>
        String SetFullDefinition(ColumnList columns, SqlScriptTemplateItem.ScriptCommand command, bool isLogTable = false);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="columns"></param>
        /// <param name="isLogTable"></param>
        /// <returns></returns>
        String CreateTableScript(Table request, ObservableCollection<ColumnList> columns, bool isLogTable = false);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        String AlterTableScript(TableWithColumns request, ObservableCollection<ColumnList> columns);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringBuilder"></param>
        /// <param name="databaseName"></param>
        void SetDatabaseContext(StringBuilder stringBuilder, string databaseName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="logTable"></param>
        /// <param name="primaryColumnName"></param>
        /// <returns></returns>
        String CreateTriggerScriptsForLog(Table table, Table logTable, string primaryColumnName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="columns"></param>
        /// <param name="isPrimaryKeyChanged"></param>
        /// <param name="isPrimaryKeyNullable"></param>
        /// <param name="isIdentityColumnChanged"></param>
        /// <returns></returns>
        Boolean CheckIfTableStructureChanged(TableWithColumns request, ObservableCollection<ColumnList> columns, out bool isPrimaryKeyChanged, out bool isPrimaryKeyNullable, out bool isIdentityColumnChanged);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTypeString"></param>
        /// <returns></returns>
        Boolean CheckDataType(string dataTypeString);

    }
}
