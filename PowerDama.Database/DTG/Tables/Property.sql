CREATE TABLE [DTG].[Property] (
    [PropertyId]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (255) NULL,
    [NameEN]           NVARCHAR (255) NULL,
    [Description]      NVARCHAR (500) NULL,
    [DescriptionEN]    NVARCHAR (500) NULL,
    [PropertyCode]     VARCHAR (50)   NULL,
    [DataType]         TINYINT        NOT NULL,
    [DataCount]        INT            NOT NULL,
    [IsRequired]       TINYINT        NULL,
    [ParameterType]    VARCHAR (20)   NULL,
    [UserName]         VARCHAR (10)   NOT NULL,
    [SystemDate]       DATETIME       NOT NULL,
    [HostName]         VARCHAR (20)   NOT NULL,
    [UpdateUserName]   VARCHAR (10)   NULL,
    [UpdateHostName]   VARCHAR (20)   NULL,
    [UpdateSystemDate] DATETIME       NULL,
    [HostIP]           VARCHAR (15)   NOT NULL,
    [TargetEntity]     TINYINT        NOT NULL,
    CONSTRAINT [PK_Property_1] PRIMARY KEY CLUSTERED ([PropertyId] ASC) WITH (FILLFACTOR = 95)
);

