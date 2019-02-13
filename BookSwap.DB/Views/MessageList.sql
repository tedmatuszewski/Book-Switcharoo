CREATE VIEW [dbo].[MessageList]
	AS 
	SELECT 
		MAX(m.[DateAdded]) AS 'DateAdded',
		m.[User],
		m.[Text],
		m.[From],
		b.[Title],
		m.[BookId]
	FROM dbo.[Message] m 
	JOIN dbo.[Book] b on m.BookId = b.Id
	GROUP BY m.[User], m.[Text], m.[From], b.[Title], m.BookId