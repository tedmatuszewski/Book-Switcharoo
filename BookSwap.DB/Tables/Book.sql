﻿CREATE TABLE [dbo].[Book]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Image] VARCHAR(MAX) NOT NULL, 
    [Title] VARCHAR(255) NOT NULL, 
    [Isbn] VARCHAR(255) NOT NULL, 
    [User] VARCHAR(255) NOT NULL, 
    [Condition] VARCHAR(50) NOT NULL, 
    [IsDeleted] BIT NOT NULL DEFAULT 0
)
