CREATE TABLE [DTG].[TableColumnDataMask] (
    [TableColumnId]  INT           NOT NULL,
    [DBName]         VARCHAR (50)  NULL,
    [SchemaName]     VARCHAR (20)  NOT NULL,
    [TableName]      VARCHAR (50)  NOT NULL,
    [ColumnName]     VARCHAR (100) NOT NULL,
    [DataMaskTypeId] TINYINT       NULL,
    [SubsetCriteria] VARCHAR (50)  NULL,
    [SubsetOperator] VARCHAR (20)  NULL
);

