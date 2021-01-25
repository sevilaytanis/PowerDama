namespace PowerDama.Business.SqlTemplates
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SelectTableColumnMetaDataTemplate
    {
        private string DBName { get; set; }
        private string SchemaName { get; set; }
        private string TableName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dBName"></param>
        /// <param name="schemaName"></param>
        /// <param name="tableName"></param>
        public SelectTableColumnMetaDataTemplate(string dBName, string schemaName, string tableName)
        {
            DBName = dBName;
            SchemaName = schemaName;
            TableName = tableName;
        }
    }
}
