﻿namespace PowerDama.Types.DataGovernance
{
    public class DTGParameter
    {
        public string ParamType { get; set; }
        public string ParamCode { get; set; }
        public string ParamDescription { get; set; }
        public string ParamValue { get; set; }
        public int? ParamValue2 { get; set; }
        public string ParamValue3 { get; set; }
        public string ParamValue4 { get; set; }
        public string ParamValue5 { get; set; }
        public int LanguageId { get; set; }
        public byte? SortOrder { get; set; }
        public string OldParamType { get; set; }
        public string OldParamCode { get; set; }
        public byte OldLanguageId { get; set; }
    }
}
