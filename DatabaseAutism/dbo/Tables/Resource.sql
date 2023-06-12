CREATE TABLE [dbo].[Resource] (
    [Id]             BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name ]          NVARCHAR (50) NOT NULL,
    [Res_CategoryId] BIGINT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Resource_ToResourceCategory] FOREIGN KEY ([Res_CategoryId]) REFERENCES [dbo].[ResourceCategory] ([Id]), 
);





