﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
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

#line 1 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class AlterTableTemplate : AlterTableTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n");

#line 8 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"

            if (!string.IsNullOrEmpty(PrimaryKeyDropScript))
            {

#line default
#line hidden

#line 9 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(PrimaryKeyDropScript));

#line default
#line hidden

#line 9 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
            }
            foreach (var item in ColumnList) // ColumnList is declared in AlterTableTemplateCode.cs
            {
                if (item.Command == SqlScriptTemplateItem.ScriptCommand.AddColumn)
                {


#line default
#line hidden
                    this.Write("IF NOT EXISTS (SELECT TOP 1 1 FROM ");

#line 15 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
                    this.Write(".sys.columns WHERE object_id = OBJECT_ID(N\'[");

#line 15 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
                    this.Write("].[");

#line 15 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(SchemaName));

#line default
#line hidden
                    this.Write("].[");

#line 15 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(TableName));

#line default
#line hidden
                    this.Write("]\') AND name = \'");

#line 15 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(item.ColumnName));

#line default
#line hidden
                    this.Write("\')\r\nBEGIN\r\n\tALTER TABLE [");

#line 17 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
                    this.Write("].[");

#line 17 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(SchemaName));

#line default
#line hidden
                    this.Write("].[");

#line 17 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(TableName));

#line default
#line hidden
                    this.Write("] ADD [");

#line 17 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(item.ColumnName));

#line default
#line hidden
                    this.Write("] ");

#line 17 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(item.FullDefinition));

#line default
#line hidden
                    this.Write(";\r\nEND\r\n");

#line 19 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"

                }
                else if (item.Command == SqlScriptTemplateItem.ScriptCommand.DropColumn)
                {


#line default
#line hidden
                    this.Write("IF EXISTS (SELECT TOP 1 1 FROM ");

#line 24 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
                    this.Write(".sys.columns WHERE object_id = OBJECT_ID(N\'[");

#line 24 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
                    this.Write("].[");

#line 24 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(SchemaName));

#line default
#line hidden
                    this.Write("].[");

#line 24 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(TableName));

#line default
#line hidden
                    this.Write("]\') AND name = \'");

#line 24 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(item.ColumnName));

#line default
#line hidden
                    this.Write("\')\r\nBEGIN\r\n\tALTER TABLE [");

#line 26 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
                    this.Write("].[");

#line 26 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(SchemaName));

#line default
#line hidden
                    this.Write("].[");

#line 26 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(TableName));

#line default
#line hidden
                    this.Write("] DROP COLUMN [");

#line 26 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(item.ColumnName));

#line default
#line hidden
                    this.Write("];\r\nEND\r\n");

#line 28 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"

                }
                else if (item.Command == SqlScriptTemplateItem.ScriptCommand.DropPrimaryColumn)
                {


#line default
#line hidden
                    this.Write("IF EXISTS (SELECT TOP 1 1 FROM ");

#line 33 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
                    this.Write(".sys.columns WHERE object_id = OBJECT_ID(N\'[");

#line 33 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
                    this.Write("].[");

#line 33 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(SchemaName));

#line default
#line hidden
                    this.Write("].[");

#line 33 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(TableName));

#line default
#line hidden
                    this.Write("]\') AND name = \'");

#line 33 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(item.ColumnName));

#line default
#line hidden
                    this.Write("\')\r\nBEGIN\r\n\tDECLARE @C VARCHAR(100)\r\n\tSELECT @C = CONSTRAINT_NAME FROM ");

#line 36 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
                    this.Write(".INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_TYPE = \'PRIMARY KEY\' AND T" +
                            "ABLE_SCHEMA = \'");

#line 36 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(SchemaName));

#line default
#line hidden
                    this.Write("\' AND TABLE_NAME = \'");

#line 36 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(TableName));

#line default
#line hidden
                    this.Write("\'\r\n\tIF @C IS NOT NULL\r\n\tBEGIN\r\n\t\tEXEC(\'ALTER TABLE [");

#line 39 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
                    this.Write("].[");

#line 39 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(SchemaName));

#line default
#line hidden
                    this.Write("].[");

#line 39 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(TableName));

#line default
#line hidden
                    this.Write("] DROP CONSTRAINT \' + @C)\r\n\tEND\r\n\r\n\tALTER TABLE [");

#line 42 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
                    this.Write("].[");

#line 42 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(SchemaName));

#line default
#line hidden
                    this.Write("].[");

#line 42 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(TableName));

#line default
#line hidden
                    this.Write("] DROP COLUMN [");

#line 42 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(item.ColumnName));

#line default
#line hidden
                    this.Write("];\r\nEND\r\n");

#line 44 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"

                }
                else if (item.Command == SqlScriptTemplateItem.ScriptCommand.AlterColumn)
                {


#line default
#line hidden
                    this.Write("ALTER TABLE [");

#line 49 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
                    this.Write("].[");

#line 49 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(SchemaName));

#line default
#line hidden
                    this.Write("].[");

#line 49 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(TableName));

#line default
#line hidden
                    this.Write("] ALTER COLUMN [");

#line 49 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(item.ColumnName));

#line default
#line hidden
                    this.Write("] ");

#line 49 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(item.FullDefinition));

#line default
#line hidden
                    this.Write(";\r\n");

#line 50 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"

                }
                else if (item.Command == SqlScriptTemplateItem.ScriptCommand.ReNameColumn)
                {


#line default
#line hidden
                    this.Write("EXEC sp_rename \'[");

#line 55 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(DBName));

#line default
#line hidden
                    this.Write("].[");

#line 55 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(SchemaName));

#line default
#line hidden
                    this.Write("].[");

#line 55 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(TableName));

#line default
#line hidden
                    this.Write("].");

#line 55 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(item.ColumnName));

#line default
#line hidden
                    this.Write("\', \'");

#line 55 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                    this.Write(this.ToStringHelper.ToStringWithCulture(item.NewColumnName));

#line default
#line hidden
                    this.Write("\', \'COLUMN\';\r\nGO\r\n");

#line 57 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"

                }


#line default
#line hidden
                this.Write("\r\n");

#line 61 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"

            } // end of foreach
            if (!string.IsNullOrEmpty(PrimaryKeyScript))
            {

#line default
#line hidden
                this.Write("GO\r\n");

#line 65 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(PrimaryKeyScript));

#line default
#line hidden

#line 65 "D:\DataGovernance\PowerDama\PowerDama.Business\SqlTemplates\AlterTableTemplate.tt"
            }


#line default
#line hidden
            this.Write("GO\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }

#line default
#line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class AlterTableTemplateBase
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