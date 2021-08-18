using System;

namespace PowerDama.MVC.Models.DataGovernance
{
    public class TermVM
    {
        public int TermId { get; set; }
        public string TermCode { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Description { get; set; }
        public string DescriptionEn { get; set; }
        public int? ModuleId { get; set; }
        public byte Type { get; set; }
        public string DataOwner { get; set; }
        public int? DataOwnerId { get; set; }
        public string DataManager { get; set; }
        public int? DataManagerId { get; set; }
        public string DataSteward { get; set; }
        public int? DataStewardId { get; set; }
        public int? BaseTermId { get; set; }
        public string Sensitivity { get; set; }
        public int? SensitivityId { get; set; }
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
        public string Accessibility { get; set; }
        public int? AccessibilityId { get; set; }
        public string Integrity { get; set; }
        public int? IntegrityId { get; set; }
        public byte? IsActive { get; set; }
        public byte LanguageId { get; set; }
        public byte InformationTypeId { get; set; }
    }
}
