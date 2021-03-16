using PowerDama.Business.DataGovernance;
using PowerDama.Core.Base;
using PowerDama.Repository.DataGovernance;
using PowerDama.Types.DataGovernance;
using PowerDama.Types.Constants;
using System;
using System.Collections.Generic;
using System.Text;
using Status = PowerDama.Types.Constants.Status;

namespace PowerDama.Management.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public class TableDesignPackageManager
    {
        private readonly ITableDesignPackageRepository _tableDesignPackageRepository;
        private readonly ITableRepository _tableRepository;
        private readonly ITableColumnRepository _tableColumnRepository;
        private readonly ITableDraftRepository _tableDraftRepository;
        private readonly ITableColumnDraftRepository _tableColumnDraftRepository;
        private readonly ISQLScriptGenerationRepository _sqlScriptGenerationRepository;

        /// <summary>
        /// 
        /// </summary>
        public TableDesignPackageManager()
        {
            _tableDesignPackageRepository = new TableDesignPackageRepository();
            _tableRepository = new TableRepository();
            _tableColumnRepository = new TableColumnRepository();
            _tableDraftRepository = new TableDraftRepository();
            _tableColumnDraftRepository = new TableColumnDraftRepository();
            _sqlScriptGenerationRepository = new SQLScriptGenerationRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<TableDesignPackage> AddTableDesignPackag(TableDesignPackage request)
        {
            return _tableDesignPackageRepository.Add(request);
        }

        public BaseResponse<Int32> Update(TableDesignPackage request)
        {
            var response = new BaseResponse<Int32>();
            var responseTableDesignPackage = _tableDesignPackageRepository.Update(request);
            if (!responseTableDesignPackage.Success)
            {
                response.ErrorMessage += responseTableDesignPackage.ErrorMessage;
                return response;
            }
            if (request.Status == (byte) Status.Approved)
            {
                var table = new Table()
                {
                    Dbname = request.Dbname,
                    SchemaName = request.SchemaName,
                    TableName = request.TableName
                };
                var responseTableSelect = _tableRepository.GetByColumns(table);
                if (!responseTableSelect.Success)
                {
                    response.ErrorMessage += responseTableSelect.ErrorMessage;
                    return response;
                }

                var versions = new TableVersion();
                if (responseTableSelect.Value != null && responseTableSelect.Value.Count != 0)
                {

                }
            }
            return response;
        }
    }
}
