using System;
using System.Collections.Generic;

#nullable disable

namespace PowerDama.Types.DataGovernance
{
    public partial class TableColumnDataMaskDetail
    {
        public int TableColumnDataMaskDetailId { get; set; }
        public string TermName { get; set; }
        public string DatabaseName { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public byte? DataMaskTypeId { get; set; }
        public string DataMaskType { get; set; }
        public string Production { get; set; }
        public string Development { get; set; }
        public string Test { get; set; }
        public string PreProduction { get; set; }
        public string BugFix { get; set; }
        public string Replication { get; set; }
        public string Clone { get; set; }
        public string FullColumnName { get; set; }
        public string SubsetCriteria { get; set; }
        public string SubsetOperator { get; set; }
    }
}
