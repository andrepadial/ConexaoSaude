USE ConexaoSaude
GO


IF OBJECT_ID('dbo.Operadoras') IS NOT NULL
	DROP TABLE Operadoras
GO


CREATE TABLE dbo.Operadoras (

	Id				INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CodigoANS		VARCHAR(15),
	Cnpj			VARCHAR(20),
	RazaoSocial		VARCHAR(255),
	NomeFantasia	VARCHAR(100),
	Modalidade		VARCHAR(100),
	Endereco		VARCHAR(100),
	Numero			VARCHAR(30),
	Complemento		VARCHAR(100),	
	Bairro			VARCHAR(100),
	Cidade			VARCHAR(100),
	Uf				VARCHAR(2),
	Cep				FLOAT,
	Ddd				FLOAT,
	Telefone		FLOAT,
	Email			VARCHAR(50),
	Representante	VARCHAR(100),
	CargoRepresentante	VARCHAR(100)
	
)