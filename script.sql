USE [master]
GO
/****** Object:  Database [Slack]    Script Date: 9/16/2020 1:13:13 PM ******/
CREATE DATABASE [Slack]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Slack', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Slack.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Slack_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Slack_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Slack] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Slack].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Slack] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Slack] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Slack] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Slack] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Slack] SET ARITHABORT OFF 
GO
ALTER DATABASE [Slack] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Slack] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Slack] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Slack] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Slack] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Slack] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Slack] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Slack] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Slack] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Slack] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Slack] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Slack] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Slack] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Slack] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Slack] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Slack] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Slack] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Slack] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Slack] SET  MULTI_USER 
GO
ALTER DATABASE [Slack] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Slack] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Slack] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Slack] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Slack] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Slack] SET QUERY_STORE = OFF
GO
USE [Slack]
GO
/****** Object:  Table [dbo].[Answers]    Script Date: 9/16/2020 1:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Detail] [nvarchar](50) NULL,
	[QuestionID] [int] NOT NULL,
	[Posted] [datetime] NULL,
	[Upvotes] [int] NULL,
 CONSTRAINT [PK_Answers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 9/16/2020 1:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Title] [nvarchar](30) NULL,
	[Detail] [nvarchar](50) NULL,
	[Posted] [datetime] NULL,
	[Category] [nvarchar](20) NULL,
	[Tags] [nvarchar](50) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Answers] ON 

INSERT [dbo].[Answers] ([ID], [Username], [Detail], [QuestionID], [Posted], [Upvotes]) VALUES (6, N'Tyler', N'Details', 2, CAST(N'2020-09-15T12:00:00.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Answers] OFF
GO
SET IDENTITY_INSERT [dbo].[Questions] ON 

INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (2, N'Tyler', N'This Title', N'DETAILS', CAST(N'2020-09-15T12:00:00.000' AS DateTime), N'Fun Stuff', N'c#', 1)
INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (3, N'Username1', N'Grow my knowledge in SQL (OKR)', NULL, CAST(N'2020-09-15T16:47:58.083' AS DateTime), N'Coding Help', N'c#', 1)
INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (4, N'Username1', N'Grow my knowledge in SQL (OKR)', NULL, CAST(N'2020-09-15T16:51:14.577' AS DateTime), N'Coding Help', N'c#', 1)
INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (5, N'Username1', N'Grow my knowledge in SQL (OKR)', NULL, CAST(N'2020-09-15T16:52:58.150' AS DateTime), N'Coding Help', N'c#', 1)
INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (6, N'Username1', N'Grow my knowledge in SQL (OKR)', NULL, CAST(N'2020-09-15T16:54:37.177' AS DateTime), N'Errors', N'sql', 1)
INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (7, N'Username1', N'Grow my knowledge in SQL (OKR)', N' IS FILLED', CAST(N'2020-09-15T16:57:38.937' AS DateTime), N'Fun Stuff', N'fun', 1)
INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (8, N'Username1', N'New titles', N' dqdqwdas', CAST(N'2020-09-15T17:00:18.487' AS DateTime), N'Discussion', N'sql', 1)
INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (9, N'Username1', N'YOOOOO', N' aaa', CAST(N'2020-09-15T18:00:23.247' AS DateTime), N'Help', N'fun', 1)
INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (10, N'Username1', N'New titles', N' aaa', CAST(N'2020-09-15T17:03:06.483' AS DateTime), N'Coding Help', N'c#', 1)
INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (11, N'Username1', N'Grow my knowledge in SQL (OKR)', N' 111', CAST(N'2020-09-15T17:03:28.440' AS DateTime), N'Discussion', N'sql', 1)
INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (12, N'Username1', N'New titles', N' aaa', CAST(N'2020-09-15T17:04:27.270' AS DateTime), N'Errors', N'help', 1)
INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (13, N'Username1', N'New titles', N' faf', CAST(N'2020-09-15T17:32:17.667' AS DateTime), N'Errors', N'New tag', 1)
INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (14, N'Username1', N'New titles', N' aa', CAST(N'2020-09-15T17:33:10.433' AS DateTime), N'Errors', N'sql', 1)
INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (15, N'Username1', N'New titles', N' aaaa', CAST(N'2020-09-15T17:35:57.363' AS DateTime), N'Errors', N'sql', 1)
INSERT [dbo].[Questions] ([ID], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (16, N'Tyler', N'That Title', N'DETAILS', CAST(N'2020-09-15T17:51:23.120' AS DateTime), N'Help', N'c#', 1)
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
ALTER TABLE [dbo].[Answers]  WITH CHECK ADD  CONSTRAINT [FK__Answers__Questio__25869641] FOREIGN KEY([QuestionID])
REFERENCES [dbo].[Questions] ([ID])
GO
ALTER TABLE [dbo].[Answers] CHECK CONSTRAINT [FK__Answers__Questio__25869641]
GO
USE [master]
GO
ALTER DATABASE [Slack] SET  READ_WRITE 
GO
