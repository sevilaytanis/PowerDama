namespace PowerDama.Types.DataGovernance
{
    public partial class TermRule
    {
        public int TermRuleId { get; set; }
        public int? TermId { get; set; }
        public byte? TemplateType { get; set; }
        public string Value { get; set; }
        public byte? AlertStatus { get; set; }
    }
}
