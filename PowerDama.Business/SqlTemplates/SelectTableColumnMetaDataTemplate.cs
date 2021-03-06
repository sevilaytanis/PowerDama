// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
using System.Linq;
using System.Text;
using System.Collections.Generic;
using PowerDama.Types.DataGovernance;
using System;

namespace PowerDama.Business.SqlTemplates
{
    /// <summary>
    /// Class to produce the template output
    /// </summary>

#line 1 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\SelectTableColumnMetaDataTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class SelectTableColumnMetaDataTemplate : SelectTableColumnMetaDataTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"
DECLARE
 @ExecuteString NVARCHAR(1000)

 CREATE TABLE #TableColumns
 (
	ColumnId INT,
	ColumnName VARCHAR(100),
	DataType VARCHAR(50),
	IsPrimaryKey TINYINT,
	IsUnique TINYINT,
	IsIdentity TINYINT,
	[MaxLength] SMALLINT,
	[Precision] TINYINT,
	Scale TINYINT,
	IsNullable TINYINT,
	IndexName VARCHAR(500),
	IndexType VARCHAR(50)
 )

SET @ExecuteString = N'INSERT INTO #TableColumns (ColumnId, ColumnName, DataType, IsIdentity, [MaxLength], [Precision], Scale, IsNullable)
SELECT
	CLM.column_id AS ColumnId,
	CLM.name AS ColumnName, 
	TYP.name AS DataType, 
	CLM.is_identity AS IsIdentity, 
	CLM.max_length AS [MaxLength], 
	CLM.precision AS [Precision], 
	CLM.scale AS Scale, 
	CLM.is_nullable AS IsNullable
  FROM [");

#line 37 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\SelectTableColumnMetaDataTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
            this.Write("].sys.columns CLM \r\n INNER JOIN [");

#line 38 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\SelectTableColumnMetaDataTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
            this.Write("].sys.tables TBL WITH (NOLOCK) ON TBL.object_id = CLM.object_id\r\n INNER JOIN [");

#line 39 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\SelectTableColumnMetaDataTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
            this.Write("].sys.schemas SCH WITH (NOLOCK) ON SCH.schema_id = TBL.schema_id\r\n INNER JOIN [");

#line 40 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\SelectTableColumnMetaDataTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
            this.Write("].sys.types AS TYP WITH (NOLOCK) ON TYP.user_type_id = CLM.user_type_id AND TYP.s" +
                    "chema_id = 4\r\n WHERE\r\n\tSCH.name = \'\'");

#line 42 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\SelectTableColumnMetaDataTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SchemaName));

#line default
#line hidden
            this.Write("\'\'\r\n\tAND TBL.name = \'\'");

#line 43 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\SelectTableColumnMetaDataTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableName));

#line default
#line hidden
            this.Write(@"''
 ORDER BY CLM.column_id'

EXECUTE sp_executesql @ExecuteString

 CREATE TABLE #TableIndexes
 (
	ColumnName VARCHAR(100),
	IsPrimaryKey TINYINT,
	IsUnique TINYINT,
	IndexName VARCHAR(500),
	IndexType VARCHAR(50)
 )

SET @ExecuteString = N'INSERT INTO #TableIndexes
SELECT 
	c.[name],
	i.[is_primary_key],
	i.[is_unique],
	i.[name],
	i.[type_desc]
FROM  [");

#line 64 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\SelectTableColumnMetaDataTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
            this.Write("].[sys].[indexes] i \r\nINNER JOIN [");

#line 65 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\SelectTableColumnMetaDataTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
            this.Write("].[sys].[index_columns] ic \r\n\t\tON  i.[index_id]    =   ic.[index_id] \r\n\t\tAND i.[o" +
                    "bject_id]   =   ic.[object_id] \r\nINNER JOIN [");

#line 68 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\SelectTableColumnMetaDataTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
            this.Write("].[sys].[columns] c \r\n\t\tON  ic.[column_id]  =   c.[column_id] \r\n\t\tAND i.[object_i" +
                    "d]   =   c.[object_id] \r\nINNER JOIN [");

#line 71 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\SelectTableColumnMetaDataTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
            this.Write("].[sys].[tables] t \r\n\t\tON  i.[object_id] = t.[object_id] \r\nINNER JOIN [");

#line 73 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\SelectTableColumnMetaDataTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
            this.Write("].[sys].[schemas] s \r\n\t\tON  s.[schema_id] = t.[schema_id] \r\nWHERE s.name = \'\'");

#line 75 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\SelectTableColumnMetaDataTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SchemaName));

#line default
#line hidden
            this.Write("\'\' AND t.name = \'\'");

#line 75 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\SelectTableColumnMetaDataTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TableName));

#line default
#line hidden
            this.Write(@"'''

EXECUTE sp_executesql @ExecuteString

UPDATE #TableColumns
	SET IsPrimaryKey = TI.IsPrimaryKey,
		IsUnique = TI.IsUnique,
		IndexName = TI.IndexName,
		IndexType = TI.IndexType
FROM #TableColumns AS TC
INNER JOIN #TableIndexes AS TI
		ON TI.ColumnName = TC.ColumnName

SELECT 
	ColumnId,
	ColumnName,
	DataType,
	IsPrimaryKey,
	IsUnique,
	IsIdentity,
	[MaxLength],
	[Precision],
	Scale,
	IsNullable,
	IndexName,
	IndexType
 FROM #TableColumns
ORDER BY ColumnId

DROP TABLE #TableColumns
");
            return this.GenerationEnvironment.ToString();
        }
    }

#line default
#line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class SelectTableColumnMetaDataTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0)
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
