CREATE TABLE [dbo].[Administrador]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [Nome] VARCHAR(MAX) NULL, 
    [Sobrenome] VARCHAR(MAX) NULL, 
    [Sexo] VARCHAR(MAX) NULL, 
    [Nascimento] DATE NULL, 
    [TelefoneCel] VARCHAR(MAX) NULL, 
    [TelefoneRes] VARCHAR(MAX) NULL, 
    [Email] VARCHAR(MAX) NULL, 
    [Cargo] VARCHAR(MAX) NULL, 
    [IdUsuario] INT NULL, 
    CONSTRAINT [FK_Administrador_Usuario] FOREIGN KEY (IdUsuario) REFERENCES [Usuario]([Id])
)
