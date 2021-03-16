using PowerDama.Business.DataGovernance;
using PowerDama.Core.Base;
using PowerDama.Repository.DataGovernance;
using PowerDama.Types.DataGovernance;
using System;
using System.Collections.Generic;

namespace PowerDama.Management.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public class TableColumnManager
    {
        private readonly ITableColumnRepository _tableColumnRepository;

        /// <summary>
        /// 
        /// </summary>
        public TableColumnManager()
        {
            _tableColumnRepository = new TableColumnRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<TableColumn> AddTableColumn(TableColumn request)
        {
            return _tableColumnRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<TableColumn>> GetTableColumns(TableColumn request)
        {
            return _tableColumnRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <returns></returns>
        public BaseResponse<List<TableColumn>> GetKeyColumnsByTableTermId(int termId)
        {
            return _tableColumnRepository.GetKeyColumnsByTableTermId(termId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <returns></returns>
        public BaseResponse<List<TableColumn>> GetReferenceColumnsByTableTermId(int termId)
        {
            return _tableColumnRepository.GetReferenceColumnsByTableTermId(termId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
        public BaseResponse<List<TableColumn>> GetTableColumnByTableId(int? tableId)
        {
            return _tableColumnRepository.TableColumnByTableId(tableId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        public BaseResponse<List<TableColumnInformationSecurity>> GetInformationSecurityColumns(TableColumnInformationSecurity request, byte languageId)
        {
            return _tableColumnRepository.GetInformationSecurityByColumns(request, languageId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<TableColumn> RemoveTableColumn(TableColumn request)
        {
            return _tableColumnRepository.Remove(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="schemaName"></param>
        /// <param name="tableName"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public BaseResponse<Int32> RemoveTableColumnDataMask(string dbName, string schemaName, string tableName, string columnName)
        {
            return _tableColumnRepository.RemoveTableColumnDataMask(dbName, schemaName, tableName, columnName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="schemaName"></param>
        /// <param name="tableName"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public BaseResponse<Int32> RemoveTableColumnSubsetCriteria(string dbName, string schemaName, string tableName, string columnName)
        {
            return _tableColumnRepository.RemoveTableColumnSubsetCriteria(dbName, schemaName, tableName, columnName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableColumnId"></param>
        /// <param name="termId"></param>
        /// <returns></returns>
        public BaseResponse<Int32> UpdateByTermId(int tableColumnId, int? termId)
        {
            return _tableColumnRepository.UpdateByTermId(tableColumnId, termId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Int32> UpdateInformationSecurity(TableColumnInformationSecurity request)
        {
            return _tableColumnRepository.UpdateInformationSecurity(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Int32> UpdateTableColumnSecurity(TableColumnInformationSecurity request)
        {
            return _tableColumnRepository.UpdateTableColumnSecurity(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Int32> UpdateTableColumnSubsetCriteria(TableColumnInformationSecurity request)
        {
            return _tableColumnRepository.UpdateTableColumnSubsetCriteria(request);
        }
    }
}
