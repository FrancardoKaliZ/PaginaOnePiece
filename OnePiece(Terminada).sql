USE [master]
GO
/****** Object:  Database [OnePiece]    Script Date: 1/12/2022 10:14:49 ******/
CREATE DATABASE [OnePiece]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OnePiece', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\OnePiece.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OnePiece_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\OnePiece_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [OnePiece] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OnePiece].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OnePiece] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OnePiece] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OnePiece] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OnePiece] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OnePiece] SET ARITHABORT OFF 
GO
ALTER DATABASE [OnePiece] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OnePiece] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OnePiece] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OnePiece] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OnePiece] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OnePiece] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OnePiece] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OnePiece] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OnePiece] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OnePiece] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OnePiece] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OnePiece] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OnePiece] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OnePiece] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OnePiece] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OnePiece] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OnePiece] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OnePiece] SET RECOVERY FULL 
GO
ALTER DATABASE [OnePiece] SET  MULTI_USER 
GO
ALTER DATABASE [OnePiece] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OnePiece] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OnePiece] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OnePiece] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OnePiece] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'OnePiece', N'ON'
GO
ALTER DATABASE [OnePiece] SET QUERY_STORE = OFF
GO
USE [OnePiece]
GO
/****** Object:  User [alumno]    Script Date: 1/12/2022 10:14:49 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Bando]    Script Date: 1/12/2022 10:14:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bando](
	[idBando] [int] IDENTITY(1,1) NOT NULL,
	[NombreBando] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Bando] PRIMARY KEY CLUSTERED 
(
	[idBando] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Foro]    Script Date: 1/12/2022 10:14:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Foro](
	[IdMensaje] [int] IDENTITY(1,1) NOT NULL,
	[TextoMensaje] [varchar](200) NOT NULL,
	[FechaMensaje] [date] NOT NULL,
	[IdUsuario] [int] NOT NULL,
 CONSTRAINT [PK_Foro] PRIMARY KEY CLUSTERED 
(
	[IdMensaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HakiArmadura]    Script Date: 1/12/2022 10:14:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HakiArmadura](
	[IdHakiArmadura] [int] IDENTITY(1,1) NOT NULL,
	[EstadoHA] [varchar](50) NOT NULL,
 CONSTRAINT [PK_HakiArmadura] PRIMARY KEY CLUSTERED 
(
	[IdHakiArmadura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HakiObservacion]    Script Date: 1/12/2022 10:14:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HakiObservacion](
	[IdHakiObservacion] [int] IDENTITY(1,1) NOT NULL,
	[EstadoHO] [varchar](50) NOT NULL,
 CONSTRAINT [PK_HakiObservacion] PRIMARY KEY CLUSTERED 
(
	[IdHakiObservacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HakiRey]    Script Date: 1/12/2022 10:14:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HakiRey](
	[idHakiRey] [int] IDENTITY(1,1) NOT NULL,
	[EstadoHR] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Haki] PRIMARY KEY CLUSTERED 
(
	[idHakiRey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mar]    Script Date: 1/12/2022 10:14:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mar](
	[IdMar] [int] IDENTITY(1,1) NOT NULL,
	[NombreMar] [varchar](50) NOT NULL,
	[InfoMar] [varchar](500) NOT NULL,
	[Foto] [varchar](400) NULL,
 CONSTRAINT [PK_Mar] PRIMARY KEY CLUSTERED 
(
	[IdMar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personaje]    Script Date: 1/12/2022 10:14:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personaje](
	[IdPersonaje] [int] IDENTITY(1,1) NOT NULL,
	[NombrePersonaje] [varchar](50) NOT NULL,
	[InfoPersonaje] [varchar](50) NOT NULL,
	[IdMar] [int] NOT NULL,
	[IdRaza] [int] NOT NULL,
	[Foto] [varchar](200) NULL,
 CONSTRAINT [PK_Personaje] PRIMARY KEY CLUSTERED 
(
	[IdPersonaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonajeXTemporada]    Script Date: 1/12/2022 10:14:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonajeXTemporada](
	[IdPersonaje] [int] NOT NULL,
	[IdTemporada] [int] NOT NULL,
	[IdBando] [int] NOT NULL,
	[IdHakiArmadura] [int] NOT NULL,
	[IdHakiObservacion] [int] NOT NULL,
	[IdHakiRey] [int] NOT NULL,
	[IdTripulacion] [int] NOT NULL,
	[Recompensa] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Raza]    Script Date: 1/12/2022 10:14:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raza](
	[IdRaza] [int] IDENTITY(1,1) NOT NULL,
	[NombreRaza] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Raza] PRIMARY KEY CLUSTERED 
(
	[IdRaza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Temporada]    Script Date: 1/12/2022 10:14:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temporada](
	[IdTemporada] [int] IDENTITY(1,1) NOT NULL,
	[IdMar] [int] NOT NULL,
	[NombreTemporada] [varchar](50) NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NULL,
	[InfoTemporada] [varchar](500) NOT NULL,
	[Capitulos] [int] NOT NULL,
	[Foto] [varchar](200) NULL,
 CONSTRAINT [PK_Temporada] PRIMARY KEY CLUSTERED 
(
	[IdTemporada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tripulacion]    Script Date: 1/12/2022 10:14:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tripulacion](
	[IdTripulacion] [int] IDENTITY(1,1) NOT NULL,
	[NombreTripulacion] [varchar](200) NOT NULL,
	[Foto] [varchar](200) NULL,
 CONSTRAINT [PK_Tripulacion] PRIMARY KEY CLUSTERED 
(
	[IdTripulacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 1/12/2022 10:14:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[InfoUsuario] [varchar](200) NOT NULL,
	[Foto] [varchar](200) NULL,
	[Contraseña] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bando] ON 

INSERT [dbo].[Bando] ([idBando], [NombreBando]) VALUES (1, N'Pirata')
INSERT [dbo].[Bando] ([idBando], [NombreBando]) VALUES (2, N'Marino')
INSERT [dbo].[Bando] ([idBando], [NombreBando]) VALUES (3, N'Caza recompensas')
INSERT [dbo].[Bando] ([idBando], [NombreBando]) VALUES (4, N'Revolucionario')
INSERT [dbo].[Bando] ([idBando], [NombreBando]) VALUES (5, N'Civil')
SET IDENTITY_INSERT [dbo].[Bando] OFF
GO
SET IDENTITY_INSERT [dbo].[HakiArmadura] ON 

INSERT [dbo].[HakiArmadura] ([IdHakiArmadura], [EstadoHA]) VALUES (1, N'No')
INSERT [dbo].[HakiArmadura] ([IdHakiArmadura], [EstadoHA]) VALUES (2, N'Base')
INSERT [dbo].[HakiArmadura] ([IdHakiArmadura], [EstadoHA]) VALUES (3, N'Avanzado')
SET IDENTITY_INSERT [dbo].[HakiArmadura] OFF
GO
SET IDENTITY_INSERT [dbo].[HakiObservacion] ON 

INSERT [dbo].[HakiObservacion] ([IdHakiObservacion], [EstadoHO]) VALUES (1, N'No')
INSERT [dbo].[HakiObservacion] ([IdHakiObservacion], [EstadoHO]) VALUES (2, N'Base')
INSERT [dbo].[HakiObservacion] ([IdHakiObservacion], [EstadoHO]) VALUES (3, N'Avanzado')
SET IDENTITY_INSERT [dbo].[HakiObservacion] OFF
GO
SET IDENTITY_INSERT [dbo].[HakiRey] ON 

INSERT [dbo].[HakiRey] ([idHakiRey], [EstadoHR]) VALUES (1, N'No')
INSERT [dbo].[HakiRey] ([idHakiRey], [EstadoHR]) VALUES (2, N'Base')
INSERT [dbo].[HakiRey] ([idHakiRey], [EstadoHR]) VALUES (3, N'Avanzado')
SET IDENTITY_INSERT [dbo].[HakiRey] OFF
GO
SET IDENTITY_INSERT [dbo].[Mar] ON 

INSERT [dbo].[Mar] ([IdMar], [NombreMar], [InfoMar], [Foto]) VALUES (1, N'All Blue', N'En este océano legendario se dice que hay peces, animales y especias culinarias procedentes de cada uno de los mares, siendo una fuente de recursos alimenticios prácticamente insuperable.Se dice que el All Blue se encuentra en el Grand Line', N'AllBlue.jpg')
INSERT [dbo].[Mar] ([IdMar], [NombreMar], [InfoMar], [Foto]) VALUES (2, N'East Blue', N'Es considerado el océano más débil, ya que los piratas de este océano tiene un promedio de recompensa de Belly3.000.000, sin embargo, el East Blue es el hogar de varios personajes poderosos y temidos en todos los mares:', N'EastBlue.jpg')
INSERT [dbo].[Mar] ([IdMar], [NombreMar], [InfoMar], [Foto]) VALUES (3, N'West Blue', N'Es uno de los mares que forman el Mar Azul, este esta ubicado al oeste, como bien dice su nombre y es aquel que tiene el clima más cálido.', N'WestBlue.jpg')
INSERT [dbo].[Mar] ([IdMar], [NombreMar], [InfoMar], [Foto]) VALUES (4, N'North Blue', N'El North Blue al igual que sus hermanos mares, comprende casi en su totalidad océano, con unas pocas islas dispersas y una frontera con el Red Line. A la fecha, en la historia no se ha dicho mucho sobre el North Blue.', N'NorthBlue.jpg')
INSERT [dbo].[Mar] ([IdMar], [NombreMar], [InfoMar], [Foto]) VALUES (5, N'South Blue', N'El South Blue es conocido por ser el hogar de una isla famosa por sus artes marciales, la Isla del Karate. Esta ubicado al sur del Grand Line, como bien indica su nombre y se caracteriza por el hecho de que la mayoría de sus países o islas poseen un clima calido.', N'SouthBlue.jpg')
INSERT [dbo].[Mar] ([IdMar], [NombreMar], [InfoMar], [Foto]) VALUES (6, N'Grand Line', N'Grand Line es la corriente oceánica que se encuentra rodeada por los Calm Belt y sigue una línea imaginaria que va desde el noroeste hacia el sudeste a través del centro del mundo y es perpendicular al Red Line. El Red Line es un vasto continente que circunda el mundo, desde el noreste al sudoeste.Estas dos líneas dividen al resto de los Blues: North Blue, East Blue, West Blue y South Blue.Este tramo de océano se dice que es el lugar más peligroso del mundo.', N'GrandLine.jpg')
INSERT [dbo].[Mar] ([IdMar], [NombreMar], [InfoMar], [Foto]) VALUES (7, N'Nuevo Mundo', N'Es donde se encuentran la mayoría de los sueños de los Piratas, como la isla Raftel, el Río Ponegliph, supuestamente el All Blue y muchos otros lugares. Es el lugar soñado por recorrer por la nueva generación de piratas, puesto que es donde el próximo Rey de los Piratas se decidirá.', N'NuevoMundo.jpg')
SET IDENTITY_INSERT [dbo].[Mar] OFF
GO
SET IDENTITY_INSERT [dbo].[Personaje] ON 

INSERT [dbo].[Personaje] ([IdPersonaje], [NombrePersonaje], [InfoPersonaje], [IdMar], [IdRaza], [Foto]) VALUES (1, N'Monkey D.Luffy', N'Un kpo', 2, 1, N'Luffy.jpg')
INSERT [dbo].[Personaje] ([IdPersonaje], [NombrePersonaje], [InfoPersonaje], [IdMar], [IdRaza], [Foto]) VALUES (2, N'Roronoa Zoro', N'3 espadas', 2, 1, N'Zoro.jpg')
INSERT [dbo].[Personaje] ([IdPersonaje], [NombrePersonaje], [InfoPersonaje], [IdMar], [IdRaza], [Foto]) VALUES (3, N'Vinsmoke Sanji', N'Te caga a patadas y es fachero', 4, 1, N'Sanji.jpg')
INSERT [dbo].[Personaje] ([IdPersonaje], [NombrePersonaje], [InfoPersonaje], [IdMar], [IdRaza], [Foto]) VALUES (4, N'Usopp', N'El sniper del equipo', 2, 1, N'Usopp.jpg')
INSERT [dbo].[Personaje] ([IdPersonaje], [NombrePersonaje], [InfoPersonaje], [IdMar], [IdRaza], [Foto]) VALUES (5, N'Nami', N'Le gusta la plata', 2, 1, N'Nami.jpg')
INSERT [dbo].[Personaje] ([IdPersonaje], [NombrePersonaje], [InfoPersonaje], [IdMar], [IdRaza], [Foto]) VALUES (6, N'Mery', N'El barco pro', 2, 7, N'Mery.jpg')
INSERT [dbo].[Personaje] ([IdPersonaje], [NombrePersonaje], [InfoPersonaje], [IdMar], [IdRaza], [Foto]) VALUES (7, N'Shanks', N'No existe señor mas kpo que este', 3, 1, N'Shanks.jpg')
SET IDENTITY_INSERT [dbo].[Personaje] OFF
GO
INSERT [dbo].[PersonajeXTemporada] ([IdPersonaje], [IdTemporada], [IdBando], [IdHakiArmadura], [IdHakiObservacion], [IdHakiRey], [IdTripulacion], [Recompensa]) VALUES (1, 1, 1, 1, 1, 1, 2, 30000000)
INSERT [dbo].[PersonajeXTemporada] ([IdPersonaje], [IdTemporada], [IdBando], [IdHakiArmadura], [IdHakiObservacion], [IdHakiRey], [IdTripulacion], [Recompensa]) VALUES (2, 1, 3, 1, 1, 1, 2, 0)
INSERT [dbo].[PersonajeXTemporada] ([IdPersonaje], [IdTemporada], [IdBando], [IdHakiArmadura], [IdHakiObservacion], [IdHakiRey], [IdTripulacion], [Recompensa]) VALUES (3, 1, 1, 1, 1, 1, 2, 0)
INSERT [dbo].[PersonajeXTemporada] ([IdPersonaje], [IdTemporada], [IdBando], [IdHakiArmadura], [IdHakiObservacion], [IdHakiRey], [IdTripulacion], [Recompensa]) VALUES (4, 1, 1, 1, 1, 1, 2, 0)
INSERT [dbo].[PersonajeXTemporada] ([IdPersonaje], [IdTemporada], [IdBando], [IdHakiArmadura], [IdHakiObservacion], [IdHakiRey], [IdTripulacion], [Recompensa]) VALUES (7, 1, 1, 3, 3, 3, 3, 1040000000)
INSERT [dbo].[PersonajeXTemporada] ([IdPersonaje], [IdTemporada], [IdBando], [IdHakiArmadura], [IdHakiObservacion], [IdHakiRey], [IdTripulacion], [Recompensa]) VALUES (5, 1, 1, 1, 1, 1, 2, 0)
INSERT [dbo].[PersonajeXTemporada] ([IdPersonaje], [IdTemporada], [IdBando], [IdHakiArmadura], [IdHakiObservacion], [IdHakiRey], [IdTripulacion], [Recompensa]) VALUES (6, 1, 1, 1, 1, 1, 2, 0)
GO
SET IDENTITY_INSERT [dbo].[Raza] ON 

INSERT [dbo].[Raza] ([IdRaza], [NombreRaza]) VALUES (1, N'Humano')
INSERT [dbo].[Raza] ([IdRaza], [NombreRaza]) VALUES (2, N'Skypeano')
INSERT [dbo].[Raza] ([IdRaza], [NombreRaza]) VALUES (3, N'Gyojin')
INSERT [dbo].[Raza] ([IdRaza], [NombreRaza]) VALUES (4, N'Mink')
INSERT [dbo].[Raza] ([IdRaza], [NombreRaza]) VALUES (5, N'Gigante')
INSERT [dbo].[Raza] ([IdRaza], [NombreRaza]) VALUES (6, N'Oni')
INSERT [dbo].[Raza] ([IdRaza], [NombreRaza]) VALUES (7, N'Otro...')
SET IDENTITY_INSERT [dbo].[Raza] OFF
GO
SET IDENTITY_INSERT [dbo].[Temporada] ON 

INSERT [dbo].[Temporada] ([IdTemporada], [IdMar], [NombreTemporada], [FechaInicio], [FechaFin], [InfoTemporada], [Capitulos], [Foto]) VALUES (1, 2, N'Saga de East Blue', CAST(N'1999-09-20' AS Date), CAST(N'2001-03-07' AS Date), N'La saga del East Blue es la saga introductoria del manga de One Piece, así como la primera de la primer mitad de la serie: El mar de la supervivencia: Saga de los Supernovas, y la primera aventura de los Piratas del Sombrero de Paja. Shanks conoce al pequeño Luffy, el cual vive en el East Blue. Aquí es donde se recluta a la mayoría de su tripulación y, en definitiva, donde comienza la aventura. Esta saga se compone de seis arcos argumentales.', 61, N'SagaEastBlue.jpg')
SET IDENTITY_INSERT [dbo].[Temporada] OFF
GO
SET IDENTITY_INSERT [dbo].[Tripulacion] ON 

INSERT [dbo].[Tripulacion] ([IdTripulacion], [NombreTripulacion], [Foto]) VALUES (1, N'Sin tripulación', NULL)
INSERT [dbo].[Tripulacion] ([IdTripulacion], [NombreTripulacion], [Foto]) VALUES (2, N'Sombreros de Paja', NULL)
INSERT [dbo].[Tripulacion] ([IdTripulacion], [NombreTripulacion], [Foto]) VALUES (3, N'Piratas del pelo rojo', NULL)
SET IDENTITY_INSERT [dbo].[Tripulacion] OFF
GO
ALTER TABLE [dbo].[Foro]  WITH CHECK ADD  CONSTRAINT [FK_Foro_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Foro] CHECK CONSTRAINT [FK_Foro_Usuario]
GO
ALTER TABLE [dbo].[Personaje]  WITH CHECK ADD  CONSTRAINT [FK_Personaje_Mar] FOREIGN KEY([IdMar])
REFERENCES [dbo].[Mar] ([IdMar])
GO
ALTER TABLE [dbo].[Personaje] CHECK CONSTRAINT [FK_Personaje_Mar]
GO
ALTER TABLE [dbo].[Personaje]  WITH CHECK ADD  CONSTRAINT [FK_Personaje_Raza] FOREIGN KEY([IdRaza])
REFERENCES [dbo].[Raza] ([IdRaza])
GO
ALTER TABLE [dbo].[Personaje] CHECK CONSTRAINT [FK_Personaje_Raza]
GO
ALTER TABLE [dbo].[PersonajeXTemporada]  WITH CHECK ADD  CONSTRAINT [FK_PersonajeXTemporada_Bando] FOREIGN KEY([IdBando])
REFERENCES [dbo].[Bando] ([idBando])
GO
ALTER TABLE [dbo].[PersonajeXTemporada] CHECK CONSTRAINT [FK_PersonajeXTemporada_Bando]
GO
ALTER TABLE [dbo].[PersonajeXTemporada]  WITH CHECK ADD  CONSTRAINT [FK_PersonajeXTemporada_HakiArmadura] FOREIGN KEY([IdHakiArmadura])
REFERENCES [dbo].[HakiArmadura] ([IdHakiArmadura])
GO
ALTER TABLE [dbo].[PersonajeXTemporada] CHECK CONSTRAINT [FK_PersonajeXTemporada_HakiArmadura]
GO
ALTER TABLE [dbo].[PersonajeXTemporada]  WITH CHECK ADD  CONSTRAINT [FK_PersonajeXTemporada_HakiObservacion] FOREIGN KEY([IdHakiObservacion])
REFERENCES [dbo].[HakiObservacion] ([IdHakiObservacion])
GO
ALTER TABLE [dbo].[PersonajeXTemporada] CHECK CONSTRAINT [FK_PersonajeXTemporada_HakiObservacion]
GO
ALTER TABLE [dbo].[PersonajeXTemporada]  WITH CHECK ADD  CONSTRAINT [FK_PersonajeXTemporada_HakiRey] FOREIGN KEY([IdHakiRey])
REFERENCES [dbo].[HakiRey] ([idHakiRey])
GO
ALTER TABLE [dbo].[PersonajeXTemporada] CHECK CONSTRAINT [FK_PersonajeXTemporada_HakiRey]
GO
ALTER TABLE [dbo].[PersonajeXTemporada]  WITH CHECK ADD  CONSTRAINT [FK_PersonajeXTemporada_Personaje] FOREIGN KEY([IdPersonaje])
REFERENCES [dbo].[Personaje] ([IdPersonaje])
GO
ALTER TABLE [dbo].[PersonajeXTemporada] CHECK CONSTRAINT [FK_PersonajeXTemporada_Personaje]
GO
ALTER TABLE [dbo].[PersonajeXTemporada]  WITH CHECK ADD  CONSTRAINT [FK_PersonajeXTemporada_Temporada] FOREIGN KEY([IdTemporada])
REFERENCES [dbo].[Temporada] ([IdTemporada])
GO
ALTER TABLE [dbo].[PersonajeXTemporada] CHECK CONSTRAINT [FK_PersonajeXTemporada_Temporada]
GO
ALTER TABLE [dbo].[PersonajeXTemporada]  WITH CHECK ADD  CONSTRAINT [FK_PersonajeXTemporada_Tripulacion] FOREIGN KEY([IdTripulacion])
REFERENCES [dbo].[Tripulacion] ([IdTripulacion])
GO
ALTER TABLE [dbo].[PersonajeXTemporada] CHECK CONSTRAINT [FK_PersonajeXTemporada_Tripulacion]
GO
ALTER TABLE [dbo].[Temporada]  WITH CHECK ADD  CONSTRAINT [FK_Temporada_Mar] FOREIGN KEY([IdMar])
REFERENCES [dbo].[Mar] ([IdMar])
GO
ALTER TABLE [dbo].[Temporada] CHECK CONSTRAINT [FK_Temporada_Mar]
GO
USE [master]
GO
ALTER DATABASE [OnePiece] SET  READ_WRITE 
GO
