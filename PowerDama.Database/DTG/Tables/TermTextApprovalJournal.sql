CREATE TABLE [DTG].[TermTextApprovalJournal] (
    [TermTextApprovalJournalId] INT            IDENTITY (1, 1) NOT NULL,
    [TermId]                    INT            NOT NULL,
    [TextApprovalStatus]        TINYINT        NOT NULL,
    [Description]               VARCHAR (2000) NOT NULL,
    [Status]                    TINYINT        NOT NULL,
    [UserName]                  VARCHAR (10)   NULL,
    [HostName]                  VARCHAR (20)   NULL,
    [SystemDate]                DATETIME       NULL,
    [UpdateUserName]            VARCHAR (10)   NULL,
    [UpdateHostName]            VARCHAR (20)   NULL,
    [UpdateSystemDate]          DATETIME       NULL,
    [HostIP]                    VARCHAR (15)   NULL,
    [TermRecommendationId]      INT            NULL
);

