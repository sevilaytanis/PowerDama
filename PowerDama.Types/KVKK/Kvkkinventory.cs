using System;

namespace PowerDama.Types.KVKK
{
    public partial class Kvkkinventory
    {
        public int KvkkinventoryId { get; set; }
        public int? DataOwner { get; set; }
        public int? BusinessProcessId { get; set; }
        public int? ActivityId { get; set; }
        public int? TransferredContactGroupId { get; set; }
        public int? DataCategoryId { get; set; }
        public int? ProcessingPurposeId { get; set; }
        public int? RelatedPersonId { get; set; }
        public int? RetentionTimeId { get; set; }
        public int? MeasuresTakenId { get; set; }
        public int? TransferAbroadId { get; set; }
        public byte? ClarificationId { get; set; }
        public byte? ExplicitConsentId { get; set; }
        public int? LegalBasisId { get; set; }
        public byte? SupplyContractId { get; set; }
        public byte? CustomerAgreementId { get; set; }
        public byte? DataProcessingDataResponsibleRelationshipId { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime? SystemDate { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string HostIp { get; set; }
    }
}
