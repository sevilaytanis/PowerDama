using System;

namespace PowerDama.Types.DataGovernance
{
    public class VParameter
    {
        public string ParamType { get; set; }
        public int ParamCode { get; set; }
        public string ParamDescription { get; set; }
        public string ParamValue { get; set; }
        public int? ParamValue2 { get; set; }
        public string ParamValue3 { get; set; }
        public string ParamValue4 { get; set; }
        public string ParamValue5 { get; set; }
        public string ParamValue6 { get; set; }
        public string ParamValue7 { get; set; }
        public string ParamValue8 { get; set; }
        public DateTime? ParamDate { get; set; }
        public int LanguageId { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime? SystemDate { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateHostName { get; set; }
        public DateTime? UpdateSystemDate { get; set; }
        public string ParamGroupCode { get; set; }
        public int? SortOrder { get; set; }
    }
}
