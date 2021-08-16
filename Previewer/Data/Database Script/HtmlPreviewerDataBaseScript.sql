USE [master]
GO

/****** Object:  Database [HtmlPreviewer]    Script Date: 16/08/2021 17:34:25 ******/
CREATE DATABASE [HtmlPreviewer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HtmlPreviewer', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HtmlPreviewer.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HtmlPreviewer_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HtmlPreviewer_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HtmlPreviewer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [HtmlPreviewer] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET ARITHABORT OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [HtmlPreviewer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [HtmlPreviewer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET  ENABLE_BROKER 
GO

ALTER DATABASE [HtmlPreviewer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [HtmlPreviewer] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET RECOVERY FULL 
GO

ALTER DATABASE [HtmlPreviewer] SET  MULTI_USER 
GO

ALTER DATABASE [HtmlPreviewer] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [HtmlPreviewer] SET DB_CHAINING OFF 
GO

ALTER DATABASE [HtmlPreviewer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [HtmlPreviewer] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [HtmlPreviewer] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [HtmlPreviewer] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [HtmlPreviewer] SET QUERY_STORE = OFF
GO

ALTER DATABASE [HtmlPreviewer] SET  READ_WRITE 
GO

