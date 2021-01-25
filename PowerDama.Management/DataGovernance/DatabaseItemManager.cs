using PowerDama.Business.DataGovernance;
using PowerDama.Repository.DataGovernance;

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

        //public BaseResponse<List<TableColumnFromSystem>> GetTableFromSystem(Table table)
        //{
        //    var tableFromSystem = new SelectTableColumnMetaDataTemplate(table.Dbname, table.SchemaName, table.TableName);
        //    string sqlScript = tableFromSystem.T
        //}
    }
}
