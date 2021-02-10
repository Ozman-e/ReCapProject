CREATE TABLE [dbo].[Table] (
    [Id]          INT           NOT NULL,
    [BrandId]     INT           NULL,
    [ColorId]     INT           NULL,
    [ModelYear]   INT           NULL,
    [Description] NVARCHAR (25) NULL,
    [DailyPrice] SMALLINT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

