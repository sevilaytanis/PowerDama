CREATE TABLE [DTG].[ScriptDefinition] (
    [ScriptDefinitionId] INT            IDENTITY (1, 1) NOT NULL,
    [ScriptText]         VARCHAR (5000) NOT NULL,
    [ScriptTag]          VARCHAR (100)  NULL,
    [ScriptGroup]        VARCHAR (50)   NULL,
    [SortOrder]          TINYINT        NULL,
    [UserName]           VARCHAR (10)   NULL,
    [HostName]           VARCHAR (20)   NULL,
    [SystemDate]         DATETIME       NULL,
    [UpdateUserName]     VARCHAR (10)   NULL,
    [UpdateHostName]     VARCHAR (20)   NULL,
    [UpdateSystemDate]   DATETIME       NULL,
    [HostIP]             VARCHAR (15)   NULL,
    CONSTRAINT [pkScriptDefinition] PRIMARY KEY CLUSTERED ([ScriptDefinitionId] ASC) WITH (FILLFACTOR = 95)
);

