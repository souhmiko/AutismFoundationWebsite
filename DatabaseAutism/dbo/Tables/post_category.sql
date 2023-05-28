CREATE TABLE [dbo].[post_category] (
    [categoryId] BIGINT NOT NULL,
    [postId]     BIGINT NOT NULL,
    CONSTRAINT [PK_post_category] PRIMARY KEY CLUSTERED ([categoryId] ASC, [postId] ASC),
    CONSTRAINT [FK_post_category_BlogPost] FOREIGN KEY ([postId]) REFERENCES [dbo].[BlogPost] ([Id]),
    CONSTRAINT [FK_post_category_category] FOREIGN KEY ([categoryId]) REFERENCES [dbo].[category] ([Id])
);

