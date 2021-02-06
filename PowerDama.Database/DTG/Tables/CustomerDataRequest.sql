CREATE TABLE [DTG].[CustomerDataRequest] (
    [CustomerDataRequestId] INT          IDENTITY (1, 1) NOT NULL,
    [UniqueKeyForCustomer]  VARCHAR (50) NOT NULL,
    [IsProcessed]           TINYINT      NULL,
    [ProcessBeginDate]      DATETIME     NULL,
    [ProcessEndDate]        DATETIME     NULL,
    [UserName]              VARCHAR (10) NULL,
    [HostName]              VARCHAR (20) NULL,
    [SystemDate]            DATETIME     NULL,
    [UpdateUserName]        VARCHAR (10) NULL,
    [UpdateHostName]        VARCHAR (20) NULL,
    [UpdateSystemDate]      DATETIME     NULL,
    [HostIP]                VARCHAR (15) NULL,
    CONSTRAINT [pkCustomerDataRequest] PRIMARY KEY CLUSTERED ([UniqueKeyForCustomer] ASC) WITH (FILLFACTOR = 95)
);

