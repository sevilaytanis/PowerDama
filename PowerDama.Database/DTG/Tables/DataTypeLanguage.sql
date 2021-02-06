CREATE TABLE [DTG].[DataTypeLanguage] (
    [DataTypeLanguageId] TINYINT      IDENTITY (1, 1) NOT NULL,
    [Name]               VARCHAR (50) NOT NULL,
    [NameEN]             VARCHAR (50) NULL,
    CONSTRAINT [PK_DataLanguageType] PRIMARY KEY CLUSTERED ([DataTypeLanguageId] ASC) WITH (FILLFACTOR = 95)
);

