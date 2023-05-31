CREATE TABLE [dbo].[Age.Range] (
    [Id]            BIGINT     IDENTITY (1, 1) NOT NULL,
    [AgeRange]    BIGINT     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Age.Range_ToResourceAgeRange] FOREIGN KEY ([AgeRange]) REFERENCES [dbo].[ResourceAgeRange] ([Id])
);

