using System;
using System.Collections.Generic;

#nullable disable

namespace PowerDama.Types.DataGovernance
{
    public partial class Property
    {
        public int PropertyId { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Description { get; set; }
        public string DescriptionEn { get; set; }
        public string PropertyCode { get; set; }
        public byte DataType { get; set; }
        public int DataCount { get; set; }
        public byte? IsRequired { get; set; }
        public string ParameterType { get; set; }
        public string UserName { get; set; }
        public DateTime SystemDate { get; set; }
        public string HostName { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string HostIp { get; set; }
        public byte TargetEntity { get; set; }
    }
}
