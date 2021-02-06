CREATE TABLE [DTG].[TableColumnProperty] (
    [TableColumnPropertyId] INT           IDENTITY (1, 1) NOT NULL,
    [DatabaseName]          VARCHAR (100) NOT NULL,
    [SchemaName]            VARCHAR (100) NOT NULL,
    [TableName]             VARCHAR (100) NOT NULL,
    [ColumnName]            VARCHAR (50)  NOT NULL,
    [PropertyType]          TINYINT       NULL,
    [PropertyValue]         VARCHAR (50)  NULL,
    CONSTRAINT [pkTableColumnProperty] PRIMARY KEY CLUSTERED ([TableColumnPropertyId] ASC) WITH (FILLFACTOR = 95)
);

