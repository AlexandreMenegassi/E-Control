CREATE TABLE [dbo].[Servico]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [Nome] VARCHAR(MAX) NULL, 
    [Valor] MONEY NULL, 
    [Custo] MONEY NULL
)
