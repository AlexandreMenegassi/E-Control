CREATE TABLE [dbo].[Cliente]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nome] VARCHAR(MAX) NULL, 
    [Sobrenome] VARCHAR(MAX) NULL, 
    [Sexo] VARCHAR(MAX) NULL, 
    [Nascimento] DATE NULL, 
    [Endereco] VARCHAR(MAX) NULL, 
    [EnderecoNum] VARCHAR(MAX) NULL, 
    [TelefoneCel] VARCHAR(MAX) NULL, 
    [TelefoneRes] VARCHAR(MAX) NULL, 
    [Email] VARCHAR(MAX) NULL, 
    [Complemento] VARCHAR(MAX) NULL, 
    [Profissao] VARCHAR(MAX) NULL
)
