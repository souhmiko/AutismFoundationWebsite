CREATE TABLE [dbo].[Tag] (
    [Id]      BIGINT         IDENTITY (1, 1) NOT NULL,
    [name]    NVARCHAR (50)  NULL,
    [Title]   NVARCHAR (100) NULL,
    [content] NTEXT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
);





