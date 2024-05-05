USE [master]
GO
/****** Object:  Database [dbSistemaEmpreados]    Script Date: 05/05/2024 02:18:59 p. m. ******/
CREATE DATABASE [dbSistemaEmpreados]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbSistemaEmpreados', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dbSistemaEmpreados.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbSistemaEmpreados_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dbSistemaEmpreados_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [dbSistemaEmpreados] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbSistemaEmpreados].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbSistemaEmpreados] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbSistemaEmpreados] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbSistemaEmpreados] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbSistemaEmpreados] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbSistemaEmpreados] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET RECOVERY FULL 
GO
ALTER DATABASE [dbSistemaEmpreados] SET  MULTI_USER 
GO
ALTER DATABASE [dbSistemaEmpreados] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbSistemaEmpreados] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbSistemaEmpreados] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbSistemaEmpreados] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbSistemaEmpreados] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbSistemaEmpreados] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbSistemaEmpreados', N'ON'
GO
ALTER DATABASE [dbSistemaEmpreados] SET QUERY_STORE = ON
GO
ALTER DATABASE [dbSistemaEmpreados] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [dbSistemaEmpreados]
GO
/****** Object:  Table [dbo].[departamento]    Script Date: 05/05/2024 02:18:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[departamento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[departamentos] [varchar](50) NULL,
 CONSTRAINT [PK_departamento] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpleadoDepartamento]    Script Date: 05/05/2024 02:18:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpleadoDepartamento](
	[idDepartamento] [int] NULL,
	[idEmpleado] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 05/05/2024 02:18:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](50) NULL,
	[primerApellido] [varchar](50) NULL,
	[segundoApellido] [varchar](50) NULL,
	[correo] [varchar](50) NULL,
	[foto] [image] NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[departamento] ON 

INSERT [dbo].[departamento] ([id], [departamentos]) VALUES (1, N':P')
SET IDENTITY_INSERT [dbo].[departamento] OFF
GO
ALTER TABLE [dbo].[EmpleadoDepartamento]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoDepartamento_departamento] FOREIGN KEY([idDepartamento])
REFERENCES [dbo].[departamento] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmpleadoDepartamento] CHECK CONSTRAINT [FK_EmpleadoDepartamento_departamento]
GO
ALTER TABLE [dbo].[EmpleadoDepartamento]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoDepartamento_Empleados] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleados] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmpleadoDepartamento] CHECK CONSTRAINT [FK_EmpleadoDepartamento_Empleados]
GO
USE [master]
GO
ALTER DATABASE [dbSistemaEmpreados] SET  READ_WRITE 
GO
