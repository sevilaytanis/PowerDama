CREATE TABLE [DTG].[TableColumnDraft] (
    [TableColumnDraftId]   INT           IDENTITY (1, 1) NOT NULL,
    [TableDraftId]         INT           NOT NULL,
    [TermId]               INT           NULL,
    [ColumnName]           VARCHAR (100) NOT NULL,
    [IsKey]                TINYINT       CONSTRAINT [DF_TableColumnDraft_IsKey] DEFAULT ((0)) NOT NULL,
    [DataTypeChanged]      TINYINT       NULL,
    [DataType]             VARCHAR (50)  NOT NULL,
    [Nullable]             TINYINT       CONSTRAINT [DF_TableColumnDraft_Nullable] DEFAULT ((1)) NULL,
    [Sensitivity]          TINYINT       NULL,
    [Description]          VARCHAR (500) NULL,
    [IsReference]          TINYINT       CONSTRAINT [DF_TableColumnDraft_IsReference] DEFAULT ((0)) NOT NULL,
    [IsIdentity]           TINYINT       CONSTRAINT [DF_TableColumnDraft_IsIdentity] DEFAULT ((0)) NOT NULL,
    [TableColumnCatalogId] INT           NULL,
    CONSTRAINT [PK_TableColumnDraft] PRIMARY KEY CLUSTERED ([TableColumnDraftId] ASC) WITH (FILLFACTOR = 95)
);

