namespace PowerDama.Types.DataGovernance
{
    public class TableColumnExtra : TableColumn
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        public TableColumnExtra(TableColumn request)
        {
            base.ColumnName = request.ColumnName;
            base.DataType = request.DataType;
            base.DataTypeChanged = request.DataTypeChanged;
            base.Description = request.Description;
            base.IsKey = request.IsKey;
            base.Nullable = request.Nullable;
            base.Sensitivity = request.Sensitivity;
            base.TableColumnId = request.TableColumnId;
            base.TableId = request.TableId;
            base.TermId = request.TermId;
            base.TermName = request.TermName;
            base.IsIdentity = request.IsIdentity;
            base.IsReference = request.IsReference;
            base.TableColumnCatalogId = request.TableColumnCatalogId;
        }
        public string Term { get; set; }
        public string TermDataType { get; set; }
    }
}
