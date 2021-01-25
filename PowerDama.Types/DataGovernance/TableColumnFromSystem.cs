namespace PowerDama.Types.DataGovernance
{
    public class TableColumnFromSystem
    {
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public string IndexName { get; set; }
        public string IndexType { get; set; }
        public byte? IsPrimaryKey { get; set; }
        public byte? IsUnique { get; set; }
        public byte? IsIdentity { get; set; }
        public byte? Precision { get; set; }
        public byte? Scale { get; set; }
        public byte? IsNullable { get; set; }
        public short? MaxLenght { get; set; }
    }
}
