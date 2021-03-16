using PowerDama.Business.DataGovernance;
using PowerDama.Core.Base;
using PowerDama.Repository.DataGovernance;
using PowerDama.Types.DataGovernance;
using System;
using System.Collections.Generic;
using System.Text;

namespace PowerDama.Management.DataGovernance
{
    public class TableColumnDraftManager
    {
        private readonly ITableColumnDraftRepository _tableColumnDraftRepository;

        /// <summary>
        /// 
        /// </summary>
        public TableColumnDraftManager()
        {
            _tableColumnDraftRepository = new TableColumnDraftRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<TableColumnDraft>> GetTableColumnDrafts(TableColumnDraft request)
        {
            return _tableColumnDraftRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<TableColumnDraft> AddTableColumnDraft(TableColumnDraft request)
        {
            return _tableColumnDraftRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<TableColumnDraft> RemoveTableColumnDraft(TableColumnDraft request)
        {
            return _tableColumnDraftRepository.Remove(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableDraftId"></param>
        /// <returns></returns>
        public BaseResponse<List<TableColumnDraft>> GetTableColumnDraftByTableId(int? tableDraftId)
        {
            return _tableColumnDraftRepository.TableColumnDraftByTableId(tableDraftId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableColumnDraftId"></param>
        /// <param name="termId"></param>
        /// <returns></returns>
        public BaseResponse<Int32> UpdateDraftByTermId(int tableColumnDraftId, int? termId)
        {
            return _tableColumnDraftRepository.UpdateTableDraftByTermId(tableColumnDraftId, termId);
        }
    }
}
