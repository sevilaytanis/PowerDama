using PowerDama.Business.DataGovernance;
using PowerDama.Business.SqlTemplates;
using PowerDama.Core.Base;
using PowerDama.Repository.DataGovernance;
using PowerDama.Types.DataGovernance;
using System.Collections.Generic;

namespace PowerDama.Management.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public class DatabaseItemManager
    {
        private readonly IDatabaseItemRepository _databaseItemRepository;

        /// <summary>
        /// 
        /// </summary>
        public DatabaseItemManager()
        {
            _databaseItemRepository = new DatabaseItemRepository();
        }

        /// <summary>
        /// Get Table with it's columns from system objects
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public BaseResponse<List<TableColumnFromSystem>> GetTableFromSystem(Table table)
        {
            var tableFromSystem = new SelectTableColumnMetaDataTemplate(table.Dbname, table.SchemaName, table.TableName);
            string sqlScript = tableFromSystem.TransformText();
            return _databaseItemRepository.GetTableColumnMetaData(table.ServerName, table.Dbname, sqlScript);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="packageLocation"></param>
        /// <returns></returns>
        public BaseResponse<List<SchemaItem>> GetSchemaList(PackageLocation packageLocation)
        {
            return _databaseItemRepository.GetSchemaList(packageLocation);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="databaseName"></param>
        /// <param name="schemaName"></param>
        /// <returns></returns>
        public BaseResponse<List<DatabaseItem>> GetTableList(string serverName, string databaseName, string schemaName)
        {
            return _databaseItemRepository.GetTableList(serverName, databaseName, schemaName);
        }
    }
}
