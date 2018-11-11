CREATE TABLE [dbo].[Agenda]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [IdFuncionario] NCHAR(10) NULL, 
    [IdServico] NCHAR(10) NULL, 
    [IdCliente] NCHAR(10) NULL, 
    [DataInicio] DATETIME NULL, 
    [DataFim] DATETIME NULL
)
