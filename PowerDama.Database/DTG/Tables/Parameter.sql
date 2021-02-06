CREATE TABLE [DTG].[Parameter] (
    [ParamType]        VARCHAR (20)  NOT NULL,
    [ParamCode]        VARCHAR (20)  NOT NULL,
    [ParamValue]       VARCHAR (50)  NOT NULL,
    [ParamDescription] VARCHAR (200) NULL,
    [ParamValue2]      VARCHAR (50)  NULL,
    [ParamValue3]      VARCHAR (50)  NULL,
    [ParamValue4]      VARCHAR (50)  NULL,
    [ParamValue5]      VARCHAR (50)  NULL,
    [LanguageId]       INT           NOT NULL,
    [SortOrder]        TINYINT       NULL
);

