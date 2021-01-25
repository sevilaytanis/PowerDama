using System;

namespace PowerDama.Types.DataGovernance
{
    public partial class TableDraft
    {
        public int TableDraftId { get; set; }
        public string Dbname { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public int? TermId { get; set; }
        public byte? IsEntity { get; set; }
        public string Description { get; set; }
        public byte Status { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime? SystemDate { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string HostIp { get; set; }
        public byte DevVersion { get; set; }
        public byte TestVersion { get; set; }
        public byte PrepVersion { get; set; }
        public byte ProdVersion { get; set; }
        public string LogTableName { get; set; }
        public byte? TableType { get; set; }
        public string DevelopmentLocation { get; set; }
    }
}
