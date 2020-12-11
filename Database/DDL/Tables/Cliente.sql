USE [ConexaoSaude]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 11/12/2020 12:02:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CpfCnpj] [varchar](15) NULL,
	[RG] [varchar](15) NULL,
	[OrgaoExpedidor] [varchar](3) NULL,
	[DataExpedicao] [datetime] NULL,
	[Nome] [varchar](150) NULL,
	[DataNascimento] [datetime] NULL,
	[Mae] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


