CREATE TABLE [dbo].[Cars] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT           NULL,
    [ColorId]     INT           NULL,
    [ModelYear]   INT NULL,
    [DailyPrice]  DECIMAL (18)  NULL,
    [Description] NVARCHAR (25) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

