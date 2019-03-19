CREATE TABLE [dbo].[User] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (255) NOT NULL,
    [LastName]  VARCHAR (255) NOT NULL,
    [Password]  VARCHAR (255) NOT NULL,
    [Email]     VARCHAR (255) NOT NULL,
    [DateAdded] DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [IsDeleted] BIT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

