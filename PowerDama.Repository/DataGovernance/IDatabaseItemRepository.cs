using PowerDama.Core.Base;
using PowerDama.Repository.Base;
using PowerDama.Types.DataGovernance;
using System.Collections.Generic;

namespace PowerDama.Repository.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDatabaseItemRepository : IRepository<DatabaseItem, DatabaseItem>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="databaseName"></param>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        BaseResponse<List<TableColumnFromSystem>> GetTableColumnMetaData(string serverName, string databaseName, string sqlString);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="databaseName"></param>
        /// <param name="schemaName"></param>
        /// <returns></returns>
        BaseResponse<List<DatabaseItem>> GetTableList(string serverName, string databaseName, string schemaName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<List<SchemaItem>> GetSchemaList(PackageLocation request);
    }
}
