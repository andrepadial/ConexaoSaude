USE [ConexaoSaude]
GO

/****** Object:  Table [dbo].[Dependente]    Script Date: 11/12/2020 12:02:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Dependente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[CpfCnpj] [varchar](15) NULL,
	[RG] [varchar](15) NULL,
	[OrgaoExpedidor] [varchar](3) NULL,
	[DataExpedicao] [datetime] NULL,
	[Nome] [varchar](150) NULL,
	[DataNascimento] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Dependente]  WITH CHECK ADD  CONSTRAINT [FK_Dep_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO

ALTER TABLE [dbo].[Dependente] CHECK CONSTRAINT [FK_Dep_Cliente]
GO


