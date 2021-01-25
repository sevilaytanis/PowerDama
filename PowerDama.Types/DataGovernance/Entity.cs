using System;
using System.Collections.Generic;

#nullable disable

namespace PowerDama.Types.DataGovernance
{
    public partial class Entity
    {
        public int EntityId { get; set; }
        public int? TermId { get; set; }
        public byte Type { get; set; }
        public int? BaseEntityId { get; set; }
        public string Namespace { get; set; }
        public int? WorkGroupId { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime? SystemDate { get; set; }
        public string UpdateUserName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string UpdateHostName { get; set; }
        public string HostIp { get; set; }
    }
}
