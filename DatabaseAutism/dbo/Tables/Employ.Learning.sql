CREATE TABLE [dbo].[Employ.Learning] (
    [Id]       BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]     NCHAR (10)     NOT NULL,
    [Location] NVARCHAR (100) NULL,
    [StarDate] DATE           NULL,
    [EndDate]  DATE           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

