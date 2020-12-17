USE ConexaoSaude
GO


IF OBJECT_ID('dbo.CategoriaCID') IS NOT NULL
	DROP TABLE CategoriaCid
GO


CREATE TABLE dbo.CategoriaCid (

	Id			INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Codigo		NVARCHAR(5),
	Descricao	NVARCHAR(255)
	
)