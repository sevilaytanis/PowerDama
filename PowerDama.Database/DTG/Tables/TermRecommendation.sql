CREATE TABLE [DTG].[TermRecommendation] (
    [TermRecommendationId] INT            IDENTITY (1, 1) NOT NULL,
    [TermId]               INT            NOT NULL,
    [Name]                 VARCHAR (200)  NULL,
    [NameEN]               VARCHAR (200)  NULL,
    [Description]          VARCHAR (2000) NULL,
    [DescriptionEN]        VARCHAR (2000) NULL,
    [Status]               TINYINT        NULL,
    [UserName]             VARCHAR (10)   NULL,
    [HostName]             VARCHAR (20)   NULL,
    [SystemDate]           DATETIME       NULL,
    [UpdateUserName]       VARCHAR (10)   NULL,
    [UpdateHostName]       VARCHAR (20)   NULL,
    [UpdateSystemDate]     DATETIME       NULL,
    [HostIP]               VARCHAR (15)   NULL
);

