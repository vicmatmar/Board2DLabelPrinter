CREATE TABLE [dbo].[BoardTracker] (
    [Id]             INT      IDENTITY (1, 1) NOT NULL,
    [BoardProcessId] INT      NOT NULL,
    [ProductId]      INT      NOT NULL,
    [Week]           SMALLINT NOT NULL,
    [Year]           SMALLINT NOT NULL,
    [Number]         INT      NOT NULL,
    [DateTimeStamp]  DATETIME DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

