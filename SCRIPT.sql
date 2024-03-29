/*USE [master]
GO*/
/****** Object:  Database [EscuelaPrueba]    Script Date: 20/11/2019 05:56:50 p. m. ******/
CREATE DATABASE [EscuelaPrueba]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EscuelaPrueba', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EscuelaPrueba.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EscuelaPrueba_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EscuelaPrueba_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EscuelaPrueba] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EscuelaPrueba].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EscuelaPrueba] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET ARITHABORT OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [EscuelaPrueba] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EscuelaPrueba] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EscuelaPrueba] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EscuelaPrueba] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EscuelaPrueba] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EscuelaPrueba] SET  MULTI_USER 
GO
ALTER DATABASE [EscuelaPrueba] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EscuelaPrueba] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EscuelaPrueba] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EscuelaPrueba] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EscuelaPrueba] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EscuelaPrueba] SET QUERY_STORE = OFF
GO
USE [EscuelaPrueba]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 20/11/2019 05:56:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NULL,
	[ApellidoPaterno] [varchar](30) NULL,
	[ApellidoMaterno] [varchar](30) NULL,
	[Email] [varchar](70) NULL,
	[CarreraId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alumno_Materia]    Script Date: 20/11/2019 05:56:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno_Materia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlumnoId] [int] NULL,
	[MateriaId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carrera]    Script Date: 20/11/2019 05:56:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carrera](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 20/11/2019 05:56:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[nombreMateria] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD FOREIGN KEY([CarreraId])
REFERENCES [dbo].[Carrera] ([Id])
GO
ALTER TABLE [dbo].[Alumno_Materia]  WITH CHECK ADD FOREIGN KEY([AlumnoId])
REFERENCES [dbo].[Alumno] ([Id])
GO
ALTER TABLE [dbo].[Alumno_Materia]  WITH CHECK ADD FOREIGN KEY([MateriaId])
REFERENCES [dbo].[Materia] ([Id])
GO
USE [master]
GO
ALTER DATABASE [EscuelaPrueba] SET  READ_WRITE 
GO
