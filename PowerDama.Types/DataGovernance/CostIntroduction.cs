using System;

namespace PowerDama.Types.DataGovernance
{
    public partial class CostIntroduction
    {
        public int CostIntroductionId { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public short? Costtype { get; set; }
        public string HostIp { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime? SystemDate { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
    }
}
