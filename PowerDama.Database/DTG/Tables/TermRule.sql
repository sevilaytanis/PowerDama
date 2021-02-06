CREATE TABLE [DTG].[TermRule] (
    [TermRuleId]   INT           IDENTITY (1, 1) NOT NULL,
    [TermId]       INT           NULL,
    [TemplateType] TINYINT       NULL,
    [Value]        VARCHAR (200) NULL,
    [AlertStatus]  TINYINT       NULL,
    CONSTRAINT [PK_TermRule] PRIMARY KEY CLUSTERED ([TermRuleId] ASC) WITH (FILLFACTOR = 95)
);

