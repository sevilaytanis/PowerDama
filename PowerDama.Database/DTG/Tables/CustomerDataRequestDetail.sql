CREATE TABLE [DTG].[CustomerDataRequestDetail] (
    [CustomerDataRequestDetailId] INT           IDENTITY (1, 1) NOT NULL,
    [CustomerDataRequestId]       INT           NOT NULL,
    [TermId]                      INT           NOT NULL,
    [SearchValue]                 NVARCHAR (50) NOT NULL,
    [UserName]                    VARCHAR (10)  NULL,
    [HostName]                    VARCHAR (20)  NULL,
    [SystemDate]                  DATETIME      NULL,
    [UpdateUserName]              VARCHAR (10)  NULL,
    [UpdateHostName]              VARCHAR (20)  NULL,
    [UpdateSystemDate]            DATETIME      NULL,
    [HostIP]                      VARCHAR (15)  NULL,
    CONSTRAINT [pkCustomerDataRequestDetail] PRIMARY KEY CLUSTERED ([CustomerDataRequestDetailId] ASC) WITH (FILLFACTOR = 95)
);

