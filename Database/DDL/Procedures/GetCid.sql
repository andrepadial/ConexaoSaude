USE [ConexaoSaude]
GO

/****** Object:  StoredProcedure [dbo].[GetCliente]    Script Date: 11/12/2020 12:06:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


IF OBJECT_ID('GetCid') IS NOT NULL
	DROP PROCEDURE GetCid
GO


CREATE PROCEDURE [dbo].[GetCid] (@Codigo NVARCHAR(15), @Descricao NVARCHAR(510))

AS 

BEGIN

	SELECT		Id
				,Codigo
				,Descricao
	FROM		CategoriaCid WITH(NOLOCK)
	WHERE		Codigo = @Codigo
	AND			Descricao LIKE '%' + @Descricao + '%'

END
GO


