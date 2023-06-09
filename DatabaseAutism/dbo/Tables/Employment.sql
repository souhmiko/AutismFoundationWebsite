﻿CREATE TABLE [dbo].[Employment] (
    [Id]               BIGINT IDENTITY (1, 1) NOT NULL,
    [Name]             NTEXT  NULL,
    [EmployerId]       BIGINT NOT NULL,
    [EmployLearningId] BIGINT NOT NULL,
    [EmployTrainId]    BIGINT NOT NULL,
    [Employasd] BIGINT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Employment_ToEmploy.Learning] FOREIGN KEY ([EmployLearningId]) REFERENCES [dbo].[Employ.Learning] ([Id]),
    CONSTRAINT [FK_Employment_ToEmploy.Training] FOREIGN KEY ([EmployTrainId]) REFERENCES [dbo].[Employ.Training] ([Id]),
    CONSTRAINT [FK_Employment_ToEmployment] FOREIGN KEY ([EmployerId]) REFERENCES [dbo].[Employment] ([Id]), 
    CONSTRAINT [FK_Employment_ToEmployer] FOREIGN KEY ([EmployerId]) REFERENCES [dbo].[Employer]([Id]), 
    CONSTRAINT [FK_Employment_ToEmploy.ASD] FOREIGN KEY (Employasd) REFERENCES [dbo].[Employ.ASD]([Id])
);

