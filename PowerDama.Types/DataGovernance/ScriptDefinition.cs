using System;
using System.Collections.Generic;

#nullable disable

namespace PowerDama.Types.DataGovernance
{
    public partial class ScriptDefinition
    {
        public int ScriptDefinitionId { get; set; }
        public string ScriptText { get; set; }
        public string ScriptTag { get; set; }
        public string ScriptGroup { get; set; }
        public byte? SortOrder { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime? SystemDate { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string HostIp { get; set; }
    }
}
