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
    public interface ITableColumnRepository : IRepository<TableColumn, TableColumn>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
        BaseResponse<List<TableColumn>> TableColumnByTableId(int? tableId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <returns></returns>
        BaseResponse<List<TableColumn>> GetKeyColumnsByTableTermId(int termId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <returns></returns>
        BaseResponse<List<TableColumn>> GetReferenceColumnsByTableTermId(int termId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableColumnId"></param>
        /// <param name="termId"></param>
        /// <returns></returns>
        BaseResponse<Int32> UpdateByTermId(int tableColumnId, int? termId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        BaseResponse<List<TableColumnInformationSecurity>> GetInformationSecurityByColumns(TableColumnInformationSecurity request, byte languageId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<Int32> UpdateInformationSecurity(TableColumnInformationSecurity request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<Int32> UpdateTableColumnSecurity(TableColumnInformationSecurity request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<Int32> UpdateTableColumnSubsetCriteria(TableColumnInformationSecurity request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="schemaName"></param>
        /// <param name="tableName"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        BaseResponse<Int32> RemoveTableColumnSubsetCriteria(string dbName, string schemaName, string tableName, string columnName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="schemaName"></param>
        /// <param name="tableName"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        BaseResponse<Int32> RemoveTableColumnDataMask(string dbName, string schemaName, string tableName, string columnName);
    }
}