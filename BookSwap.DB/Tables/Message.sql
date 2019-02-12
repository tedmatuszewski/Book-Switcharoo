﻿CREATE TABLE [dbo].[Message]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[User] VARCHAR(255) NOT NULL,
	[Text] VARCHAR(511) NOT NULL,
	[From] VARCHAR(255) NOT NULL,
    [BookId] INT NULL, 
    [DateAdded] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    [IsDeleted] BIT NOT NULL DEFAULT 0, 
)
