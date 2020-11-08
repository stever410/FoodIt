USE [master]
GO
/****** Object:  Database [FoodIt]    Script Date: 08/11/2020 9:35:08 PM ******/
CREATE DATABASE [FoodIt]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FoodIt', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\FoodIt.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FoodIt_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\FoodIt_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FoodIt] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FoodIt].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FoodIt] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FoodIt] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FoodIt] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FoodIt] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FoodIt] SET ARITHABORT OFF 
GO
ALTER DATABASE [FoodIt] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FoodIt] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FoodIt] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FoodIt] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FoodIt] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FoodIt] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FoodIt] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FoodIt] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FoodIt] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FoodIt] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FoodIt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FoodIt] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FoodIt] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FoodIt] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FoodIt] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FoodIt] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FoodIt] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FoodIt] SET RECOVERY FULL 
GO
ALTER DATABASE [FoodIt] SET  MULTI_USER 
GO
ALTER DATABASE [FoodIt] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FoodIt] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FoodIt] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FoodIt] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FoodIt] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FoodIt', N'ON'
GO
ALTER DATABASE [FoodIt] SET QUERY_STORE = OFF
GO
USE [FoodIt]
GO
/****** Object:  Table [dbo].[Ingredient]    Script Date: 08/11/2020 9:35:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredient](
	[ingre_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[unit] [nvarchar](100) NULL,
	[image] [varchar](500) NULL,
	[status] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ingre_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recipe]    Script Date: 08/11/2020 9:35:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recipe](
	[recipe_id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](100) NULL,
	[title] [nvarchar](100) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[status] [varchar](100) NOT NULL,
	[date] [datetime] NULL,
	[image] [varchar](500) NOT NULL,
	[category] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[recipe_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecipeIngredient]    Script Date: 08/11/2020 9:35:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecipeIngredient](
	[recipe_id] [int] NOT NULL,
	[ingre_id] [int] NOT NULL,
	[amount_ingre] [varchar](50) NULL,
	[note] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[recipe_id] ASC,
	[ingre_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecipeStep]    Script Date: 08/11/2020 9:35:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecipeStep](
	[step_id] [int] IDENTITY(1,1) NOT NULL,
	[recipe_id] [int] NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[image] [varchar](500) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[step_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 08/11/2020 9:35:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[email] [varchar](100) NOT NULL,
	[username] [varchar](100) NOT NULL,
	[password] [varchar](100) NOT NULL,
	[role] [varchar](100) NOT NULL,
	[image] [varchar](500) NOT NULL,
	[status] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Recipe]  WITH CHECK ADD FOREIGN KEY([email])
REFERENCES [dbo].[User] ([email])
GO
ALTER TABLE [dbo].[RecipeIngredient]  WITH CHECK ADD FOREIGN KEY([ingre_id])
REFERENCES [dbo].[Ingredient] ([ingre_id])
GO
ALTER TABLE [dbo].[RecipeIngredient]  WITH CHECK ADD FOREIGN KEY([recipe_id])
REFERENCES [dbo].[Recipe] ([recipe_id])
GO
ALTER TABLE [dbo].[RecipeStep]  WITH CHECK ADD FOREIGN KEY([recipe_id])
REFERENCES [dbo].[Recipe] ([recipe_id])
GO
/****** Object:  StoredProcedure [dbo].[insertOrIgnoreIngredient]    Script Date: 08/11/2020 9:35:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertOrIgnoreIngredient] (@name NVARCHAR(100), @desc NVARCHAR(MAX)) 
AS BEGIN
	IF NOT EXISTS(SELECT [name] FROM dbo.Ingredient WHERE [name] = @name)
	BEGIN
		INSERT INTO Ingredient([name], [description], [status])
		VALUES(@name, @desc, 'active') 
	END
END
GO
/****** Object:  StoredProcedure [dbo].[insertOrIgnoreIngredientRecipe]    Script Date: 08/11/2020 9:35:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertOrIgnoreIngredientRecipe] (@recipe_id INT, @ingre_id INT, @amount NVARCHAR(MAX)) 
AS BEGIN
	IF NOT EXISTS(SELECT ingre_id,recipe_id FROM dbo.RecipeIngredient WHERE ingre_id = @ingre_id AND recipe_id = @recipe_id)
	BEGIN
		INSERT INTO RecipeIngredient(recipe_id, ingre_id, amount_ingre)
		VALUES(@recipe_id, @ingre_id, @amount) 
	END
END
GO
/****** Object:  StoredProcedure [dbo].[insertOrIgnoreRecipe]    Script Date: 08/11/2020 9:35:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertOrIgnoreRecipe] (@title NVARCHAR(100), @desc NVARCHAR(MAX),
@image varchar(500), @category nvarchar(100)) 
AS BEGIN
	IF NOT EXISTS(SELECT title FROM dbo.Recipe WHERE title = @title)
	BEGIN
		INSERT INTO Recipe(title, [description], [status], [date], [image], category)
		VALUES(@title, @desc, 'active', CURRENT_TIMESTAMP, @image, @category) 
	END
END
GO
USE [master]
GO
ALTER DATABASE [FoodIt] SET  READ_WRITE 
GO
