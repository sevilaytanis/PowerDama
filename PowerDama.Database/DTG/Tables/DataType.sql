CREATE TABLE [DTG].[DataType] (
    [DataTypeId] INT          IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [NameEN]     VARCHAR (50) NULL,
    CONSTRAINT [PK_DTG.DataTemplate] PRIMARY KEY CLUSTERED ([DataTypeId] ASC) WITH (FILLFACTOR = 95)
);

