using System;
using System.Collections.Generic;

#nullable disable

namespace PowerDama.Types.DataGovernance
{
    public partial class InformationType
    {
        public byte InformationTypeId { get; set; }
        public string Name { get; set; }
        public byte LanguageId { get; set; }
    }
}
