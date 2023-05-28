CREATE TABLE [dbo].[Publication] (
    [Id]             BIGINT     IDENTITY (1, 1) NOT NULL,
    [ebooks]         NCHAR (10) NOT NULL,
    [books]          NCHAR (10) NOT NULL,
    [Publication_Id] BIGINT     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Publication_ToResource] FOREIGN KEY ([Publication_Id]) REFERENCES [dbo].[Resource] ([Id])
);

