namespace PowerDama.Types.DataGovernance
{
    public class CustomerDataRequestResult
    {
        public string UniqueKeyForCustomer { get; set; }
        public string Location { get; set; }
        public string DBName { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string TermName { get; set; }
        public string TermDescription { get; set; }
        public string BusinessDomain { get; set; }
        public string Sensitivity { get; set; }
        public string DataOwner { get; set; }
        public string DataManager { get; set; }
        public byte? IsPrivateData { get; set; }
    }
}
