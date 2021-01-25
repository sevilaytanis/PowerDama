using System;
using System.Collections.Generic;

#nullable disable

namespace PowerDama.Types.DataGovernance
{
    public partial class TableColumnProperty
    {
        public int TableColumnPropertyId { get; set; }
        public string DatabaseName { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public byte? PropertyType { get; set; }
        public string PropertyValue { get; set; }
    }
}
