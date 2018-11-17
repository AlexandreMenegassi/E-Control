CREATE TABLE [dbo].[Logins]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [User] VARCHAR(50) NULL, 
    [Password] VARCHAR(50) NULL
)
