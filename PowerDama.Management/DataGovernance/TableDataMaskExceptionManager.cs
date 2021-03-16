using PowerDama.Business.DataGovernance;
using PowerDama.Repository.DataGovernance;
using System;
using System.Collections.Generic;
using System.Text;

namespace PowerDama.Management.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public class TableDataMaskExceptionManager
    {
        private readonly ITableDataMaskExceptionRepository _tableDataMaskExceptionRepository;

        /// <summary>
        /// 
        /// </summary>
        public TableDataMaskExceptionManager()
        {
            _tableDataMaskExceptionRepository = new TableDataMaskExceptionRepository();
        }
    }
}
