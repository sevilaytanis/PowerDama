CREATE TABLE [DTG].[TermDataMaskWhiteList] (
    [TermId]     INT           NOT NULL,
    [ColumnName] VARCHAR (100) NOT NULL,
    CONSTRAINT [pkTermDataMaskWhiteList] PRIMARY KEY CLUSTERED ([TermId] ASC, [ColumnName] ASC) WITH (FILLFACTOR = 95)
);

