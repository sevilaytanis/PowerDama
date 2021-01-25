using System;

namespace PowerDama.Types.KVKK
{
    public partial class DataCategory
    {
        public int DataCategoryId { get; set; }
        public string DataCategory1 { get; set; }
        public string DataCategoryName { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime? SystemDate { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string HostIp { get; set; }
        public int? TransferredContactGroup { get; set; }
    }
}
