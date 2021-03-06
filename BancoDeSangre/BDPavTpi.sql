USE [master]
GO
/****** Object:  Database [PavTpi]    Script Date: 20/04/2021 17:40:37 ******/
CREATE DATABASE [PavTpi]
 CONTAINMENT = NONE
GO
ALTER DATABASE [PavTpi] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PavTpi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PavTpi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PavTpi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PavTpi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PavTpi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PavTpi] SET ARITHABORT OFF 
GO
ALTER DATABASE [PavTpi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PavTpi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PavTpi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PavTpi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PavTpi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PavTpi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PavTpi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PavTpi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PavTpi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PavTpi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PavTpi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PavTpi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PavTpi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PavTpi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PavTpi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PavTpi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PavTpi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PavTpi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PavTpi] SET  MULTI_USER 
GO
ALTER DATABASE [PavTpi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PavTpi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PavTpi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PavTpi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PavTpi] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PavTpi]
GO
/****** Object:  Table [dbo].[Barrio]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Barrio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_localidad] [int] NULL,
 CONSTRAINT [PK_Barrio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Beneficiario]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Beneficiario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cuil] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[id_sexo] [int] NULL,
	[id_diagnostico] [int] NULL,
	[fec_nac] [date] NULL,
	[id_estado_benef] [int] NULL,
	[calle] [varchar](50) NULL,
	[nro_calle] [varchar](50) NULL,
	[id_barrio] [int] NULL,
 CONSTRAINT [PK_Beneficiario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Campaña]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Campaña](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha_inicio] [date] NULL,
	[fecha_fin] [date] NULL,
	[nombre] [varchar](50) NULL,
	[lema] [varchar](50) NULL,
 CONSTRAINT [PK_Campaña] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_provincia] [int] NULL,
 CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Diagnostico]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diagnostico](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Diagnostico] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Direccion]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](10) NULL,
	[legajo_supervisor] [int] NULL,
 CONSTRAINT [PK_Direccion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Donacion]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Donacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_doc] [int] NULL,
	[nro_doc] [varchar](50) NULL,
	[fec_extraccion] [date] NULL,
	[hora_extraccion] [varchar](50) NULL,
	[legajo_enfermero_extractor] [int] NULL,
	[numero_sala] [int] NULL,
	[puesto] [int] NULL,
	[id_tipo_donacion] [int] NULL,
	[id_estado_donacion] [int] NULL,
	[id_grupo_sanguineo] [int] NULL,
	[id_factor_sanguineo] [int] NULL,
	[voluntaria] [varchar](50) NULL,
 CONSTRAINT [PK_Donacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Donacion_Campaña]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donacion_Campaña](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_donacion] [int] NULL,
	[id_campaña] [int] NULL,
 CONSTRAINT [PK_Donacion_Campaña] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Donaciones_beneficiarios]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Donaciones_beneficiarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_beneficiario] [int] NULL,
	[fecha_entrega] [date] NULL,
	[hora_entrega] [varchar](50) NULL,
	[legajo_encargado_entrega] [int] NULL,
	[id_donacion] [int] NULL,
 CONSTRAINT [PK_Donaciones_beneficiarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Donante]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Donante](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_doc] [int] NULL,
	[nro_doc] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[edad] [int] NULL,
	[id_sexo] [int] NULL,
	[peso_kg] [float] NULL,
	[altura_cm] [float] NULL,
	[calle] [varchar](50) NULL,
	[nro_calle] [varchar](50) NULL,
	[id_barrio] [int] NULL,
 CONSTRAINT [PK_Donante] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[legajo] [int] NULL,
	[apellido] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[fec_nac] [date] NULL,
	[id_seccion] [int] NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estado_Beneficiario]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estado_Beneficiario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[estado] [varchar](50) NULL,
 CONSTRAINT [PK_Estado_Beneficiario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estado_donacion]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_donacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[estado] [nchar](10) NULL,
 CONSTRAINT [PK_Estado_donacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Factor]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Factor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Factor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gerencia]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gerencia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_direccion] [int] NULL,
	[legajo_supervisor] [int] NULL,
 CONSTRAINT [PK_Gerencia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Grupo_sanguineo]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Grupo_sanguineo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Grupo_sanguineo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Localidad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_departamento] [int] NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Seccion]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Seccion](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_gerencia] [int] NULL,
	[legajo_supervisor] [int] NULL,
 CONSTRAINT [PK_Seccion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sexo](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Solicitud_Beneficiario]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Solicitud_Beneficiario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[año] [int] NULL,
	[id_beneficiario] [int] NULL,
	[cantidad] [int] NULL,
	[id_unidad_medida] [int] NULL,
	[id_tipo_donacion] [int] NULL,
	[id_grupo_sanguineo] [int] NULL,
	[id_factor_sanguineo] [int] NULL,
 CONSTRAINT [PK_Solicitud_Beneficiario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Telefono_Donante]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Telefono_Donante](
	[id_tipo_doc] [int] NULL,
	[nro_documento] [varchar](50) NULL,
	[numero_telefono] [varchar](50) NULL,
	[id_tipo_telefono] [int] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Telefono_Donante] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tipo_documento]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipo_documento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](50) NULL,
 CONSTRAINT [PK_Tipo_documento] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tipo_donacion]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipo_donacion](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Tipo_donacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tipo_telefono]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipo_telefono](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Tipo_telefono] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Unidad_medida]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Unidad_medida](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Unidad_medida] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
	[legajo_empleado] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 20/04/2021 17:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreDelUsuario] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Barrio]  WITH CHECK ADD  CONSTRAINT [FK_Barrio_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id])
GO
ALTER TABLE [dbo].[Barrio] CHECK CONSTRAINT [FK_Barrio_Localidad]
GO
ALTER TABLE [dbo].[Beneficiario]  WITH CHECK ADD  CONSTRAINT [FK_Beneficiario_Barrio] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrio] ([id])
GO
ALTER TABLE [dbo].[Beneficiario] CHECK CONSTRAINT [FK_Beneficiario_Barrio]
GO
ALTER TABLE [dbo].[Beneficiario]  WITH CHECK ADD  CONSTRAINT [FK_Beneficiario_Estado_Beneficiario] FOREIGN KEY([id_estado_benef])
REFERENCES [dbo].[Estado_Beneficiario] ([id])
GO
ALTER TABLE [dbo].[Beneficiario] CHECK CONSTRAINT [FK_Beneficiario_Estado_Beneficiario]
GO
ALTER TABLE [dbo].[Beneficiario]  WITH CHECK ADD  CONSTRAINT [FK_Beneficiario_Sexo] FOREIGN KEY([id_sexo])
REFERENCES [dbo].[Sexo] ([id])
GO
ALTER TABLE [dbo].[Beneficiario] CHECK CONSTRAINT [FK_Beneficiario_Sexo]
GO
ALTER TABLE [dbo].[Departamento]  WITH CHECK ADD  CONSTRAINT [FK_Departamento_Provincia] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[Provincia] ([id])
GO
ALTER TABLE [dbo].[Departamento] CHECK CONSTRAINT [FK_Departamento_Provincia]
GO
ALTER TABLE [dbo].[Donacion]  WITH CHECK ADD  CONSTRAINT [FK_Donacion_Estado_donacion] FOREIGN KEY([id_estado_donacion])
REFERENCES [dbo].[Estado_donacion] ([id])
GO
ALTER TABLE [dbo].[Donacion] CHECK CONSTRAINT [FK_Donacion_Estado_donacion]
GO
ALTER TABLE [dbo].[Donacion]  WITH CHECK ADD  CONSTRAINT [FK_Donacion_Factor] FOREIGN KEY([id_factor_sanguineo])
REFERENCES [dbo].[Factor] ([id])
GO
ALTER TABLE [dbo].[Donacion] CHECK CONSTRAINT [FK_Donacion_Factor]
GO
ALTER TABLE [dbo].[Donacion]  WITH CHECK ADD  CONSTRAINT [FK_Donacion_Grupo_sanguineo] FOREIGN KEY([id_grupo_sanguineo])
REFERENCES [dbo].[Grupo_sanguineo] ([id])
GO
ALTER TABLE [dbo].[Donacion] CHECK CONSTRAINT [FK_Donacion_Grupo_sanguineo]
GO
ALTER TABLE [dbo].[Donacion]  WITH CHECK ADD  CONSTRAINT [FK_Donacion_Tipo_documento] FOREIGN KEY([id_tipo_doc])
REFERENCES [dbo].[Tipo_documento] ([id])
GO
ALTER TABLE [dbo].[Donacion] CHECK CONSTRAINT [FK_Donacion_Tipo_documento]
GO
ALTER TABLE [dbo].[Donacion]  WITH CHECK ADD  CONSTRAINT [FK_Donacion_Tipo_donacion] FOREIGN KEY([id_tipo_donacion])
REFERENCES [dbo].[Tipo_donacion] ([id])
GO
ALTER TABLE [dbo].[Donacion] CHECK CONSTRAINT [FK_Donacion_Tipo_donacion]
GO
ALTER TABLE [dbo].[Donacion_Campaña]  WITH CHECK ADD  CONSTRAINT [FK_Donacion_Campaña_Campaña] FOREIGN KEY([id_campaña])
REFERENCES [dbo].[Campaña] ([id])
GO
ALTER TABLE [dbo].[Donacion_Campaña] CHECK CONSTRAINT [FK_Donacion_Campaña_Campaña]
GO
ALTER TABLE [dbo].[Donacion_Campaña]  WITH CHECK ADD  CONSTRAINT [FK_Donacion_Campaña_Donacion] FOREIGN KEY([id_donacion])
REFERENCES [dbo].[Donacion] ([id])
GO
ALTER TABLE [dbo].[Donacion_Campaña] CHECK CONSTRAINT [FK_Donacion_Campaña_Donacion]
GO
ALTER TABLE [dbo].[Donaciones_beneficiarios]  WITH CHECK ADD  CONSTRAINT [FK_Donaciones_beneficiarios_Beneficiario] FOREIGN KEY([id_beneficiario])
REFERENCES [dbo].[Beneficiario] ([id])
GO
ALTER TABLE [dbo].[Donaciones_beneficiarios] CHECK CONSTRAINT [FK_Donaciones_beneficiarios_Beneficiario]
GO
ALTER TABLE [dbo].[Donaciones_beneficiarios]  WITH CHECK ADD  CONSTRAINT [FK_Donaciones_beneficiarios_Donacion] FOREIGN KEY([id_donacion])
REFERENCES [dbo].[Donacion] ([id])
GO
ALTER TABLE [dbo].[Donaciones_beneficiarios] CHECK CONSTRAINT [FK_Donaciones_beneficiarios_Donacion]
GO
ALTER TABLE [dbo].[Donante]  WITH CHECK ADD  CONSTRAINT [FK_Donante_Barrio] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrio] ([id])
GO
ALTER TABLE [dbo].[Donante] CHECK CONSTRAINT [FK_Donante_Barrio]
GO
ALTER TABLE [dbo].[Donante]  WITH CHECK ADD  CONSTRAINT [FK_Donante_Sexo] FOREIGN KEY([id_sexo])
REFERENCES [dbo].[Sexo] ([id])
GO
ALTER TABLE [dbo].[Donante] CHECK CONSTRAINT [FK_Donante_Sexo]
GO
ALTER TABLE [dbo].[Donante]  WITH CHECK ADD  CONSTRAINT [FK_Donante_Tipo_documento] FOREIGN KEY([id_tipo_doc])
REFERENCES [dbo].[Tipo_documento] ([id])
GO
ALTER TABLE [dbo].[Donante] CHECK CONSTRAINT [FK_Donante_Tipo_documento]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Seccion] FOREIGN KEY([id_seccion])
REFERENCES [dbo].[Seccion] ([id])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Seccion]
GO
ALTER TABLE [dbo].[Gerencia]  WITH CHECK ADD  CONSTRAINT [FK_Gerencia_Direccion] FOREIGN KEY([id_direccion])
REFERENCES [dbo].[Direccion] ([id])
GO
ALTER TABLE [dbo].[Gerencia] CHECK CONSTRAINT [FK_Gerencia_Direccion]
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD  CONSTRAINT [FK_Localidad_Departamento] FOREIGN KEY([id_departamento])
REFERENCES [dbo].[Departamento] ([id])
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [FK_Localidad_Departamento]
GO
ALTER TABLE [dbo].[Seccion]  WITH CHECK ADD  CONSTRAINT [FK_Seccion_Gerencia] FOREIGN KEY([id_gerencia])
REFERENCES [dbo].[Gerencia] ([id])
GO
ALTER TABLE [dbo].[Seccion] CHECK CONSTRAINT [FK_Seccion_Gerencia]
GO
ALTER TABLE [dbo].[Solicitud_Beneficiario]  WITH CHECK ADD  CONSTRAINT [FK_Solicitud_Beneficiario_Beneficiario] FOREIGN KEY([id_beneficiario])
REFERENCES [dbo].[Beneficiario] ([id])
GO
ALTER TABLE [dbo].[Solicitud_Beneficiario] CHECK CONSTRAINT [FK_Solicitud_Beneficiario_Beneficiario]
GO
ALTER TABLE [dbo].[Solicitud_Beneficiario]  WITH CHECK ADD  CONSTRAINT [FK_Solicitud_Beneficiario_Factor] FOREIGN KEY([id_factor_sanguineo])
REFERENCES [dbo].[Factor] ([id])
GO
ALTER TABLE [dbo].[Solicitud_Beneficiario] CHECK CONSTRAINT [FK_Solicitud_Beneficiario_Factor]
GO
ALTER TABLE [dbo].[Solicitud_Beneficiario]  WITH CHECK ADD  CONSTRAINT [FK_Solicitud_Beneficiario_Grupo_sanguineo] FOREIGN KEY([id_grupo_sanguineo])
REFERENCES [dbo].[Grupo_sanguineo] ([id])
GO
ALTER TABLE [dbo].[Solicitud_Beneficiario] CHECK CONSTRAINT [FK_Solicitud_Beneficiario_Grupo_sanguineo]
GO
ALTER TABLE [dbo].[Solicitud_Beneficiario]  WITH CHECK ADD  CONSTRAINT [FK_Solicitud_Beneficiario_Tipo_donacion] FOREIGN KEY([id_tipo_donacion])
REFERENCES [dbo].[Tipo_donacion] ([id])
GO
ALTER TABLE [dbo].[Solicitud_Beneficiario] CHECK CONSTRAINT [FK_Solicitud_Beneficiario_Tipo_donacion]
GO
ALTER TABLE [dbo].[Solicitud_Beneficiario]  WITH CHECK ADD  CONSTRAINT [FK_Solicitud_Beneficiario_Unidad_medida] FOREIGN KEY([id_unidad_medida])
REFERENCES [dbo].[Unidad_medida] ([id])
GO
ALTER TABLE [dbo].[Solicitud_Beneficiario] CHECK CONSTRAINT [FK_Solicitud_Beneficiario_Unidad_medida]
GO
ALTER TABLE [dbo].[Telefono_Donante]  WITH CHECK ADD  CONSTRAINT [FK_Telefono_Donante_Tipo_documento] FOREIGN KEY([id_tipo_doc])
REFERENCES [dbo].[Tipo_documento] ([id])
GO
ALTER TABLE [dbo].[Telefono_Donante] CHECK CONSTRAINT [FK_Telefono_Donante_Tipo_documento]
GO
ALTER TABLE [dbo].[Telefono_Donante]  WITH CHECK ADD  CONSTRAINT [FK_Telefono_Donante_Tipo_telefono] FOREIGN KEY([id_tipo_telefono])
REFERENCES [dbo].[Tipo_telefono] ([id])
GO
ALTER TABLE [dbo].[Telefono_Donante] CHECK CONSTRAINT [FK_Telefono_Donante_Tipo_telefono]
GO
USE [master]
GO
ALTER DATABASE [PavTpi] SET  READ_WRITE 
GO
