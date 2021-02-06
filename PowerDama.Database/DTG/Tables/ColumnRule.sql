CREATE TABLE [DTG].[ColumnRule] (
    [ColumnRuleId] INT           IDENTITY (1, 1) NOT NULL,
    [TermId]       INT           NOT NULL,
    [DataType]     VARCHAR (50)  NOT NULL,
    [ColumnName]   VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_ColumnRule] PRIMARY KEY CLUSTERED ([ColumnRuleId] ASC) WITH (FILLFACTOR = 95)
);

