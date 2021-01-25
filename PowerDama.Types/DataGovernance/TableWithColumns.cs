using System.Collections.Generic;

namespace PowerDama.Types.DataGovernance
{
    public class TableWithColumns
    {
        public Table Table { get; set; }
        public List<TableColumnExtra> TableColumnList { get; set; }
    }
}
