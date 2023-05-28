CREATE TABLE [dbo].[post_comment] (
    [Id]              BIGINT         IDENTITY (1, 1) NOT NULL,
    [postId]          BIGINT         NOT NULL,
    [parentId]        BIGINT         NOT NULL,
    [title]           VARBINARY (50) NOT NULL,
    [published]       TINYINT        NOT NULL,
    [createdAtdate]   DATETIME       NOT NULL,
    [publishedAtdate] DATETIME       NOT NULL,
    [content]         TEXT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_post_comment_ToBlogPost] FOREIGN KEY ([postId]) REFERENCES [dbo].[BlogPost] ([Id]),
    CONSTRAINT [FK_post_comment_Topost_comment] FOREIGN KEY ([parentId]) REFERENCES [dbo].[post_comment] ([Id])
);

