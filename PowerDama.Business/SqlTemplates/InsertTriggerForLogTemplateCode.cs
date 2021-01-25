namespace PowerDama.Business.SqlTemplates
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InsertTriggerForLogTemplate
    {
        private string DBName { get; set; }
        private string LogDBName { get; set; }
        private string SchemaName { get; set; }
        private string TableName { get; set; }
        private string LogTableName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dBName"></param>
        /// <param name="logDBName"></param>
        /// <param name="schemaName"></param>
        /// <param name="tableName"></param>
        /// <param name="logTableName"></param>
        public InsertTriggerForLogTemplate(string dBName, string logDBName, string schemaName, string tableName, string logTableName)
        {
            DBName = dBName;
            LogDBName = logDBName;
            SchemaName = schemaName;
            TableName = tableName;
            LogTableName = logTableName;
        }
    }
}
