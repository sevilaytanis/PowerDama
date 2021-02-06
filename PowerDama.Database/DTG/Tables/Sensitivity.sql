CREATE TABLE [DTG].[Sensitivity] (
    [SensitivityId] TINYINT      NOT NULL,
    [Name]          VARCHAR (50) NOT NULL,
    [LanguageId]    TINYINT      CONSTRAINT [DF_DTG_Sensitivity_LanguageId] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_DTG_Sensitivity] PRIMARY KEY CLUSTERED ([SensitivityId] ASC, [LanguageId] ASC)
);

