using System;
using System.Collections.Generic;

#nullable disable

namespace PowerDama.Types.DataGovernance
{
    public partial class DataTypeMatch
    {
        public int DataTypeId { get; set; }
        public byte DataTypeLanguageId { get; set; }
        public string Value { get; set; }
    }
}
