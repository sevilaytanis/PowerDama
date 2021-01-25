namespace PowerDama.Types.DataGovernance
{
    public class ColumnList : TableColumn
    {
        public short Order { get; set; }
        public string Module { get; set; }
        public string Term { get; set; }
        public bool IsReadOnly { get; set; }
        public DataType TermDataType { get; set; }
        public Sensitivity SensitivityProxy { get; set; }
        public Accessibility AccessibilityProxy { get; set; }
        public Integrity IntegrityProxy { get; set; }
        public byte NullableProxy { get; set; }
        public bool DataTypeChangedProxy { get; set; }
        public int TermModuleId { get; set; }
    }
}
