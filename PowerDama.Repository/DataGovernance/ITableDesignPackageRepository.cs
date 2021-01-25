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
    public interface ITableDesignPackageRepository : IRepository<TableDesignPackage, TableDesignPackage>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        BaseResponse<List<TableDesignPackage>> GetColumns(TableDesignPackage item, DateTime? startDate, DateTime? endDate, byte languageId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="schemaName"></param>
        /// <param name="tableName"></param>
        /// <param name="isDraftControl"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        BaseResponse<List<CheckTableResult>> CheckTableDesign(string dbName, string schemaName, string tableName, byte isDraftControl, byte languageId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlScript"></param>
        /// <returns></returns>
        BaseResponse<Int32> ExecuteTableDesignScript(string sqlScript);
    }
}
