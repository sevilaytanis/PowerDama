namespace PowerDama.Types.DataGovernance
{
    public class SqlScriptTemplateItem
    {
        public ScriptCommand Command { get; set; }
        public string FullDefinition { get; set; }
        public string ColumnName { get; set; }
        public string NewColumnName { get; set; }
        public string ValueType { get; set; }
        public string IsKey { get; set; }
        public string Default { get; set; }
        public string Nullable { get; set; }

        public enum ScriptCommand
        {
            CreateTable,
            DropTable,
            AlterTable,
            AddColumn,
            DropColumn,
            AlterColumn,
            DropPrimaryColumn,
            ReNameColumn,
            AddPrimaryKey,
            DropPrimaryKey
        }
    }    
}
