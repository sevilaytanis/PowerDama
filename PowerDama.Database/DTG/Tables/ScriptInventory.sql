CREATE TABLE [DTG].[ScriptInventory] (
    [ScriptInventoryId]   INT           IDENTITY (1, 1) NOT NULL,
    [ScriptInventoryType] TINYINT       NOT NULL,
    [ScriptDefinitionId]  INT           NOT NULL,
    [TermId]              INT           NULL,
    [DatabaseName]        VARCHAR (100) NULL,
    [SchemaName]          VARCHAR (100) NULL,
    [TableName]           VARCHAR (100) NULL,
    [ColumnName]          VARCHAR (50)  NULL,
    [UserName]            VARCHAR (10)  NULL,
    [HostName]            VARCHAR (20)  NULL,
    [SystemDate]          DATETIME      NULL,
    [UpdateUserName]      VARCHAR (10)  NULL,
    [UpdateHostName]      VARCHAR (20)  NULL,
    [UpdateSystemDate]    DATETIME      NULL,
    [HostIP]              VARCHAR (15)  NULL,
    CONSTRAINT [pkScriptInventory] PRIMARY KEY CLUSTERED ([ScriptInventoryId] ASC) WITH (FILLFACTOR = 95)
);

