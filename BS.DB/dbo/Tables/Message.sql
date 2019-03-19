CREATE TABLE [dbo].[Message] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Text]      VARCHAR (1023) NOT NULL,
    [ThreadId]  INT            NOT NULL,
    [SentBy]    VARCHAR (50)   NOT NULL,
    [DateAdded] DATETIME2 (7)  DEFAULT (getdate()) NOT NULL,
    [IsDeleted] BIT            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Message_Thread] FOREIGN KEY ([ThreadId]) REFERENCES [dbo].[Thread] ([Id])
);

