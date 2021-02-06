CREATE TABLE [DTG].[TableColumnDataMaskDetail] (
    [TableColumnDataMaskDetailId] INT           IDENTITY (1, 1) NOT NULL,
    [TermName]                    VARCHAR (200) NULL,
    [DatabaseName]                VARCHAR (50)  NULL,
    [SchemaName]                  VARCHAR (20)  NULL,
    [TableName]                   VARCHAR (50)  NULL,
    [ColumnName]                  VARCHAR (100) NULL,
    [DataType]                    VARCHAR (50)  NULL,
    [DataMaskTypeId]              TINYINT       NULL,
    [DataMaskType]                VARCHAR (50)  NULL,
    [Production]                  VARCHAR (50)  NULL,
    [Development]                 VARCHAR (50)  NULL,
    [Test]                        VARCHAR (50)  NULL,
    [PreProduction]               VARCHAR (50)  NULL,
    [BugFix]                      VARCHAR (50)  NULL,
    [Replication]                 VARCHAR (50)  NULL,
    [Clone]                       VARCHAR (50)  NULL,
    [FullColumnName]              VARCHAR (200) NULL,
    [SubsetCriteria]              VARCHAR (50)  NULL,
    [SubsetOperator]              VARCHAR (20)  NULL,
    CONSTRAINT [pkTableColumnDataMaskDetail] PRIMARY KEY CLUSTERED ([TableColumnDataMaskDetailId] ASC) WITH (FILLFACTOR = 95)
);

