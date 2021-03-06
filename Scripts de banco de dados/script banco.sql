USE [Sisgacv2]
GO
/****** Object:  Table [dbo].[Cadas_Prof]    Script Date: 06/13/2013 00:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cadas_Prof](
	[Cd_Prof] [int] IDENTITY(1,1) NOT NULL,
	[CPF] [int] NULL,
	[Data_Nasc] [date] NULL,
	[Nome] [varchar](50) NULL,
	[Endereco] [varchar](50) NULL,
	[Bairro] [varchar](50) NULL,
	[Cidade] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[Telefone] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Formacao] [varchar](100) NULL,
	[Caminho] [varchar](200) NULL,
	[Senha] [varchar](50) NULL,
 CONSTRAINT [PK_Cadas_Prof] PRIMARY KEY CLUSTERED 
(
	[Cd_Prof] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cadas_Livros]    Script Date: 06/13/2013 00:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cadas_Livros](
	[Cd_Livro] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](50) NULL,
	[Editora] [varchar](50) NULL,
	[Categoria] [varchar](50) NULL,
	[Data_lancamento] [date] NULL,
	[Data_aquisicao] [date] NULL,
	[preco_custo] [decimal](15, 2) NULL,
	[estoque] [int] NULL,
	[valor_multa] [decimal](15, 2) NULL,
 CONSTRAINT [PK_Cadas_Livros] PRIMARY KEY CLUSTERED 
(
	[Cd_Livro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cadas_Func]    Script Date: 06/13/2013 00:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cadas_Func](
	[Cd_Func] [int] IDENTITY(1,1) NOT NULL,
	[CPF] [int] NULL,
	[Data_Nas] [date] NULL,
	[Nome] [varchar](50) NULL,
	[Endereco] [varchar](50) NULL,
	[Bairro] [varchar](50) NULL,
	[Cidade] [varchar](50) NULL,
	[Estado] [varchar](2) NULL,
	[Telefone] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Funcao] [varchar](50) NULL,
	[Caminho] [varchar](200) NULL,
	[Senha] [varchar](50) NULL,
 CONSTRAINT [PK_Cadas_Func] PRIMARY KEY CLUSTERED 
(
	[Cd_Func] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cadas_Cursos]    Script Date: 06/13/2013 00:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cadas_Cursos](
	[Cd_Curso] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
	[Qtd_Semestres] [varchar](2) NULL,
 CONSTRAINT [PK_Cadas_Cursos] PRIMARY KEY CLUSTERED 
(
	[Cd_Curso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cadas_Aluno]    Script Date: 06/13/2013 00:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cadas_Aluno](
	[Cd_Aluno] [int] IDENTITY(1,1) NOT NULL,
	[CPF] [int] NULL,
	[Data_Nasc] [date] NULL,
	[Nome] [varchar](50) NULL,
	[Endereco] [varchar](50) NULL,
	[Bairro] [varchar](50) NULL,
	[Cidade] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[Telefone] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Matricula] [int] NULL,
	[Curso] [varchar](50) NULL,
	[Caminho] [varchar](200) NULL,
	[Senha] [varchar](50) NULL,
 CONSTRAINT [PK_Cadas_Aluno] PRIMARY KEY CLUSTERED 
(
	[Cd_Aluno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lancamento_Notas]    Script Date: 06/13/2013 00:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lancamento_Notas](
	[Cd_Lancamento] [int] IDENTITY(1,1) NOT NULL,
	[Cd_Aluno] [int] NOT NULL,
	[Cd_Prof] [int] NOT NULL,
	[Nome_Aluno] [varchar](50) NULL,
	[Nome_Prof] [varchar](50) NULL,
	[Materia] [varchar](50) NULL,
	[Curso] [varchar](50) NULL,
	[Semestre] [int] NULL,
	[Media_Final] [decimal](15, 2) NULL,
	[Faltas] [int] NULL,
 CONSTRAINT [PK_Lancamento_Notas] PRIMARY KEY CLUSTERED 
(
	[Cd_Lancamento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cadas_Emprestimos]    Script Date: 06/13/2013 00:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cadas_Emprestimos](
	[Cd_Emprestimo] [int] IDENTITY(1,1) NOT NULL,
	[Cd_Livro] [int] NULL,
	[Nome_Livro] [varchar](50) NULL,
	[Codigo_solicitante] [int] NULL,
	[Nome_solicitante] [varchar](50) NULL,
	[Data_retirada] [date] NULL,
	[Data_previsao] [date] NULL,
	[Status] [varchar](50) NULL,
	[Multa] [decimal](15, 2) NULL,
 CONSTRAINT [PK_Cadas_Emprestimos] PRIMARY KEY CLUSTERED 
(
	[Cd_Emprestimo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Cadas_Emprestimos_Cadas_Livros]    Script Date: 06/13/2013 00:51:53 ******/
ALTER TABLE [dbo].[Cadas_Emprestimos]  WITH CHECK ADD  CONSTRAINT [FK_Cadas_Emprestimos_Cadas_Livros] FOREIGN KEY([Cd_Livro])
REFERENCES [dbo].[Cadas_Livros] ([Cd_Livro])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cadas_Emprestimos] CHECK CONSTRAINT [FK_Cadas_Emprestimos_Cadas_Livros]
GO
/****** Object:  ForeignKey [FK_Lancamento_Notas_Cadas_Aluno]    Script Date: 06/13/2013 00:51:53 ******/
ALTER TABLE [dbo].[Lancamento_Notas]  WITH CHECK ADD  CONSTRAINT [FK_Lancamento_Notas_Cadas_Aluno] FOREIGN KEY([Cd_Aluno])
REFERENCES [dbo].[Cadas_Aluno] ([Cd_Aluno])
GO
ALTER TABLE [dbo].[Lancamento_Notas] CHECK CONSTRAINT [FK_Lancamento_Notas_Cadas_Aluno]
GO
/****** Object:  ForeignKey [FK_Lancamento_Notas_Cadas_Prof]    Script Date: 06/13/2013 00:51:53 ******/
ALTER TABLE [dbo].[Lancamento_Notas]  WITH CHECK ADD  CONSTRAINT [FK_Lancamento_Notas_Cadas_Prof] FOREIGN KEY([Cd_Prof])
REFERENCES [dbo].[Cadas_Prof] ([Cd_Prof])
GO
ALTER TABLE [dbo].[Lancamento_Notas] CHECK CONSTRAINT [FK_Lancamento_Notas_Cadas_Prof]
GO
