CREATE TABLE [dbo].[BlogUser] (
    [Id]           BIGINT        IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (50) NOT NULL,
    [LastName]     NVARCHAR (50) NOT NULL,
    [MobileNumber] NVARCHAR (50) NOT NULL,
    [email]        NTEXT         NOT NULL,
    [password]     NCHAR (10)    NOT NULL,
    [RegDate]      DATETIME      NULL,
    [Intro]        TEXT          NOT NULL,
    [profile]      NTEXT         NOT NULL,
    [aspnetuserID] NVARCHAR(450) NOT NULL ,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_User_ToTable] FOREIGN KEY ([aspnetuserID]) REFERENCES [AspNetUsers]([Id]),
);

