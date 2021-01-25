using System;
using System.Collections.Generic;

#nullable disable

namespace PowerDama.Types.DataGovernance
{
    public partial class TermTextApprovalJournal
    {
        public int TermTextApprovalJournalId { get; set; }
        public int TermId { get; set; }
        public byte TextApprovalStatus { get; set; }
        public string Description { get; set; }
        public byte Status { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime? SystemDate { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string HostIp { get; set; }
        public int? TermRecommendationId { get; set; }
    }
}
