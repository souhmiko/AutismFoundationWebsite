CREATE TABLE [dbo].[ResourceTag] (
    [Id]      BIGINT IDENTITY (1, 1) NOT NULL,
    [Tag_Name] TEXT   NOT NULL,
    [TagId] BIGINT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ResourceTag_ToResourceCategory] FOREIGN KEY ([TagId]) REFERENCES [dbo].[ResourceCategory] ([Id])
);



