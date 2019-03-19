CREATE TABLE [dbo].[Thread] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [To]        VARCHAR (255) NOT NULL,
    [From]      VARCHAR (255) NOT NULL,
    [BookId]    INT           NOT NULL,
    [DateAdded] DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [IsDeleted] BIT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Thread_Book] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Book] ([Id])
);

