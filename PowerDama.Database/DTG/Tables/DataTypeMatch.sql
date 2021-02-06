CREATE TABLE [DTG].[DataTypeMatch] (
    [DataTypeId]         INT          NOT NULL,
    [DataTypeLanguageId] TINYINT      NOT NULL,
    [Value]              VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_DataTypeMatching_1] PRIMARY KEY CLUSTERED ([DataTypeId] ASC, [DataTypeLanguageId] ASC) WITH (FILLFACTOR = 95)
);

