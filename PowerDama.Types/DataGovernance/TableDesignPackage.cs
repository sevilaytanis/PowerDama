using System;

namespace PowerDama.Types.DataGovernance
{
    public partial class TableDesignPackage
    {
        public int TableDesignPackageId { get; set; }
        public string Dbname { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string RejectReason { get; set; }
        public string Script { get; set; }
        public byte? Status { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public string HostIp { get; set; }
        public DateTime? SystemDate { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public byte Version { get; set; }
        public string DevelopmentLocation { get; set; }
    }
}
