using System;

namespace PowerDama.Types.DataGovernance
{
    public partial class Attribute
    {
        public int AttributeId { get; set; }
        public int? EntityId { get; set; }
        public int? TermId { get; set; }
        public byte AttributeType { get; set; }
        public string DataType { get; set; }
        public short? Length { get; set; }
        public byte? Precision { get; set; }
        public byte? Scale { get; set; }
        public byte? Nullable { get; set; }
        public byte? IsKey { get; set; }
        public byte? IsCollection { get; set; }
        public int? ReferenceAttributeId { get; set; }
        public byte? Sensitivity { get; set; }
        public string UserName { get; set; }
        public DateTime? SystemDate { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string HostIp { get; set; }
    }
}
