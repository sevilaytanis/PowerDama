using System;

namespace PowerDama.Types.DataGovernance
{
    public partial class CustomerDataRequest
    {
        public int CustomerDataRequestId { get; set; }
        public string UniqueKeyForCustomer { get; set; }
        public byte? IsProcessed { get; set; }
        public DateTime? ProcessBeginDate { get; set; }
        public DateTime? ProcessEndDate { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime? SystemDate { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string HostIp { get; set; }
    }
}
