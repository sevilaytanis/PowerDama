namespace PowerDama.Types.DataGovernance
{
    public class BusinessDomain
    {
        public int DomainId { get; set; }
        public byte? DomainLevel { get; set; }
        public string DomainName { get; set; }
        public int? ParentDomainId { get; set; }
        public byte? ParentDomainLevel { get; set; }
        public string ParentDomainName { get; set; }
        public byte LanguageId { get; set; }
    }
}
