CREATE TABLE [DTG].[TableDesignPackage] (
    [TableDesignPackageId] INT           IDENTITY (1, 1) NOT NULL,
    [DBName]               VARCHAR (50)  NOT NULL,
    [SchemaName]           VARCHAR (20)  NULL,
    [TableName]            VARCHAR (100) NULL,
    [RejectReason]         VARCHAR (MAX) NULL,
    [Script]               VARCHAR (MAX) NULL,
    [Status]               TINYINT       NULL,
    [UserName]             VARCHAR (10)  NULL,
    [HostName]             VARCHAR (20)  NULL,
    [UpdateUserName]       VARCHAR (10)  NULL,
    [UpdateHostName]       VARCHAR (20)  NULL,
    [HostIP]               VARCHAR (15)  NULL,
    [SystemDate]           DATETIME      NULL,
    [UpdateSystemDate]     DATETIME      NULL,
    [Version]              TINYINT       CONSTRAINT [DF_TableDesignPackage_Version] DEFAULT ((1)) NOT NULL,
    [DevelopmentLocation]  VARCHAR (50)  NULL,
    CONSTRAINT [PK_TableDesignPackageId] PRIMARY KEY CLUSTERED ([TableDesignPackageId] ASC) WITH (FILLFACTOR = 95)
);

