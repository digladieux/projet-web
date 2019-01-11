CREATE TABLE [dbo].[relationships] (
    [first_character_id]  INT NOT NULL,
    [second_character_id] INT NOT NULL,
    [relation_type]       INT NOT NULL,
    CONSTRAINT [PK_relationships] PRIMARY KEY CLUSTERED ([first_character_id] ASC, [second_character_id] ASC),
    FOREIGN KEY ([first_character_id]) REFERENCES [dbo].[characters] ([id]),
    FOREIGN KEY ([second_character_id]) REFERENCES [dbo].[characters] ([id])
);

