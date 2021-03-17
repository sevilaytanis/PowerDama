using System;

namespace PowerDama.Types.DataGovernance
{
    public partial class CustomerDataRequestDetail
    {
        public int CustomerDataRequestDetailId { get; set; }
        public int CustomerDataRequestId { get; set; }
        public int TermId { get; set; }
        public string SearchValue { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime? SystemDate { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string HostIp { get; set; }
    }
}
