CREATE TABLE [dbo].[Employ.ASD] (
    [Id]   BIGINT     IDENTITY (1, 1) NOT NULL,
    [Name] NCHAR (10) NULL,
    [ASDID] BIGINT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Employ.ASD_ToEmployment] FOREIGN KEY ([ASDID]) REFERENCES [dbo].[Employment]([Id])
);

