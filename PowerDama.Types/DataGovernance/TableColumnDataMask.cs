using System;
using System.Collections.Generic;

#nullable disable

namespace PowerDama.Types.DataGovernance
{
    public partial class TableColumnDataMask
    {
        public int TableColumnId { get; set; }
        public string Dbname { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public byte? DataMaskTypeId { get; set; }
        public string SubsetCriteria { get; set; }
        public string SubsetOperator { get; set; }
    }
}
