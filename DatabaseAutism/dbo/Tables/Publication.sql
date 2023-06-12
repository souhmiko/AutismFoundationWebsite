CREATE TABLE [dbo].[Publication] (
    [Id]             BIGINT     IDENTITY (1, 1) NOT NULL,
    [ebookCode]         NCHAR (10) NOT NULL,
    [bookCode]          NCHAR (10) NOT NULL,
    [BookId] BIGINT     NOT NULL,
    [bookTitle] NVARCHAR(MAX) NULL, 
    [authorName] NCHAR(10) NULL, 
    [content] NVARCHAR(MAX) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
);





