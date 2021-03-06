USE [master]
GO
/****** Object:  Database [YouTubeClips]    Script Date: 05/05/2016 00:07:23 ******/
CREATE DATABASE [YouTubeClips]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YouTubeClips', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\YouTubeClips.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'YouTubeClips_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\YouTubeClips_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [YouTubeClips] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YouTubeClips].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YouTubeClips] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YouTubeClips] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YouTubeClips] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YouTubeClips] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YouTubeClips] SET ARITHABORT OFF 
GO
ALTER DATABASE [YouTubeClips] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YouTubeClips] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YouTubeClips] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YouTubeClips] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YouTubeClips] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YouTubeClips] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YouTubeClips] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YouTubeClips] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YouTubeClips] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YouTubeClips] SET  DISABLE_BROKER 
GO
ALTER DATABASE [YouTubeClips] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YouTubeClips] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YouTubeClips] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YouTubeClips] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YouTubeClips] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YouTubeClips] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [YouTubeClips] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YouTubeClips] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [YouTubeClips] SET  MULTI_USER 
GO
ALTER DATABASE [YouTubeClips] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YouTubeClips] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YouTubeClips] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YouTubeClips] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [YouTubeClips] SET DELAYED_DURABILITY = DISABLED 
GO
USE [YouTubeClips]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 05/05/2016 00:07:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Movies]    Script Date: 05/05/2016 00:07:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[MovieName] [nvarchar](max) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Duration] [time](7) NOT NULL,
	[MovieLink] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Action')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Horor')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Music')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'Family')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (5, N'Fails')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (6, N'Sport')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (7, N'Pranks')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (8, N'Comedy')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieID], [MovieName], [CategoryName], [CategoryID], [Duration], [MovieLink]) VALUES (2, N'Metallica - nothing else matters', N'Music', 3, CAST(N'00:06:25' AS Time), N'https://www.youtube.com/embed/Tj75Arhq5ho')
INSERT [dbo].[Movies] ([MovieID], [MovieName], [CategoryName], [CategoryID], [Duration], [MovieLink]) VALUES (4, N'girl fails compilation 2016', N'Fails', 5, CAST(N'00:09:06' AS Time), N'https://www.youtube.com/embed/Uif1WdmPatc')
INSERT [dbo].[Movies] ([MovieID], [MovieName], [CategoryName], [CategoryID], [Duration], [MovieLink]) VALUES (5, N'Seinfeld Bloopers Season 5', N'Comedy', 8, CAST(N'00:13:15' AS Time), N'https://www.youtube.com/embed/fwvdmTZlAwQ')
INSERT [dbo].[Movies] ([MovieID], [MovieName], [CategoryName], [CategoryID], [Duration], [MovieLink]) VALUES (6, N'Top 10 NBA Dunkers of All Time', N'Sport', 6, CAST(N'00:08:06' AS Time), N'https://www.youtube.com/embed/aEAvN5rBc6g')
INSERT [dbo].[Movies] ([MovieID], [MovieName], [CategoryName], [CategoryID], [Duration], [MovieLink]) VALUES (7, N'Scary Pranks Compilation "Top 5 Scare Pranks" 2015', N'Pranks', 7, CAST(N'00:16:05' AS Time), N'https://www.youtube.com/embed/-AsR0GIHecc')
SET IDENTITY_INSERT [dbo].[Movies] OFF
ALTER TABLE [dbo].[Movies]  WITH CHECK ADD  CONSTRAINT [FK_Movies_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Movies] CHECK CONSTRAINT [FK_Movies_Categories]
GO
USE [master]
GO
ALTER DATABASE [YouTubeClips] SET  READ_WRITE 
GO
