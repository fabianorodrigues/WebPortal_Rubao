create database SMT_Teste

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tecnico](
	[CPF] [varchar] (14) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[CEP] [varchar](255) NULL,
	[Logradouro] [varchar](255) NULL,
	[Cidade] [varchar](255) NULL,
	[Estado] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
	[Telefone] [varchar](255) NULL,
	[Imagem] [image] NULL,
 CONSTRAINT [PK_Tecnico_CPF] PRIMARY KEY CLUSTERED 
(
	[CPF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

