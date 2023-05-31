CREATE TABLE [dbo].[Employ.Training] (
    [Id]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]        NCHAR (10)     NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

