CREATE TABLE [dbo].[Usuario]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [Login] VARCHAR(50) NULL Unique, 
    [Password] VARCHAR(50) NULL, 
    [NivelDeAcesso] INT NULL
)
