CREATE TABLE [dbo].[Agenda]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [IdFuncionario] NCHAR(10) NULL, 
    [IdServico] NCHAR(10) NULL, 
    [IdCliente] NCHAR(10) NULL, 
    [DataInicio] DATETIME NULL, 
    [DataFim] DATETIME NULL
)
