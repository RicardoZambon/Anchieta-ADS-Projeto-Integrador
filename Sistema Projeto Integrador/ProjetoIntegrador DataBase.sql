USE [Anchieta_ProjetoIntegrador]
GO
/****** Object:  Table [dbo].[Usuarios_Tipos]    Script Date: 05/23/2013 12:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios_Tipos](
	[Codigo] [int] NOT NULL identity(1, 1),
	[Tipo] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Status]    Script Date: 05/23/2013 12:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Status](
	[Status] [varchar](35) NULL,
	[Codigo] [int] NOT NULL identity(1, 1),
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Prioridades]    Script Date: 05/23/2013 12:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prioridades](
	[Codigo] [int] NOT NULL identity(1, 1),
	[Prioridade] [varchar](35) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empresas]    Script Date: 05/23/2013 12:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empresas](
	[Telefone1] [varchar](18) NULL,
	[Telefone2] [varchar](18) NULL,
	[Email] [varchar](255) NULL,
	[Endereco] [varchar](80) NULL,
	[InscricaoEstadual] [varchar](14) NULL,
	[CNPJ] [varchar](18) NULL,
	[Codigo] [int] NOT NULL identity(1, 1),
	[RazaoSocial] [varchar](80) NULL,
	[CEP] [varchar](10) NULL,
	[Bairro] [varchar](35) NULL,
	[EnderecoNum] [varchar](7) NULL,
	[empresa] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 05/23/2013 12:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamentos](
	[Responsavel] [varchar](80) NULL,
	[Departamento] [varchar](50) NULL,
	[Codigo] [int] NOT NULL identity(1, 1),
	[Empresa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 05/23/2013 12:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Codigo] [int] NOT NULL identity(1, 1),
	[Nome] [varchar](80) NULL,
	[Usuario] [varchar](35) NULL,
	[Senha] [varchar](35) NULL,
	[Departamento] [int] NULL,
	[Tipo] [int] NULL,
	[Empresa] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Chamados]    Script Date: 05/23/2013 12:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Chamados](
	[Codigo] [int] NOT NULL identity(1, 1),
	[DataAbertura] [datetime] NULL,
	[ProblemaInicial] [varchar](2000) NULL,
	[Assunto] [varchar](200) NULL,
	[DataFechamento] [datetime] NULL,
	[Prioridade] [int] NULL,
	[Status] [int] NULL,
	[AbertoPor] [int] NULL,
	[FechadoPor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Chamados_Respostas]    Script Date: 05/23/2013 12:33:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Chamados_Respostas](
	[DataHora] [datetime] NULL,
	[Codigo] [int] NOT NULL identity(1, 1),
	[Resposta] [varchar](2000) NULL,
	[Chamado] [int] NULL,
	[Usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK__Chamados__Aberto__20C1E124]    Script Date: 05/23/2013 12:33:27 ******/
ALTER TABLE [dbo].[Chamados]  WITH CHECK ADD FOREIGN KEY([AbertoPor])
REFERENCES [dbo].[Usuarios] ([Codigo])
GO
/****** Object:  ForeignKey [FK__Chamados__Fechad__21B6055D]    Script Date: 05/23/2013 12:33:27 ******/
ALTER TABLE [dbo].[Chamados]  WITH CHECK ADD FOREIGN KEY([FechadoPor])
REFERENCES [dbo].[Usuarios] ([Codigo])
GO
/****** Object:  ForeignKey [FK__Chamados__Priori__1ED998B2]    Script Date: 05/23/2013 12:33:27 ******/
ALTER TABLE [dbo].[Chamados]  WITH CHECK ADD FOREIGN KEY([Prioridade])
REFERENCES [dbo].[Prioridades] ([Codigo])
GO
/****** Object:  ForeignKey [FK__Chamados__Status__1FCDBCEB]    Script Date: 05/23/2013 12:33:27 ******/
ALTER TABLE [dbo].[Chamados]  WITH CHECK ADD FOREIGN KEY([Status])
REFERENCES [dbo].[Status] ([Codigo])
GO
/****** Object:  ForeignKey [FK__Chamados___Chama__22AA2996]    Script Date: 05/23/2013 12:33:27 ******/
ALTER TABLE [dbo].[Chamados_Respostas]  WITH CHECK ADD FOREIGN KEY([Chamado])
REFERENCES [dbo].[Chamados] ([Codigo])
GO
/****** Object:  ForeignKey [FK__Chamados___Usuar__239E4DCF]    Script Date: 05/23/2013 12:33:27 ******/
ALTER TABLE [dbo].[Chamados_Respostas]  WITH CHECK ADD FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuarios] ([Codigo])
GO
/****** Object:  ForeignKey [FK__Departame__Empre__08EA5793]    Script Date: 05/23/2013 12:33:27 ******/
ALTER TABLE [dbo].[Departamentos]  WITH CHECK ADD FOREIGN KEY([Empresa])
REFERENCES [dbo].[Empresas] ([Codigo])
GO
/****** Object:  ForeignKey [FK__Usuarios__Depart__1920BF5C]    Script Date: 05/23/2013 12:33:27 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([Departamento])
REFERENCES [dbo].[Departamentos] ([Codigo])
GO
/****** Object:  ForeignKey [FK__Usuarios__Tipo__1A14E395]    Script Date: 05/23/2013 12:33:27 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([Tipo])
REFERENCES [dbo].[Usuarios_Tipos] ([Codigo])
GO
/****** Object:  ForeignKey [pk_usuarios_empresa]    Script Date: 05/23/2013 12:33:27 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [pk_usuarios_empresa] FOREIGN KEY([Empresa])
REFERENCES [dbo].[Empresas] ([Codigo])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [pk_usuarios_empresa]
GO
