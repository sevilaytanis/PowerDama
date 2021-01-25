namespace PowerDama.Types.DataGovernance
{
    public class PackageLocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ServerName { get; set; }
        public string DBName { get; set; }
        public string TFSName { get; set; }
        public byte? LocationType { get; set; }
        public byte? ApprovalRequired { get; set; }
        public byte? LocationState { get; set; }
    }
}
