CREATE TABLE [DTG].[PropertyValue] (
    [PropertyValueId]  INT             IDENTITY (1, 1) NOT NULL,
    [EntityId]         INT             NOT NULL,
    [PropertyId]       INT             NOT NULL,
    [BoolValue]        TINYINT         NULL,
    [DateValue]        DATETIME        NULL,
    [TextValue]        NVARCHAR (255)  NULL,
    [NumericValue]     DECIMAL (10, 4) NULL,
    [RichTextValue]    NVARCHAR (MAX)  NULL,
    [ParamCode]        INT             NULL,
    [UserName]         VARCHAR (10)    NOT NULL,
    [SystemDate]       DATETIME        NOT NULL,
    [HostName]         VARCHAR (20)    NOT NULL,
    [UpdateUserName]   VARCHAR (10)    NULL,
    [UpdateHostName]   VARCHAR (20)    NULL,
    [UpdateSystemDate] DATETIME        NULL,
    [HostIP]           VARCHAR (15)    NOT NULL,
    CONSTRAINT [PK_PropertyValue] PRIMARY KEY CLUSTERED ([PropertyValueId] ASC) WITH (FILLFACTOR = 95)
);

