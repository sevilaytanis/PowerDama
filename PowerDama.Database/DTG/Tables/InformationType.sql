CREATE TABLE [DTG].[InformationType] (
    [InformationTypeId] TINYINT      NOT NULL,
    [Name]              VARCHAR (50) NOT NULL,
    [LanguageId]        TINYINT      CONSTRAINT [DF_DTG_InformationType_LanguageId] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_DTG_InformationType] PRIMARY KEY CLUSTERED ([InformationTypeId] ASC, [LanguageId] ASC)
);

