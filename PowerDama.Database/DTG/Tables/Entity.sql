CREATE TABLE [DTG].[Entity] (
    [EntityId]         INT           IDENTITY (1, 1) NOT NULL,
    [TermId]           INT           NULL,
    [Type]             TINYINT       NOT NULL,
    [BaseEntityId]     INT           NULL,
    [Namespace]        VARCHAR (100) NULL,
    [WorkGroupId]      INT           NULL,
    [UserName]         VARCHAR (10)  NULL,
    [HostName]         VARCHAR (20)  NULL,
    [SystemDate]       DATETIME      NULL,
    [UpdateUserName]   VARCHAR (10)  NULL,
    [UpdateSystemDate] DATETIME      NULL,
    [UpdateHostName]   VARCHAR (20)  NULL,
    [HostIP]           VARCHAR (15)  NULL,
    CONSTRAINT [PK_Entity] PRIMARY KEY CLUSTERED ([EntityId] ASC) WITH (FILLFACTOR = 95)
);

