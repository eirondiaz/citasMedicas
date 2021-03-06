USE [citasmedicasdb]
GO
/****** Object:  Table [dbo].[citas]    Script Date: 28/11/2019 16:04:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[citas](
	[id_cita] [int] IDENTITY(1,1) NOT NULL,
	[causa] [varchar](50) NOT NULL,
	[fecha] [varchar](30) NOT NULL,
	[hora] [varchar](10) NULL,
	[paciente] [int] NOT NULL,
	[medico] [int] NOT NULL,
	[clinica] [varchar](30) NOT NULL,
 CONSTRAINT [pk_id_cita] PRIMARY KEY CLUSTERED 
(
	[id_cita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clinicas]    Script Date: 28/11/2019 16:04:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clinicas](
	[id_clinica] [int] NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[direccion] [varchar](30) NOT NULL,
 CONSTRAINT [pk_id_clinica] PRIMARY KEY CLUSTERED 
(
	[id_clinica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medicos]    Script Date: 28/11/2019 16:04:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicos](
	[id_medico] [int] NOT NULL,
	[cedula] [varchar](30) NULL,
	[exequatur] [int] NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[tel] [bigint] NOT NULL,
	[email] [varchar](30) NOT NULL,
	[id_clinica] [int] NOT NULL,
 CONSTRAINT [pk_id_medico] PRIMARY KEY CLUSTERED 
(
	[id_medico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pacientes]    Script Date: 28/11/2019 16:04:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pacientes](
	[id_paciente] [int] NOT NULL,
	[cedula] [varchar](30) NULL,
	[nombre] [varchar](30) NOT NULL,
	[tel] [bigint] NOT NULL,
	[email] [varchar](30) NOT NULL,
	[direccion] [varchar](30) NOT NULL,
 CONSTRAINT [pk_id_paciente] PRIMARY KEY CLUSTERED 
(
	[id_paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[citas]  WITH CHECK ADD  CONSTRAINT [fk_id_medico] FOREIGN KEY([medico])
REFERENCES [dbo].[medicos] ([id_medico])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[citas] CHECK CONSTRAINT [fk_id_medico]
GO
ALTER TABLE [dbo].[citas]  WITH CHECK ADD  CONSTRAINT [fk_id_paciente] FOREIGN KEY([paciente])
REFERENCES [dbo].[pacientes] ([id_paciente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[citas] CHECK CONSTRAINT [fk_id_paciente]
GO
ALTER TABLE [dbo].[medicos]  WITH CHECK ADD  CONSTRAINT [fk_id_clinica] FOREIGN KEY([id_clinica])
REFERENCES [dbo].[clinicas] ([id_clinica])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[medicos] CHECK CONSTRAINT [fk_id_clinica]
GO
