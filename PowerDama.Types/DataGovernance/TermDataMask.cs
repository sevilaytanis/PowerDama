using System;
using System.Collections.Generic;

#nullable disable

namespace PowerDama.Types.DataGovernance
{
    public partial class TermDataMask
    {
        public int TermId { get; set; }
        public string DataType { get; set; }
        public byte DataMaskTypeId { get; set; }
        public byte? IsActive { get; set; }
    }
}
