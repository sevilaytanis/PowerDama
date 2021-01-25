namespace PowerDama.Types.DataGovernance
{
    public partial class TableColumnDraft
    {
        public int TableColumnDraftId { get; set; }
        public int TableDraftId { get; set; }
        public int? TermId { get; set; }
        public string ColumnName { get; set; }
        public byte IsKey { get; set; }
        public byte? DataTypeChanged { get; set; }
        public string DataType { get; set; }
        public byte? Nullable { get; set; }
        public byte? Sensitivity { get; set; }
        public byte? SensitivityId { get; set; }
        public string Description { get; set; }
        public byte IsReference { get; set; }
        public byte IsIdentity { get; set; }
        public int? TableColumnCatalogId { get; set; }
    }
}
