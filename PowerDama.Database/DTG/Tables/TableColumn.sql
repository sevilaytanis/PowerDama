CREATE TABLE [DTG].[TableColumn] (
    [TableColumnId]   INT           IDENTITY (1, 1) NOT NULL,
    [TableId]         INT           NOT NULL,
    [TermId]          INT           NULL,
    [ColumnName]      VARCHAR (100) NOT NULL,
    [IsKey]           TINYINT       CONSTRAINT [DF_TableColumn_IsKey] DEFAULT ((0)) NOT NULL,
    [DataTypeChanged] TINYINT       NULL,
    [DataType]        VARCHAR (50)  NOT NULL,
    [Nullable]        TINYINT       CONSTRAINT [DF_TableColumn_Nullable] DEFAULT ((1)) NULL,
    [Sensitivity]     TINYINT       NULL,
    [Description]     VARCHAR (500) NULL,
    [IsReference]     TINYINT       CONSTRAINT [DF_TableColumn_IsReference] DEFAULT ((0)) NOT NULL,
    [IsIdentity]      TINYINT       CONSTRAINT [DF_TableColumn_IsIdentity] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_TableColumn] PRIMARY KEY CLUSTERED ([TableColumnId] ASC) WITH (FILLFACTOR = 95)
);

