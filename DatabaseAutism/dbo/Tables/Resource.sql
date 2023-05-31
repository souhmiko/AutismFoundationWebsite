CREATE TABLE [dbo].[Resource] (
    [Id]             BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name ]          NVARCHAR (50) NOT NULL,
    [Res_CategoryId] NTEXT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

