CREATE TABLE [dbo].[character_to_house] (
    [house_id]  INT NOT NULL,
    [character] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([house_id] ASC, [character] ASC),
    FOREIGN KEY ([house_id]) REFERENCES [dbo].[houses] ([id])
);

