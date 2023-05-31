CREATE TABLE [dbo].[ResourceAttachment] (
    [Id]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [FileName]   NVARCHAR (MAX) NOT NULL,
    [FilePath]   NVARCHAR (MAX) NOT NULL,
    [LanguageId] BIGINT         NOT NULL,
    [FileSize]   BIGINT         NOT NULL,
    [DateUpLoad] INT            NULL,
    [ResourceId] BIGINT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ResourceAttachment_ToLanguage] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Language] ([Id]),
    CONSTRAINT [FK_ResourceAttachment_ToResource] FOREIGN KEY ([ResourceId]) REFERENCES [dbo].[Resource] ([Id])
);

