using System;

namespace PowerDama.Types.KVKK
{
    public partial class ProcessingPurpose
    {
        public int ProcessingPurposeId { get; set; }
        public string ProcessingPurposeName { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime? SystemDate { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string HostIp { get; set; }
    }
}
