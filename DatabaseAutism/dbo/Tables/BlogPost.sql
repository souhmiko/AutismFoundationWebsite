CREATE TABLE [dbo].[BlogPost] (
    [Id]             BIGINT        IDENTITY (1, 1) NOT NULL,
<<<<<<< HEAD
    [AuthorId]       BIGINT        NULL,
    [parentId]       BIGINT        NULL,
=======
    [AuthorId]       BIGINT        NOT NULL,
    [parentId]       BIGINT        NOT NULL,
>>>>>>> fe85132dc6022029863074b9ffe86a1eccb02e62
    [title]          VARCHAR (100) NOT NULL,
    [publised]       TINYINT       NOT NULL,
    [createdAtdate]  DATETIME      NOT NULL,
    [updatedAtdate]  DATETIME      NOT NULL,
    [publisedAtdate] DATETIME      NOT NULL,
    [content]        TEXT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_BlogPost_ToBlogPost] FOREIGN KEY ([parentId]) REFERENCES [dbo].[BlogPost] ([Id]),
    CONSTRAINT [FK_BlogPost_ToBlogUser] FOREIGN KEY ([AuthorId]) REFERENCES [dbo].[BlogUser] ([Id])
);

