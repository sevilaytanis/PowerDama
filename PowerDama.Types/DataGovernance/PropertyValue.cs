using System;
using System.Collections.Generic;

#nullable disable

namespace PowerDama.Types.DataGovernance
{
    public partial class PropertyValue
    {
        public int PropertyValueId { get; set; }
        public int EntityId { get; set; }
        public int PropertyId { get; set; }
        public byte? BoolValue { get; set; }
        public DateTime? DateValue { get; set; }
        public string TextValue { get; set; }
        public decimal? NumericValue { get; set; }
        public string RichTextValue { get; set; }
        public int? ParamCode { get; set; }
        public string UserName { get; set; }
        public DateTime SystemDate { get; set; }
        public string HostName { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string HostIp { get; set; }
    }
}
