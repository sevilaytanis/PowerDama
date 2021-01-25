using PowerDama.Types.DataGovernance;
using System.Collections.Generic;

namespace PowerDama.Business.SqlTemplates
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AlterTableTemplate
    {
        private string DBName { get; set; }
        private string SchemaName { get; set; }
        private string TableName { get; set; }
        private string PrimaryKeyScript { get; set; }
        private string PrimaryKeyDropScript { get; set; }
        private List<SqlScriptTemplateItem> ColumnList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dBName"></param>
        /// <param name="schemaName"></param>
        /// <param name="tableName"></param>
        /// <param name="columnList"></param>
        /// <param name="primaryKeyScript"></param>
        /// <param name="primaryKeyDropScript"></param>
        public AlterTableTemplate(string dBName, string schemaName, string tableName, List<SqlScriptTemplateItem> columnList, string primaryKeyScript, string primaryKeyDropScript)
        {
            DBName = dBName;
            SchemaName = schemaName;
            TableName = tableName;
            ColumnList = columnList;
            PrimaryKeyScript = primaryKeyScript;
            PrimaryKeyDropScript = primaryKeyDropScript;
        }
    }
}
