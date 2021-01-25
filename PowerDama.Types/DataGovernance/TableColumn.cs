namespace PowerDama.Types.DataGovernance
{
    public partial class TableColumn
    {
        public int TableColumnId { get; set; }
        public int TableId { get; set; }
        public int? TermId { get; set; }
        public int? TableColumnCatalogId { get; set; }
        public string ColumnName { get; set; }
        public string TermName { get; set; }
        public byte IsKey { get; set; }
        public byte? DataTypeChanged { get; set; }
        public string DataType { get; set; }
        public byte? Nullable { get; set; }
        public byte? Sensitivity { get; set; }
        public byte? SensitivityId { get; set; }
        public string Description { get; set; }
        public byte IsReference { get; set; }
        public byte IsIdentity { get; set; }
        public byte? IsActive { get; set; }
        public IdentitySpecifications IdentitySpecifications { get; set; }
    }

    public class IdentitySpecifications
    {
        public byte Increment;
        public long Seed;
        public IdentitySpecifications() { Increment = 1; Seed = 1; }
    }
}
