USE [ConexaoSaude]
GO

/****** Object:  StoredProcedure [dbo].[GetCliente]    Script Date: 11/12/2020 12:06:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[GetCliente] (@CpfCnpj VARCHAR(15) = NULL)

AS 

BEGIN

	SELECT		Id, CpfCnpj, RG, OrgaoExpedidor, DataExpedicao, Nome,
				DataNascimento, Mae
	FROM		dbo.Cliente WITH(NOLOCK)
	WHERE		(@CpfCnpj IS NULL OR CpfCnpj = @CpfCnpj)

END
GO


