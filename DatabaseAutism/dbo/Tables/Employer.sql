CREATE TABLE [dbo].[Employer] (
    [Id]          BIGINT        IDENTITY (1, 1) NOT NULL,
    [name]        NTEXT         NOT NULL,
    [address]     NVARCHAR (50) NOT NULL,
    [PhoneNumber] NCHAR (25)    NOT NULL,
    [email]       NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

