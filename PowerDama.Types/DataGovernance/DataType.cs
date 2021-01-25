namespace PowerDama.Types.DataGovernance
{
    public partial class DataType
    {
        public int DataTypeId { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Value { get; set; }
        public byte DataTypeLanguageId { get; set; }
        public int LanguageId { get; set; }
    }
}
