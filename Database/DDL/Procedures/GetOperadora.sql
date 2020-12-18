USE [ConexaoSaude]
GO

/****** Object:  StoredProcedure [dbo].[GetCliente]    Script Date: 11/12/2020 12:06:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


IF OBJECT_ID('GetOperadora') IS NOT NULL
	DROP PROCEDURE GetOperadora
GO


CREATE PROCEDURE [dbo].GetOperadora (@Cnpj NVARCHAR(20), @RazaoSocial NVARCHAR(150))

AS 

BEGIN

		SELECT		Id
					,CodigoANS
					,Cnpj
					,RazaoSocial
					,NomeFantasia
					,Modalidade
					,Endereco
					,Numero
					,Complemento
					,Bairro
					,Cidade
					,Uf
					,Cep
					,Ddd
					,Telefone
					,Email
					,Representante
					,CargoRepresentante
		FROM		Operadoras
		WHERE		(@Cnpj = '' OR Cnpj LIKE '%' + @Cnpj + '%')						 
		AND			@RazaoSocial = '' OR RazaoSocial LIKE '%' + @RazaoSocial + '%'
					
		ORDER BY	RazaoSocial

END
GO


