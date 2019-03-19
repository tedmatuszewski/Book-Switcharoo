CREATE TABLE [dbo].[Book] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Image]       VARCHAR (MAX) NOT NULL,
    [Title]       VARCHAR (255) NOT NULL,
    [Isbn]        VARCHAR (255) NOT NULL,
    [User]        VARCHAR (255) NOT NULL,
    [Condition]   VARCHAR (50)  NOT NULL,
    [Description] VARCHAR (500) NOT NULL,
    [University]  VARCHAR (255) NOT NULL,
    [Class]       VARCHAR (255) NOT NULL,
    [DateAdded]   DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [IsDeleted]   BIT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

