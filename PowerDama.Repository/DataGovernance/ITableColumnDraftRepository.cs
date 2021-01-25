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
    public interface ITableColumnDraftRepository : IRepository<TableColumnDraft, TableColumnDraft>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BaseResponse<List<TableColumnDraft>> TableColumnDraftByTableId(int? id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="termId"></param>
        /// <returns></returns>
        BaseResponse<Int32> UpdateTableDraftByTermId(int tableId, int? termId);
    }
}
