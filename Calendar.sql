USE [master]
GO
/****** Object:  Database [Calendar]    Script Date: 2018-04-24 19:39:01 ******/
CREATE DATABASE [Calendar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'calendar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\calendar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'calendar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\calendar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Calendar] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Calendar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Calendar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Calendar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Calendar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Calendar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Calendar] SET ARITHABORT OFF 
GO
ALTER DATABASE [Calendar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Calendar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Calendar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Calendar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Calendar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Calendar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Calendar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Calendar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Calendar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Calendar] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Calendar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Calendar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Calendar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Calendar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Calendar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Calendar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Calendar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Calendar] SET RECOVERY FULL 
GO
ALTER DATABASE [Calendar] SET  MULTI_USER 
GO
ALTER DATABASE [Calendar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Calendar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Calendar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Calendar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Calendar] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Calendar', N'ON'
GO
ALTER DATABASE [Calendar] SET QUERY_STORE = OFF
GO
USE [Calendar]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Calendar]
GO
/****** Object:  Table [dbo].[Calendar]    Script Date: 2018-04-24 19:39:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calendar](
	[Day] [tinyint] NOT NULL,
	[Month] [nvarchar](20) NOT NULL,
	[Name] [nvarchar](31) NOT NULL,
 CONSTRAINT [PK_Calendar] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Day]    Script Date: 2018-04-24 19:39:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Day](
	[Day] [tinyint] NULL,
	[Month] [nvarchar](10) NULL,
	[Name] [nvarchar](31) NOT NULL,
	[StartTime] [time](7) NULL,
	[StopTime] [time](7) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departures]    Script Date: 2018-04-24 19:39:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departures](
	[Name] [nvarchar](31) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FreeTime]    Script Date: 2018-04-24 19:39:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FreeTime](
	[Name] [nvarchar](31) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HomeStuff]    Script Date: 2018-04-24 19:39:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HomeStuff](
	[Name] [nvarchar](31) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Learning]    Script Date: 2018-04-24 19:39:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Learning](
	[Name] [nvarchar](31) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Calendar] ([Day], [Month], [Name]) VALUES (24, N'kwiecień', N'Alek wpadnie')
INSERT [dbo].[Calendar] ([Day], [Month], [Name]) VALUES (15, N'maj', N'Kartkówka z miernictwa')
INSERT [dbo].[Calendar] ([Day], [Month], [Name]) VALUES (12, N'maj', N'Kolos z sys. operacyjnych')
INSERT [dbo].[Calendar] ([Day], [Month], [Name]) VALUES (25, N'kwiecień', N'Odwiedzic babcie')
INSERT [dbo].[Calendar] ([Day], [Month], [Name]) VALUES (6, N'maj', N'Pobiegać')
INSERT [dbo].[Calendar] ([Day], [Month], [Name]) VALUES (2, N'maj', N'Pojeżdzić na rowerze')
INSERT [dbo].[Calendar] ([Day], [Month], [Name]) VALUES (4, N'maj', N'Pomyć podłogi')
INSERT [dbo].[Calendar] ([Day], [Month], [Name]) VALUES (25, N'kwiecień', N'Posprzatać w pokoju')
INSERT [dbo].[Calendar] ([Day], [Month], [Name]) VALUES (6, N'maj', N'Pójść na koncert skov')
INSERT [dbo].[Calendar] ([Day], [Month], [Name]) VALUES (1, N'maj', N'Wyjechać na majówke')
INSERT [dbo].[Day] ([Day], [Month], [Name], [StartTime], [StopTime]) VALUES (24, N'kwiecień', N'Alek wpadnie', CAST(N'16:00:00' AS Time), NULL)
INSERT [dbo].[Day] ([Day], [Month], [Name], [StartTime], [StopTime]) VALUES (1, N'maj', N'Wyjechać na majówke', NULL, NULL)
INSERT [dbo].[Day] ([Day], [Month], [Name], [StartTime], [StopTime]) VALUES (25, N'kwiecień', N'Posprzatać w pokoju ', CAST(N'14:25:00' AS Time), NULL)
INSERT [dbo].[Day] ([Day], [Month], [Name], [StartTime], [StopTime]) VALUES (25, N'kwiecień', N'Odwiedzic babcie', CAST(N'18:00:00' AS Time), NULL)
INSERT [dbo].[Day] ([Day], [Month], [Name], [StartTime], [StopTime]) VALUES (6, N'maj', N'Pójść na koncert skov', CAST(N'20:00:00' AS Time), CAST(N'01:00:00' AS Time))
INSERT [dbo].[Day] ([Day], [Month], [Name], [StartTime], [StopTime]) VALUES (6, N'maj', N'Pobiegać', CAST(N'18:30:00' AS Time), CAST(N'19:30:00' AS Time))
INSERT [dbo].[Day] ([Day], [Month], [Name], [StartTime], [StopTime]) VALUES (4, N'maj', N'Pomyć podłogi', CAST(N'12:20:00' AS Time), NULL)
INSERT [dbo].[Day] ([Day], [Month], [Name], [StartTime], [StopTime]) VALUES (12, N'maj', N'Kolos z sys. operacyjnych', CAST(N'11:15:00' AS Time), NULL)
INSERT [dbo].[Day] ([Day], [Month], [Name], [StartTime], [StopTime]) VALUES (15, N'maj', N'Kartkówka z miernictwa', CAST(N'13:15:00' AS Time), NULL)
INSERT [dbo].[Day] ([Day], [Month], [Name], [StartTime], [StopTime]) VALUES (2, N'maj', N'Pojeździć na rowerze', CAST(N'17:20:00' AS Time), CAST(N'18:30:00' AS Time))
INSERT [dbo].[Departures] ([Name]) VALUES (N'Alek wpadnie')
INSERT [dbo].[Departures] ([Name]) VALUES (N'Wyjechać na majówke')
INSERT [dbo].[Departures] ([Name]) VALUES (N'Odwiedzic babcie')
INSERT [dbo].[FreeTime] ([Name]) VALUES (N'Pójść na koncert skov')
INSERT [dbo].[FreeTime] ([Name]) VALUES (N'Pojeżdzić na rowerze')
INSERT [dbo].[FreeTime] ([Name]) VALUES (N'Pobiegać')
INSERT [dbo].[HomeStuff] ([Name]) VALUES (N'Posprzatać w pokoju')
INSERT [dbo].[HomeStuff] ([Name]) VALUES (N'Pomyć podłogi')
INSERT [dbo].[Learning] ([Name]) VALUES (N'Kolos z sys. operacyjnych')
INSERT [dbo].[Learning] ([Name]) VALUES (N'Kartkówka z miernictwa')
ALTER TABLE [dbo].[Departures]  WITH CHECK ADD  CONSTRAINT [FK_Departures_Calendar] FOREIGN KEY([Name])
REFERENCES [dbo].[Calendar] ([Name])
GO
ALTER TABLE [dbo].[Departures] CHECK CONSTRAINT [FK_Departures_Calendar]
GO
ALTER TABLE [dbo].[FreeTime]  WITH CHECK ADD  CONSTRAINT [FK_FreeTime_Calendar] FOREIGN KEY([Name])
REFERENCES [dbo].[Calendar] ([Name])
GO
ALTER TABLE [dbo].[FreeTime] CHECK CONSTRAINT [FK_FreeTime_Calendar]
GO
ALTER TABLE [dbo].[HomeStuff]  WITH CHECK ADD  CONSTRAINT [FK_HomeStuff_Calendar] FOREIGN KEY([Name])
REFERENCES [dbo].[Calendar] ([Name])
GO
ALTER TABLE [dbo].[HomeStuff] CHECK CONSTRAINT [FK_HomeStuff_Calendar]
GO
ALTER TABLE [dbo].[Learning]  WITH CHECK ADD  CONSTRAINT [FK_Learning_Calendar] FOREIGN KEY([Name])
REFERENCES [dbo].[Calendar] ([Name])
GO
ALTER TABLE [dbo].[Learning] CHECK CONSTRAINT [FK_Learning_Calendar]
GO
USE [master]
GO
ALTER DATABASE [Calendar] SET  READ_WRITE 
GO
