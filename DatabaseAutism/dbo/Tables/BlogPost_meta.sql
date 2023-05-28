CREATE TABLE [dbo].[BlogPost_meta] (
    [Id]      BIGINT       IDENTITY (1, 1) NOT NULL,
    [post_Id] BIGINT       NOT NULL,
    [key]     VARCHAR (50) NOT NULL,
    [content] TEXT         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_BlogPost_meta_BlogPost] FOREIGN KEY ([post_Id]) REFERENCES [dbo].[BlogPost] ([Id]),
    CONSTRAINT [AK_BlogPost_meta_post_Id] UNIQUE NONCLUSTERED ([key] ASC)
);

