using System;
using System.Collections.Generic;

#nullable disable

namespace PowerDama.Types.DataGovernance
{
    public partial class TermWork
    {
        public int TermId { get; set; }
        public string TermCode { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Description { get; set; }
        public string DescriptionEn { get; set; }
        public int? ModuleId { get; set; }
        public byte Type { get; set; }
        public int? DataOwner { get; set; }
        public int? DataManager { get; set; }
        public int? DataSteward { get; set; }
        public int? BaseTermId { get; set; }
        public byte? Sensitivity { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime? SystemDate { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string HostIp { get; set; }
        public byte? CopyWriterApproval { get; set; }
        public int? UseCount { get; set; }
        public byte? TermType { get; set; }
        public string HashTag { get; set; }
        public byte? IsPrivateData { get; set; }
        public byte? IsBusinessUnitTerm { get; set; }
        public byte? ValidatedByBusinessUnit { get; set; }
        public byte? ValidatedByCustomerRightsUnit { get; set; }
        public int? Level1Domain { get; set; }
        public int? Level2Domain { get; set; }
        public byte? Accessibility { get; set; }
        public byte? Integrity { get; set; }
        public byte? IsActive { get; set; }
    }
}
