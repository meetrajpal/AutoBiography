USE [master]
GO
/****** Object:  Database [AutoBiography]    Script Date: 12-11-2024 08:18:17 ******/
CREATE DATABASE [AutoBiography]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AutoBiography', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AutoBiography.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AutoBiography_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AutoBiography_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [AutoBiography] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AutoBiography].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AutoBiography] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AutoBiography] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AutoBiography] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AutoBiography] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AutoBiography] SET ARITHABORT OFF 
GO
ALTER DATABASE [AutoBiography] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AutoBiography] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AutoBiography] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AutoBiography] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AutoBiography] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AutoBiography] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AutoBiography] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AutoBiography] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AutoBiography] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AutoBiography] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AutoBiography] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AutoBiography] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AutoBiography] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AutoBiography] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AutoBiography] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AutoBiography] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [AutoBiography] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AutoBiography] SET RECOVERY FULL 
GO
ALTER DATABASE [AutoBiography] SET  MULTI_USER 
GO
ALTER DATABASE [AutoBiography] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AutoBiography] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AutoBiography] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AutoBiography] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AutoBiography] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AutoBiography] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AutoBiography', N'ON'
GO
ALTER DATABASE [AutoBiography] SET QUERY_STORE = ON
GO
ALTER DATABASE [AutoBiography] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [AutoBiography]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12-11-2024 08:18:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 12-11-2024 08:18:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12-11-2024 08:18:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](25) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[PicUri] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserSavedPics]    Script Date: 12-11-2024 08:18:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserSavedPics](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[ThumbUri] [nvarchar](max) NOT NULL,
	[FullUri] [nvarchar](max) NOT NULL,
	[Slug] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_UserSavedPics] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241005080745_AddCategoryTableToDatabase', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241005082657_AddEntitiesToCategory', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241009091657_CreatingGalleryTable', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241009093413_AddingDataToGalleryTable', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241009103113_AddedUserProfileTable', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241108054804_AddingUserSavedPicsTableAndRemovingGalleryTable', N'8.0.8')
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'SUV')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'Hatch Back')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (10, N'Coupe')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (12, N'Sedan')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Username], [FullName], [Email], [Password], [PicUri]) VALUES (24, N'meetrajpal', N'Meet Rajpal', N'abc@gmail.com', N'AQAAAAIAAYagAAAAEEdf3z5F+vG7IOLIxeyaxiTdAHCFngqYqienC9GdurmrZAevszlQZMmfzejHHLCqVQ==', N'/images/25 Most Popular Japanese Cartoon Characters.jpg')
INSERT [dbo].[Users] ([Id], [Username], [FullName], [Email], [Password], [PicUri]) VALUES (25, N'Dhruvin.m', N'dhruvin marakna', N'abdc@gmail.com', N'AQAAAAIAAYagAAAAENZmBKu8ai/+QdApdY8XHtiOZiafXchg92bxF+YQzo6jPlHkvFC7spIaUoAg2hb6Gg==', N'/images/80a64e6465b6176794d4e00570751270.jpg')
INSERT [dbo].[Users] ([Id], [Username], [FullName], [Email], [Password], [PicUri]) VALUES (26, N'qwertyasd', N'ASD', N'pv3bpnyzd@mozmail.com', N'AQAAAAIAAYagAAAAEBoc3FuyEerM3A5hM6rTwArFPm0w8y8AhTHE0wCLf1Fwm3qCscndiYHiTV026yCA2Q==', NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[UserSavedPics] ON 

INSERT [dbo].[UserSavedPics] ([Id], [Username], [ThumbUri], [FullUri], [Slug]) VALUES (12, N'meetrajpal', N'https://images.unsplash.com/photo-1414518876340-9c8737380507?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw2fHxjYXJ8ZW58MHx8fHwxNzMwOTcwODEwfDA&ixlib=rb-4.0.3&q=80&w=400', N'https://images.unsplash.com/photo-1414518876340-9c8737380507?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw2fHxjYXJ8ZW58MHx8fHwxNzMwOTcwODEwfDA&ixlib=rb-4.0.3&q=85', N'yellow-and-black-porsche-vehicle-znzlxOfFbWs')
INSERT [dbo].[UserSavedPics] ([Id], [Username], [ThumbUri], [FullUri], [Slug]) VALUES (14, N'meetrajpal', N'https://images.unsplash.com/photo-1517026575980-3e1e2dedeab4?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw4fHxjYXJ8ZW58MHx8fHwxNzMwOTcwODEwfDA&ixlib=rb-4.0.3&q=80&w=400', N'https://images.unsplash.com/photo-1517026575980-3e1e2dedeab4?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw4fHxjYXJ8ZW58MHx8fHwxNzMwOTcwODEwfDA&ixlib=rb-4.0.3&q=85', N'white-and-blue-analog-tachometer-gauge-HUJDz6CJEaM')
INSERT [dbo].[UserSavedPics] ([Id], [Username], [ThumbUri], [FullUri], [Slug]) VALUES (17, N'meetrajpal', N'https://images.unsplash.com/photo-1508974239320-0a029497e820?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMXx8Y2FyfGVufDB8fHx8MTczMDk3MDgxMHww&ixlib=rb-4.0.3&q=80&w=400', N'https://images.unsplash.com/photo-1508974239320-0a029497e820?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMXx8Y2FyfGVufDB8fHx8MTczMDk3MDgxMHww&ixlib=rb-4.0.3&q=85', N'red-sports-car-tmAynVA_ihE')
INSERT [dbo].[UserSavedPics] ([Id], [Username], [ThumbUri], [FullUri], [Slug]) VALUES (18, N'meetrajpal', N'https://images.unsplash.com/photo-1469285994282-454ceb49e63c?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMnx8Y2FyfGVufDB8fHx8MTczMDk3MDgxMHww&ixlib=rb-4.0.3&q=80&w=400', N'https://images.unsplash.com/photo-1469285994282-454ceb49e63c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMnx8Y2FyfGVufDB8fHx8MTczMDk3MDgxMHww&ixlib=rb-4.0.3&q=85', N'white-aston-martin-convertible-parked-near-trees-Os7C4iw2rDc')
INSERT [dbo].[UserSavedPics] ([Id], [Username], [ThumbUri], [FullUri], [Slug]) VALUES (22, N'meetrajpal', N'https://images.unsplash.com/photo-1486326658981-ed68abe5868e?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxM3x8Y2FyfGVufDB8fHx8MTczMTA4NTg2N3ww&ixlib=rb-4.0.3&q=80&w=400', N'https://images.unsplash.com/photo-1486326658981-ed68abe5868e?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxM3x8Y2FyfGVufDB8fHx8MTczMTA4NTg2N3ww&ixlib=rb-4.0.3&q=85', N'green-off-road-vehicle-on-snow-during-winter-season-0hJL8lBl0qQ')
INSERT [dbo].[UserSavedPics] ([Id], [Username], [ThumbUri], [FullUri], [Slug]) VALUES (27, N'qwertyasd', N'https://images.unsplash.com/photo-1530906358829-e84b2769270f?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzfHxsYW1ib3JnaGluaXxlbnwwfHx8fDE3MzExMzQ1NDF8MA&ixlib=rb-4.0.3&q=80&w=400', N'https://images.unsplash.com/photo-1530906358829-e84b2769270f?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzfHxsYW1ib3JnaGluaXxlbnwwfHx8fDE3MzExMzQ1NDF8MA&ixlib=rb-4.0.3&q=85', N'sports-car-in-front-of-stadium-PlhpEa-WG6E')
INSERT [dbo].[UserSavedPics] ([Id], [Username], [ThumbUri], [FullUri], [Slug]) VALUES (28, N'qwertyasd', N'https://images.unsplash.com/photo-1511919884226-fd3cad34687c?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMHx8bGFtYm9yZ2hpbml8ZW58MHx8fHwxNzMxMTM0NTQxfDA&ixlib=rb-4.0.3&q=80&w=400', N'https://images.unsplash.com/photo-1511919884226-fd3cad34687c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMHx8bGFtYm9yZ2hpbml8ZW58MHx8fHwxNzMxMTM0NTQxfDA&ixlib=rb-4.0.3&q=85', N'yellow-sports-car-X16zXcbxU4U')
INSERT [dbo].[UserSavedPics] ([Id], [Username], [ThumbUri], [FullUri], [Slug]) VALUES (30, N'qwertyasd', N'https://images.unsplash.com/photo-1515569067071-ec3b51335dd0?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxfHxjYXJ8ZW58MHx8fHwxNzMxMTI2NDIwfDA&ixlib=rb-4.0.3&q=80&w=400', N'https://images.unsplash.com/photo-1515569067071-ec3b51335dd0?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxfHxjYXJ8ZW58MHx8fHwxNzMxMTI2NDIwfDA&ixlib=rb-4.0.3&q=85', N'car-headlight-AO3VsQ_sGK8')
INSERT [dbo].[UserSavedPics] ([Id], [Username], [ThumbUri], [FullUri], [Slug]) VALUES (31, N'qwertyasd', N'https://images.unsplash.com/photo-1469285994282-454ceb49e63c?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMnx8Y2FyfGVufDB8fHx8MTczMTEyNjQyMHww&ixlib=rb-4.0.3&q=80&w=400', N'https://images.unsplash.com/photo-1469285994282-454ceb49e63c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMnx8Y2FyfGVufDB8fHx8MTczMTEyNjQyMHww&ixlib=rb-4.0.3&q=85', N'white-aston-martin-convertible-parked-near-trees-Os7C4iw2rDc')
INSERT [dbo].[UserSavedPics] ([Id], [Username], [ThumbUri], [FullUri], [Slug]) VALUES (33, N'meetrajpal', N'https://images.unsplash.com/photo-1577076956766-5345e1183d33?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw2Mnx8dmludGFnZSUyMGNhcnxlbnwwfHx8fDE3MzEzNzc4NzZ8MA&ixlib=rb-4.0.3&q=80&w=400', N'https://images.unsplash.com/photo-1577076956766-5345e1183d33?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw2Mnx8dmludGFnZSUyMGNhcnxlbnwwfHx8fDE3MzEzNzc4NzZ8MA&ixlib=rb-4.0.3&q=85', N'brown-vehicle-parking-on-pavement-xx9qC2Ngds0')
INSERT [dbo].[UserSavedPics] ([Id], [Username], [ThumbUri], [FullUri], [Slug]) VALUES (35, N'meetrajpal', N'https://images.unsplash.com/photo-1494697536454-6f39e2cc972d?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzN3x8Y2FyfGVufDB8fHx8MTczMTM3NzkzNHww&ixlib=rb-4.0.3&q=80&w=400', N'https://images.unsplash.com/photo-1494697536454-6f39e2cc972d?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzN3x8Y2FyfGVufDB8fHx8MTczMTM3NzkzNHww&ixlib=rb-4.0.3&q=85', N'red-car-near-trees-vw0AmpZvHZg')
SET IDENTITY_INSERT [dbo].[UserSavedPics] OFF
GO
USE [master]
GO
ALTER DATABASE [AutoBiography] SET  READ_WRITE 
GO
