USE ConexaoSaude
GO


IF OBJECT_ID('dbo.SubCategoriaCid') IS NOT NULL
	DROP TABLE dbo.SubCategoriaCid
GO


CREATE TABLE dbo.SubCategoriaCid (

	Id			INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	IdCategoria	INT NOT NULL,
	Codigo		NVARCHAR(15),
	Descricao	NVARCHAR(255)
	
)

ALTER TABLE dbo.SubCategoriaCID ADD CONSTRAINT FK_CategoriaCID Foreign Key(IdCategoria) REFERENCES CategoriaCid(Id);

GO