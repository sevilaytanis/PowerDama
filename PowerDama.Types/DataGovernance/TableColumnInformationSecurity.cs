namespace PowerDama.Types.DataGovernance
{
    public class TableColumnInformationSecurity
    {
        public int TableColumnId { get; set; }
        public int TableId { get; set; }
        public string DBName { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public byte? SensitivityId { get; set; }
        public byte? DataMaskTypeId { get; set; }
        public string Sensitivity { get; set; }
        public string DataMaskType { get; set; }
        public string SubsetCriteria { get; set; }
        public string SubsetOperator { get; set; }
    }
}
