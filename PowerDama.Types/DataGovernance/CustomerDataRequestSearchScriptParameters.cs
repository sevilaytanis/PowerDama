namespace PowerDama.Types.DataGovernance
{
    public class CustomerDataRequestSearchScriptParameters
    {
        public string UniqueKeyForCustomer { get; set; }
        public string DBName { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
    }
}
