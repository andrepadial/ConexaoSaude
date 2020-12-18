USE [ConexaoSaude]
GO

/****** Object:  StoredProcedure [dbo].[GetCliente]    Script Date: 11/12/2020 12:06:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


IF OBJECT_ID('GetSubCategoriasCid') IS NOT NULL
	DROP PROCEDURE GetSubCategoriasCid
GO


CREATE PROCEDURE [dbo].GetSubCategoriasCid (@CodigoCid NVARCHAR(15))

AS 

BEGIN

	SELECT		S.Id
				,S.Codigo
				,S.Descricao
	FROM		SubCategoriaCid S WITH(NOLOCK) INNER JOIN CategoriaCid C WITH(NOLOCK) ON S.IdCategoria = C.Id
	WHERE		C.Codigo = @CodigoCid
	ORDER BY	s.Id

END
GO


