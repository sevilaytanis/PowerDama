namespace PowerDama.Types.DataGovernance
{
    public class TableVersion
    {
        public byte DevVersion { get; set; }

        public byte TestVersion { get; set; }

        public byte PrepVersion { get; set; }

        public byte ProdVersion { get; set; }
    }
}
