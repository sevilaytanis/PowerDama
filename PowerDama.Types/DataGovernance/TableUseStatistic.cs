using System;
using System.Collections.Generic;

#nullable disable

namespace PowerDama.Types.DataGovernance
{
    public partial class TableUseStatistic
    {
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public long RowCount { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? LastUserUpdateDate { get; set; }
        public int? ElapsedDayForLastUpdate { get; set; }
        public int? ElapsedDayForLastSqlrestart { get; set; }
        public DateTime SystemDate { get; set; }
    }
}
