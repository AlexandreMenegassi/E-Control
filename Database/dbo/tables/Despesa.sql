CREATE TABLE [dbo].[Despesa]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [Descricao] VARCHAR(MAX) NULL, 
    [valor] MONEY NULL, 
    [data] DATE NULL, 
    [custo] MONEY NULL,
	CONSTRAINT [FK_Nome_Fornecedor] FOREIGN KEY (id) REFERENCES Fornecedor(id) 
)
