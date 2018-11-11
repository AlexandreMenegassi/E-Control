CREATE TABLE [dbo].[Fornecedor]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
    [NomeEmp] VARCHAR(MAX) NULL, 
    [NomeRep] VARCHAR(MAX) NULL, 
    [CNPJ] VARCHAR(MAX) NULL, 
    [TelefoneCom1] VARCHAR(MAX) NULL, 
    [TelefoneCom2] VARCHAR(MAX) NULL, 
    [TelefoneCel1] VARCHAR(MAX) NULL, 
    [TelefoneCel2] VARCHAR(MAX) NULL, 
    [Endereco] VARCHAR(MAX) NULL, 
    [DescricaoEmp] VARCHAR(MAX) NULL
)
