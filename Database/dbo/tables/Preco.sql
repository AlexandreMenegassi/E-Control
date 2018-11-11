CREATE TABLE [dbo].[Preco]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
	[IdServico] VARCHAR(MAX) NULL,
    [Custo] MONEY NULL, 
    [Desconto] FLOAT NULL, 
    [IdFuncionario] INT NULL, 
    CONSTRAINT [FK_Preco_ToTable] FOREIGN KEY ([IdFuncionario]) REFERENCES [Funcionario]([Id])
)
