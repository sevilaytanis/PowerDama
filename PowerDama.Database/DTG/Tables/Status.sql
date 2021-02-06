CREATE TABLE [DTG].[Status] (
    [StatusId] INT          NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [NameEN]   VARCHAR (50) NULL,
    CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED ([StatusId] ASC) WITH (FILLFACTOR = 95)
);

