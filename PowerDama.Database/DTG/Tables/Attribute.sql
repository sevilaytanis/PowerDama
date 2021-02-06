CREATE TABLE [DTG].[Attribute] (
    [AttributeId]          INT          IDENTITY (1, 1) NOT NULL,
    [EntityId]             INT          NULL,
    [TermId]               INT          NULL,
    [AttributeType]        TINYINT      NOT NULL,
    [DataType]             VARCHAR (50) NOT NULL,
    [Length]               SMALLINT     NULL,
    [Precision]            TINYINT      NULL,
    [Scale]                TINYINT      NULL,
    [Nullable]             TINYINT      CONSTRAINT [DF_Attribute_Nullable] DEFAULT ((1)) NULL,
    [IsKey]                TINYINT      CONSTRAINT [DF_Property_IsKey] DEFAULT ((0)) NULL,
    [IsCollection]         TINYINT      CONSTRAINT [DF_Property_IsCollection] DEFAULT ((0)) NULL,
    [ReferenceAttributeId] INT          NULL,
    [Sensitivity]          TINYINT      NULL,
    [UserName]             VARCHAR (10) NULL,
    [HostName]             VARCHAR (20) NULL,
    [SystemDate]           DATETIME     NULL,
    [UpdateUserName]       VARCHAR (10) NULL,
    [UpdateHostName]       VARCHAR (20) NULL,
    [UpdateSystemDate]     DATETIME     NULL,
    [HostIP]               VARCHAR (15) NULL,
    CONSTRAINT [PK_Property] PRIMARY KEY CLUSTERED ([AttributeId] ASC) WITH (FILLFACTOR = 95)
);

