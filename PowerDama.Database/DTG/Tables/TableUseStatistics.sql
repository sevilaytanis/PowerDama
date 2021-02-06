CREATE TABLE [DTG].[TableUseStatistics] (
    [DatabaseName]                NVARCHAR (128) NULL,
    [TableName]                   NVARCHAR (257) NULL,
    [RowCount]                    BIGINT         NOT NULL,
    [CreateDate]                  DATETIME       NOT NULL,
    [LastUserUpdateDate]          DATETIME       NULL,
    [ElapsedDayForLastUpdate]     INT            NULL,
    [ElapsedDayForLastSQLRestart] INT            NULL,
    [SystemDate]                  DATETIME       NOT NULL
);

