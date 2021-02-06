CREATE TABLE [DTG].[TemplateType] (
    [TemplateTypeId] TINYINT       IDENTITY (1, 1) NOT NULL,
    [Description]    VARCHAR (200) NOT NULL,
    [DescriptionEN]  VARCHAR (200) NULL,
    CONSTRAINT [PK_TemplateType] PRIMARY KEY CLUSTERED ([TemplateTypeId] ASC) WITH (FILLFACTOR = 95)
);

