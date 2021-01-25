using PowerDama.Core.Base;
using PowerDama.Repository.Base;
using PowerDama.Types.DataGovernance;
using System;
using System.Collections.Generic;

namespace PowerDama.Repository.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITableRepository : IRepository<Table, Table>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <returns></returns>
        BaseResponse<List<String>> GetDatabaseObjectByTermId(int termId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <returns></returns>
        BaseResponse<Table> GetByTermId(int termId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
        BaseResponse<Table> GetByKey(int tableId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<List<Table>> GetByColumns(Table request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<List<Table>> GetApprovedTables(Table request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<List<TableDesignPackage>> GetTableScript(Table request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="dbName"></param>
        /// <param name="schemaName"></param>
        /// <param name="existenceType"></param>
        /// <returns></returns>
        BaseResponse<List<DatabaseItem>> GetTableFromSystemByExistenceInCatalog(string serverName, string dbName, string schemaName, byte? existenceType);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        BaseResponse<List<String>> GetDbNameFromCatalog();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbName"></param>
        /// <returns></returns>
        BaseResponse<List<String>> GetSchemaNameFromCatalog(string dbName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="schemaName"></param>
        /// <returns></returns>
        BaseResponse<List<Table>> GetTableNameFromCatalog(string dbName, string schemaName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="schemaName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        BaseResponse<List<TableVersion>> GetTableVersion(string dbName, string schemaName, string tableName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<Int32> UpdateByTestVersion(Table request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<Int32> UpdateTableVersion(Table request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <returns></returns>
        BaseResponse<Boolean> GetTermHasLinkedTable(int? termId);
    }
}
