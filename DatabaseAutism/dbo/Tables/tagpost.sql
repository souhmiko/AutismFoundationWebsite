CREATE TABLE [dbo].[tagpost] (
    [Id]      BIGINT    IDENTITY (1, 1) NOT NULL,
    [post_Id] BIGINT NOT NULL,
    [tag_Id]  BIGINT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_tagpost_ToBlogPost] FOREIGN KEY ([post_Id]) REFERENCES [BlogPost]([Id]), 
    CONSTRAINT [FK_tagpost_ToTag] FOREIGN KEY ([tag_Id]) REFERENCES [Tag]([Id])
);

