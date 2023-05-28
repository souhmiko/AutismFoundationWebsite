CREATE TABLE [dbo].[ResourceTag] (
    [Id]      BIGINT IDENTITY (1, 1) NOT NULL,
    [TagName] TEXT   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ResourceTag_ToResourceCategory] FOREIGN KEY ([Id]) REFERENCES [dbo].[ResourceCategory] ([Id])
);

