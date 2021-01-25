using PowerDama.Core.Base;
using PowerDama.Repository.Base;
using PowerDama.Types.DataGovernance;
using System.Collections.Generic;

namespace PowerDama.Repository.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITableDataMaskExceptionRepository : IRepository<TableDataMaskException, TableDataMaskException>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbNane"></param>
        /// <param name="schemaName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        BaseResponse<List<TableDataMaskException>> GetTableDataMaskExceptionByColumns(string dbNane, string schemaName, string tableName);
    }
}
