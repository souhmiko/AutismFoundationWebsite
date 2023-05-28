CREATE TABLE [dbo].[category] (
    [Id]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [parentId] BIGINT        NOT NULL,
    [title]    NVARCHAR (50) NOT NULL,
    [content]  TEXT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_category_parent] FOREIGN KEY ([parentId]) REFERENCES [dbo].[category] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_category_parent]
    ON [dbo].[category]([parentId] ASC);

