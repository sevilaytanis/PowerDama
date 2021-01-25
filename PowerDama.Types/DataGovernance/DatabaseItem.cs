using System;

namespace PowerDama.Types.DataGovernance
{
    public class DatabaseItem
    {
        public int ObjectId { get; set; }
        public string Name { get; set; }
        public int SchemaId { get; set; }
        public string SchemaName { get; set; }
        public string ItemName { get; set; }
        public DateTime modify_date { get; set; }
    }
}
