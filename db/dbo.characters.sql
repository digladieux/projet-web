CREATE TABLE [dbo].[characters] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [bravoury]  INT          NULL,
    [crazyness] INT          NULL,
    [firstname] VARCHAR (50) NULL,
    [lastname]  VARCHAR (50) NULL,
    [pv]        INT          NULL,
    [strength]  INT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

