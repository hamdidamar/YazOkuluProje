USE [master]
GO
/****** Object:  Database [DboYazOkulu]    Script Date: 6.09.2019 00:10:29 ******/
CREATE DATABASE [DboYazOkulu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DboYazOkulu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL_2014\MSSQL\DATA\DboYazOkulu.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DboYazOkulu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL_2014\MSSQL\DATA\DboYazOkulu_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DboYazOkulu] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DboYazOkulu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DboYazOkulu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DboYazOkulu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DboYazOkulu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DboYazOkulu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DboYazOkulu] SET ARITHABORT OFF 
GO
ALTER DATABASE [DboYazOkulu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DboYazOkulu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DboYazOkulu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DboYazOkulu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DboYazOkulu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DboYazOkulu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DboYazOkulu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DboYazOkulu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DboYazOkulu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DboYazOkulu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DboYazOkulu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DboYazOkulu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DboYazOkulu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DboYazOkulu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DboYazOkulu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DboYazOkulu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DboYazOkulu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DboYazOkulu] SET RECOVERY FULL 
GO
ALTER DATABASE [DboYazOkulu] SET  MULTI_USER 
GO
ALTER DATABASE [DboYazOkulu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DboYazOkulu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DboYazOkulu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DboYazOkulu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DboYazOkulu] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DboYazOkulu]
GO
/****** Object:  Table [dbo].[TBL_BASVURULAR]    Script Date: 6.09.2019 00:10:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_BASVURULAR](
	[BasvuruID] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciID] [int] NULL,
	[DersID] [int] NULL,
 CONSTRAINT [PK_TBL_BASVURULAR] PRIMARY KEY CLUSTERED 
(
	[BasvuruID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TBL_DERSLER]    Script Date: 6.09.2019 00:10:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_DERSLER](
	[DersID] [int] IDENTITY(1,1) NOT NULL,
	[DersAd] [varchar](50) NULL,
	[DersMinKontenjan] [tinyint] NULL,
	[DersMaxKontenjan] [tinyint] NULL,
 CONSTRAINT [PK_TBL_DERSLER] PRIMARY KEY CLUSTERED 
(
	[DersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_OGRENCILER]    Script Date: 6.09.2019 00:10:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_OGRENCILER](
	[OgrenciID] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciAd] [varchar](50) NULL,
	[OgrenciSoyad] [varchar](50) NULL,
	[OgrenciNumara] [varchar](10) NULL,
	[OgrenciMail] [varchar](50) NULL,
	[OgrenciSifre] [varchar](10) NULL,
	[OgrenciFotograf] [varchar](100) NULL,
	[OgrenciBakiye] [decimal](18, 2) NULL CONSTRAINT [DF_TBL_OGRENCİLER_OgrenciBakiye]  DEFAULT ((0)),
 CONSTRAINT [PK_TBL_OGRENCİLER] PRIMARY KEY CLUSTERED 
(
	[OgrenciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_OGRETMENLER]    Script Date: 6.09.2019 00:10:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_OGRETMENLER](
	[OgretmenID] [int] IDENTITY(1,1) NOT NULL,
	[OgretmenAdSoyad] [varchar](50) NULL,
	[OgretmenBrans] [int] NULL,
 CONSTRAINT [PK_TBL_OGRETMENLER] PRIMARY KEY CLUSTERED 
(
	[OgretmenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[TBL_BASVURULAR]  WITH CHECK ADD  CONSTRAINT [FK_TBL_BASVURULAR_TBL_DERSLER] FOREIGN KEY([DersID])
REFERENCES [dbo].[TBL_DERSLER] ([DersID])
GO
ALTER TABLE [dbo].[TBL_BASVURULAR] CHECK CONSTRAINT [FK_TBL_BASVURULAR_TBL_DERSLER]
GO
ALTER TABLE [dbo].[TBL_BASVURULAR]  WITH CHECK ADD  CONSTRAINT [FK_TBL_BASVURULAR_TBL_OGRENCİLER] FOREIGN KEY([OgrenciID])
REFERENCES [dbo].[TBL_OGRENCILER] ([OgrenciID])
GO
ALTER TABLE [dbo].[TBL_BASVURULAR] CHECK CONSTRAINT [FK_TBL_BASVURULAR_TBL_OGRENCİLER]
GO
ALTER TABLE [dbo].[TBL_OGRETMENLER]  WITH CHECK ADD  CONSTRAINT [FK_TBL_OGRETMENLER_TBL_DERSLER] FOREIGN KEY([OgretmenBrans])
REFERENCES [dbo].[TBL_DERSLER] ([DersID])
GO
ALTER TABLE [dbo].[TBL_OGRETMENLER] CHECK CONSTRAINT [FK_TBL_OGRETMENLER_TBL_DERSLER]
GO
/****** Object:  StoredProcedure [dbo].[OgrenciEkle]    Script Date: 6.09.2019 00:10:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OgrenciEkle]
@p1 varchar(50),
@p2 varchar(50),
@p3 varchar(50),
@p4 varchar(50),
@p5 varchar(50),
@p6 varchar(50),
@p7 decimal(18,2)

AS
BEGIN
INSERT INTO DBOYazOkulu.dbo.TBL_OGRENCILER
(
	OgrenciAd,
	OgrenciSoyad,
	OgrenciNumara,
	OgrenciMail,
	OgrenciSifre,
	OgrenciFotograf,
	OgrenciBakiye
)
VALUES
(
	@p1,
	@p2,
	@p3,
	@p4,
	@p5,
	@p6,
	@p7
)
END


GO
USE [master]
GO
ALTER DATABASE [DboYazOkulu] SET  READ_WRITE 
GO
