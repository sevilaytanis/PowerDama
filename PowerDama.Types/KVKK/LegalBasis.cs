using System;

namespace PowerDama.Types.KVKK
{
    public partial class LegalBasis
    {
        public int LegalBasisId { get; set; }
        public string LegalBasisName { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime? SystemDate { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string HostIp { get; set; }
    }
}
