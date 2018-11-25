CREATE TABLE [dbo].[Preco]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
	[IdServico] INT NULL,
    [Custo] MONEY NULL, 
    [Desconto] FLOAT NULL, 
    [IdFuncionario] INT NULL, 
    CONSTRAINT [FK_Preco_ToTable] FOREIGN KEY ([IdFuncionario]) REFERENCES [Funcionario]([Id]), 
    CONSTRAINT [FK_Preco_Servico] FOREIGN KEY (id) REFERENCES Servico(id)
)
