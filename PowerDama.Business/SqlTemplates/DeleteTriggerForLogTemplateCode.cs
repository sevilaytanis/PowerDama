namespace PowerDama.Business.SqlTemplates
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DeleteTriggerForLogTemplate
    {
        private string DBName { get; set; }
        private string LogDBName { get; set; }
        private string SchemaName { get; set; }
        private string TableName { get; set; }
        private string LogTableName { get; set; }
        private string PrimaryColumnName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dBName"></param>
        /// <param name="logDBName"></param>
        /// <param name="schemaName"></param>
        /// <param name="tableName"></param>
        /// <param name="logTableName"></param>
        /// <param name="primaryColumnName"></param>
        public DeleteTriggerForLogTemplate(string dBName, string logDBName, string schemaName, string tableName, string logTableName, string primaryColumnName)
        {
            DBName = dBName;
            LogDBName = logDBName;
            SchemaName = schemaName;
            TableName = tableName;
            LogTableName = logTableName;
            PrimaryColumnName = primaryColumnName;
        }
    }
}
