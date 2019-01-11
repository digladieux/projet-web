CREATE TABLE [dbo].[houses] (
    [id]              INT          IDENTITY (1, 1) NOT NULL,
    [name]            VARCHAR (50) NULL,
    [number_of_units] INT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

