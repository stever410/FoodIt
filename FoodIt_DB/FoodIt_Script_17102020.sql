USE [master]
GO
/****** Object:  Database [FoodIt]    Script Date: 10/17/2020 10:43:05 AM ******/
CREATE DATABASE [FoodIt]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FoodIt', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FoodIt.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FoodIt_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FoodIt_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
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
ALTER DATABASE [FoodIt] SET  DISABLE_BROKER 
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
ALTER DATABASE [FoodIt] SET QUERY_STORE = OFF
GO
USE [FoodIt]
GO
/****** Object:  Table [dbo].[Ingredient]    Script Date: 10/17/2020 10:43:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredient](
	[ingre_id] [varchar](100) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[status] [varchar](100) NOT NULL,
	[unit] [nvarchar](100) NULL,
	[image] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ingre_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rating]    Script Date: 10/17/2020 10:43:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rating](
	[recipe_id] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[score] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[recipe_id] ASC,
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recipe]    Script Date: 10/17/2020 10:43:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recipe](
	[recipe_id] [varchar](100) NOT NULL,
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecipeIngredient]    Script Date: 10/17/2020 10:43:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecipeIngredient](
	[recipe_id] [varchar](100) NOT NULL,
	[ingre_id] [varchar](100) NOT NULL,
	[note] [nvarchar](500) NULL,
	[amount_ingre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[recipe_id] ASC,
	[ingre_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecipeStep]    Script Date: 10/17/2020 10:43:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecipeStep](
	[step_id] [varchar](100) NOT NULL,
	[recipe_id] [varchar](100) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[image] [varchar](500) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[step_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 10/17/2020 10:43:05 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'1', N'Chicken', N'The chicken is a type of domesticated fowl, a subspecies of the red junglefowl (Gallus gallus). It is one of the most common and widespread domestic animals, with a total population of more than 19 billion as of 2011. There are more chickens in the world than any other bird or domesticated fowl. Humans keep chickens primarily as a source of food (consuming both their meat and eggs) and, less commonly, as pets. Originally raised for cockfighting or for special ceremonies, chickens were not kept for food until the Hellenistic period (4th–2nd centuries BC).

Genetic studies have pointed to multiple maternal origins in South Asia, Southeast Asia, and East Asia, but with the clade found in the Americas, Europe, the Middle East and Africa originating in the Indian subcontinent. From ancient India, the domesticated chicken spread to Lydia in western Asia Minor, and to Greece by the 5th century BC. Fowl had been known in Egypt since the mid-15th century BC, with the "bird that gives birth every day" having come to Egypt from the land between Syria and Shinar, Babylonia, according to the annals of Thutmose III.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'101', N'Creme Fraiche', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'104', N'Cumin', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'106', N'Curry Powder', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'111', N'Diced Tomatoes', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'112', N'Digestive Biscuits', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'115', N'Double Cream', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'116', N'Dried Oregano', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'121', N'Egg White', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'122', N'Egg Yolks', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'123', N'Eggs', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'137', N'Flour', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'14', N'Bacon', N'Bacon is a type of salt-cured pork. Bacon is prepared from several different cuts of meat, typically from the pork belly or from back cuts, which have less fat than the belly. It is eaten on its own, as a side dish (particularly in breakfasts), or used as a minor ingredient to flavour dishes (e.g., the club sandwich). Bacon is also used for barding and larding roasts, especially game, including venison and pheasant. The word is derived from the Old High German bacho, meaning "buttock", "ham" or "side of bacon", and is cognate with the Old French bacon.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'149', N'Garlic', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'15', N'Baking Powder', N'Baking powder is a dry chemical leavening agent, a mixture of a carbonate or bicarbonate and a weak acid. The base and acid are prevented from reacting prematurely by the inclusion of a buffer such as cornstarch. Baking powder is used to increase the volume and lighten the texture of baked goods. It works by releasing carbon dioxide gas into a batter or dough through an acid-base reaction, causing bubbles in the wet mixture to expand and thus leavening the mixture. The first single-acting baking powder was developed by Birmingham based food manufacturer Alfred Bird in England in 1843. The first double-acting baking powder was developed by Eben Norton Horsford in America in the 1860s.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'150', N'Garlic Clove', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'154', N'Ginger', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'16', N'Balsamic Vinegar', N'Balsamic vinegar (Italian: aceto balsamico), occasionally shortened to balsamic, is a very dark, concentrated, and intensely flavoured vinegar originating in Italy, made wholly or partially from grape must. Grape must is freshly crushed grape juice with all the skins, seeds and stems.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'162', N'Greek Yogurt', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'169', N'Ground Almonds', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'17', N'Basil', N'Basil, also called great basil, is a culinary herb of the family Lamiaceae (mints).

Basil is native to tropical regions from central Africa to Southeast Asia. It is a tender plant, and is used in cuisines worldwide. Depending on the species and cultivar, the leaves may taste somewhat like anise, with a strong, pungent, often sweet smell.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'177', N'Honey', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'180', N'Hotsauce', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'191', N'Lamb', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'196', N'Leek', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'197', N'Lemon', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'20', N'Bay Leaf', N'The bay leaf is an aromatic leaf commonly used in cooking. It can be used whole, or as dried and ground.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'200', N'Lemons', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'202', N'Lime', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'206', N'Madras Paste', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'217', N'Muscovado Sugar', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'218', N'Mushrooms', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'220', N'Mustard Powder', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'222', N'Nutmeg', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'223', N'Oil', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'224', N'Olive Oil', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'227', N'Onions', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'230', N'Oregano', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'231', N'Oyster Sauce', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'232', N'Paprika', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'237', N'Parsley', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'238', N'Peanut Butter', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'240', N'Peanuts', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'244', N'Pepper', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'248', N'Plain Flour', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'253', N'Potatoes', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'255', N'Puff Pastry', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'259', N'Red Chilli', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'264', N'Red Pepper', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'266', N'Red Wine', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'268', N'Rice', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'275', N'Rosemary', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'276', N'Saffron', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'278', N'Sake', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'281', N'Salt', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'284', N'Sea Salt', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'289', N'Shallots', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'29', N'Black Pepper', N'Black pepper (Piper nigrum) is a flowering vine in the family Piperaceae, cultivated for its fruit, known as a peppercorn, which is usually dried and used as a spice and seasoning. When fresh and fully mature, it is about 5 mm (0.20 in) in diameter and dark red, and contains a single seed, like all drupes. Peppercorns and the ground pepper derived from them may be described simply as pepper, or more precisely as black pepper (cooked and dried unripe fruit), green pepper (dried unripe fruit), or white pepper (ripe fruit seeds).

Black pepper is native to present-day Kerala in Southwestern India, and is extensively cultivated there and elsewhere in tropical regions. Vietnam is the world''s largest producer and exporter of pepper, producing 34% of the world''s crop, as of 2013.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'293', N'Smoked Paprika', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'296', N'Soy Sauce', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'3', N'Beef', N'Beef is the culinary name for meat from cattle, particularly skeletal muscle. Humans have been eating beef since prehistoric times. Beef is a source of high-quality protein and nutrients.

Most beef skeletal muscle meat can be used as is by merely cutting into certain parts, such as roasts, short ribs or steak (filet mignon, sirloin steak, rump steak, rib steak, rib eye steak, hanger steak, etc.), while other cuts are processed (corned beef or beef jerky). Trimmings, on the other hand, are usually mixed with meat from older, leaner (therefore tougher) cattle, are ground, minced or used in sausages. The blood is used in some varieties called blood sausage. Other parts that are eaten include other muscles and offal, such as the oxtail, liver, tongue, tripe from the reticulum or rumen, glands (particularly the pancreas and thymus, referred to as sweetbread), the heart, the brain (although forbidden where there is a danger of bovine spongiform encephalopathy, BSE, commonly referred to as mad cow disease), the kidneys, and the tender testicles of the bull (known in the United States as calf fries, prairie oysters, or Rocky Mountain oysters). Some intestines are cooked and eaten as is, but are more often cleaned and used as natural sausage casings. The bones are used for making beef stock.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'301', N'Spring Onions', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'302', N'Squash', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'305', N'Sugar', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'307', N'Sunflower Oil', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'313', N'Thyme', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'315', N'Tomato Ketchup', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'324', N'Vanilla Extract', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'327', N'Vegetable Oil', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'328', N'Vegetable Stock', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'329', N'Vegetable Stock Cube', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'333', N'Water', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'34', N'Brandy', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'347', N'Icing Sugar', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'354', N'Corn Flour', N'', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'364', N'Onion', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'368', N'Chicken Stock Cube', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'37', N'Broccoli', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'377', N'Passata', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'38', N'Brown Lentils', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'380', N'Lamb Leg', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'381', N'Lamb Shoulder', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'382', N'Apricot', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'383', N'Butternut Squash', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'384', N'Couscous', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'387', N'Minced Beef', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'390', N'Sweetcorn', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'396', N'Rosemary', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'40', N'Brown Sugar', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'402', N'Mozzarella', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'403', N'Ricotta', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'41', N'Butter', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'411', N'Pecan Nuts', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'414', N'Dark Brown Soft Sugar', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'419', N'Shortcrust Pastry', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'425', N'Green Pepper', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'443', N'Sesame Seed Oil', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'457', N'Raisins', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'458', N'Currants', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'464', N'Braeburn Apples', N'N/A', N'active', NULL, NULL)
GO
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'47', N'Cardamom', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'475', N'Yeast', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'479', N'Glace Cherry', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'483', N'Egg', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'487', N'Red Wine Jelly', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'49', N'Carrots', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'51', N'Cashews', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'520', N'Rice Vinegar', N'Rice vinegar is a vinegar made from fermented rice in China, Japan, Korea, and Vietnam.

Chinese rice vinegars are stronger than Japanese ones, and range in colour from clear to various shades of red, brown and black and are therefore known as rice wine vinegar. Chinese and especially Japanese vinegars are less acidic than the distilled Western vinegars which, for that reason, are not appropriate substitutes for rice vinegars. The majority of the Asian rice vinegar types are also more mild and sweet than vinegars typically used in the Western world, with black vinegars as a notable exception. Chinese rice vinegars are made from huangjiu, a type of rice wine.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'521', N'Water Chestnut', N'Eleocharis dulcis, the Chinese water chestnut or water chestnut, is a grass-like sedge native to Asia (China, Japan, India, Philippines, etc.), Australia, tropical Africa, and various islands of the Pacific and Indian Oceans. It is grown in many countries for its edible corms.

The water chestnut is not a nut at all, but an aquatic vegetable that grows in marshes, under water, in the mud. It has stem-like, tubular green leaves that grow to about 1.5 m. The water caltrop, which also is referred to by the same name, is unrelated and often confused with the water chestnut.

The small, rounded corms have a crisp, white flesh and may be eaten raw, slightly boiled, or grilled, and often are pickled or tinned. They are a popular ingredient in Chinese dishes. In China, they are most often eaten raw, sometimes sweetened. They also may be ground into a flour form used for making water chestnut cake, which is common as part of dim sum cuisine. They are unusual among vegetables for remaining crisp even after being cooked or canned, because their cell walls are cross-linked and strengthened by certain phenolic compounds, such as oligomers of ferulic acid. This property is shared by other vegetables that remain crisp in this manner, including the tiger nut and lotus root. The corms contain the antibiotic agent puchiin, which is stable to high temperature. Apart from the edible corms, the leaves can be used for cattlefeed, mulch or compost.

The corms are rich in carbohydrates (about 90% by dry weight), especially starch (about 60% by dry weight), and are also a good source of dietary fiber, riboflavin, vitamin B6, potassium, copper, and manganese.

If eaten uncooked, the surface of the plants may transmit fasciolopsiasis.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'528', N'Starch', N'Starch or amylum is a polymeric carbohydrate consisting of a large number of glucose units joined by glycosidic bonds. This polysaccharide is produced by most green plants as energy storage. It is the most common carbohydrate in human diets and is contained in large amounts in staple foods like potatoes, wheat, maize (corn), rice, and cassava.

Pure starch is a white, tasteless and odorless powder that is insoluble in cold water or alcohol. It consists of two types of molecules: the linear and helical amylose and the branched amylopectin. Depending on the plant, starch generally contains 20 to 25% amylose and 75 to 80% amylopectin by weight.[4] Glycogen, the glucose store of animals, is a more highly branched version of amylopectin.

In industry, starch is converted into sugars, for example by malting, and fermented to produce ethanol in the manufacture of beer, whisky and biofuel. It is processed to produce many of the sugars used in processed foods. Mixing most starches in warm water produces a paste, such as wheatpaste, which can be used as a thickening, stiffening or gluing agent. The biggest industrial non-food use of starch is as an adhesive in the papermaking process. Starch can be applied to parts of some garments before ironing, to stiffen them.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'530', N'Cooking wine', N'Splash into casseroles, sauces and marinades for a rounded vibrant flavour.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'536', N'Dark Rum', N'Rum is a distilled alcoholic drink made from sugarcane byproducts, such as molasses, or directly from sugarcane juice, by a process of fermentation and distillation. The distillate, a clear liquid, is then usually aged in oak barrels.

The majority of the world''s rum production occurs in the Caribbean and Latin America. Rum is also produced in Australia, Portugal, Austria, Canada, Fiji, India, Japan, Mauritius, Nepal, New Zealand, the Philippines, Reunion Island, South Africa, Spain, Sweden, Taiwan, Thailand, the United Kingdom and the United States.

Rums are produced in various grades. Light rums are commonly used in cocktails, whereas "golden" and "dark" rums were typically consumed straight or neat, on the rocks, or used for cooking, but are now commonly consumed with mixers. Premium rums are also available, made to be consumed either straight or iced.

Rum plays a part in the culture of most islands of the West Indies as well as in The Maritimes and Newfoundland. This drink has famous associations with the Royal Navy (where it was mixed with water or beer to make grog) and piracy (where it was consumed as bumbo). Rum has also served as a popular medium of economic exchange, used to help fund enterprises such as slavery (see Triangular trade), organized crime, and military insurgencies (e.g., the American Revolution and Australia''s Rum Rebellion).', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'548', N'Allspice', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'55', N'Celery', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'559', N'Candied Peel', N'Candied fruit, also known as crystallized fruit or glacé fruit, has existed since the 14th century. Whole fruit, smaller pieces of fruit, or pieces of peel, are placed in heated sugar syrup, which absorbs the moisture from within the fruit and eventually preserves it.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'561', N'Sherry', N'Sherry is a fortified wine made from white grapes that are grown near the city of Jerez de la Frontera in Andalusia, Spain.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'562', N'Rose water', N'Rose water is a flavoured water made by steeping rose petals in water. Additionally, it is the hydrosol portion of the distillate of rose petals, a by-product of the production of rose oil for use in perfume. It is used to flavour food, as a component in some cosmetic and medical preparations, and for religious purposes throughout Europe and Asia.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'563', N'Mixed Spice', N'Mixed spice, also called pudding spice, is a British[1] blend of sweet spices, similar to the pumpkin pie spice used in the United States. Cinnamon is the dominant flavour, with nutmeg and allspice. It is often used in baking, or to complement fruits or other sweet foods.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'65', N'Chicken Breast', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'66', N'Chicken Breasts', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'67', N'Chicken Legs', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'68', N'Chicken Stock', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'70', N'Chicken Thighs', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'72', N'Chili Powder', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'75', N'Chilli Powder', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'84', N'Cinnamon', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'89', N'Cocoa', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'9', N'Apple Cider Vinegar', N'Apple cider vinegar, or cider vinegar, is a vinegar made from fermented apple juice, and used in salad dressings, marinades, vinaigrettes, food preservatives, and chutneys. It is made by crushing apples, then squeezing out the juice. Bacteria and yeast are added to the liquid to start the alcoholic fermentation process, which converts the sugars to alcohol. In a second fermentation step, the alcohol is converted into vinegar by acetic acid-forming bacteria (Acetobacter species). Acetic acid and malic acid combine to give vinegar its sour taste. Apple cider vinegar has no medicinal or nutritional value. There is no high-quality clinical evidence that regular consumption of apple cider vinegar helps to maintain or lose body weight, or is effective to manage blood glucose and lipid levels.', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'94', N'Condensed Milk', N'N/A', N'active', NULL, NULL)
INSERT [dbo].[Ingredient] ([ingre_id], [name], [description], [status], [unit], [image]) VALUES (N'95', N'Coriander', N'N/A', N'active', NULL, NULL)
GO
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52770', NULL, N'Spaghetti Bolognese', N'Put the onion and oil in a large pan and fry over a fairly high heat for 3-4 mins. Add the garlic and mince and fry until they both brown. Add the mushrooms and herbs, and cook for another couple of mins.

Stir in the tomatoes, beef stock, tomato ketchup or purée, Worcestershire sauce and seasoning. Bring to the boil, then reduce the heat, cover and simmer, stirring occasionally, for 30 mins.

Meanwhile, cook the spaghetti in a large pan of boiling, salted water, according to packet instructions. Drain well, run hot water through it, put it back in the pan and add a dash of olive oil, if you like, then stir in the meat sauce. Serve in hot bowls and hand round Parmesan cheese, for sprinkling on top.', N'active', NULL, N'images/52770.jpg', N'Beef')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52775', NULL, N'Vegan Lasagna', N'1) Preheat oven to 180 degrees celcius. 
2) Boil vegetables for 5-7 minutes, until soft. Add lentils and bring to a gentle simmer, adding a stock cube if desired. Continue cooking and stirring until the lentils are soft, which should take about 20 minutes. 
3) Blanch spinach leaves for a few minutes in a pan, before removing and setting aside. 
4) Top up the pan with water and cook the lasagne sheets. When cooked, drain and set aside.
5) To make the sauce, melt the butter and add the flour, then gradually add the soya milk along with the mustard and the vinegar. Cook and stir until smooth and then assemble the lasagne as desired in a baking dish. 
6) Bake in the preheated oven for about 25 minutes.', N'active', CAST(N'2020-10-16T16:34:02.633' AS DateTime), N'images/52775.jpg', N'Vegan')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52784', NULL, N'Smoky Lentil Chili with Squash', N'Begin by roasting the squash. Slice it into thin crescents and drizzle with a little oil and sprinkle with sea salt. I added a fresh little sage I had in the fridge, but it’s unnecessary. Roast the squash a 205 C (400 F) for 20-30 minutes, flipping halfway through, until soft and golden. Let cool and chop into cubes.
Meanwhile, rinse the lentils and cover them with water. Bring them to the boil then turn down to a simmer and let cook (uncovered) for 20-30 minutes, or until tender. Drain and set aside.
While the lentils are cooking heat the 1 Tbsp. of oil on low in a medium pot. Add the onions and leeks and sauté for 5 or so minutes, or until they begin to soften. Add the garlic next along with the cumin and coriander, cooking for a few more minutes. Add the remaining spices – paprika, cinnamon, chilli, cocoa, Worcestershire sauce, salt, and oregano. Next add the can of tomatoes, the water or stock, and carrots. Let simmer, covered, for 20 minutes or until the veg is tender and the mixture has thickened up. You’ll need to check on the pot periodically for a stir and a top of of liquid if needed.
Add the lentils and chopped roasted squash. Let cook for 10 more minutes to heat through.
Serve with sliced jalapeno, lime wedges, cilantro, green onions, and cashew sour cream.

SIMPLE CASHEW SOUR CREAM

1 Cup Raw Unsalted Cashews
Pinch Sea Salt
1 tsp. Apple Cider Vinegar
Water

Bring some water to the boil, and use it to soak the cashews for at least four hours. Alternatively, you can use cold water and let the cashews soak overnight, but I’m forgetful/lazy, so often use the boil method which is much faster.
After the cashews have soaked, drain them and add to a high speed blender. Begin to puree, slowly adding about 1/2 cup fresh water, until a creamy consistency is reached. You may need to add less or more water to reach the desired consistency.
Add a pinch of sea salt and vinegar (or lemon juice).', N'active', CAST(N'2020-10-16T16:34:06.527' AS DateTime), N'images/52784.jpg', N'Vegetarian')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52793', NULL, N'Sticky Toffee Pudding Ultimate', N'Stone and chop the dates quite small, put them in a bowl, then pour the boiling water over. Leave for about 30 mins until cool and well-soaked, then mash a bit with a fork. Stir in the vanilla extract. Butter and flour seven mini pudding tins (each about 200ml/7fl oz) and sit them on a baking sheet. Heat oven to 180C/fan 160C/gas 4.
While the dates are soaking, make the puddings. Mix the flour and bicarbonate of soda together and beat the eggs in a separate bowl. Beat the butter and sugar together in a large bowl for a few mins until slightly creamy (the mixture will be grainy from the sugar). Add the eggs a little at a time, beating well between additions. Beat in the black treacle then, using a large metal spoon, gently fold in one-third of the flour, then half the milk, being careful not to overbeat. Repeat until all the flour and milk is used. Stir the soaked dates into the pudding batter. The mix may look a little curdled at this point and will be like a soft, thick batter. Spoon it evenly between the tins and bake for 20-25 mins, until risen and firm.
Meanwhile, put the sugar and butter for the sauce in a medium saucepan with half the cream. Bring to the boil over a medium heat, stirring all the time, until the sugar has completely dissolved. Stir in the black treacle, turn up the heat slightly and let the mixture bubble away for 2-3 mins until it is a rich toffee colour, stirring occasionally to make sure it doesn’t burn. Take the pan off the heat and beat in the rest of the cream.
Remove the puddings from the oven. Leave in the tins for a few mins, then loosen them well from the sides of the tins with a small palette knife before turning them out. You can serve them now with the sauce drizzled over, but they’ll be even stickier if left for a day or two coated in the sauce. To do this, pour about half the sauce into one or two ovenproof serving dishes. Sit the upturned puddings on the sauce, then pour the rest of the sauce over them. Cover with a loose tent of foil so that the sauce doesn’t smudge (no need to chill).
When ready to serve, heat oven to 180C/fan 160C/gas 4. Warm the puddings through, still covered, for 15-20 mins or until the sauce is bubbling. Serve them on their own, or with cream or custard.', N'active', NULL, N'images/52793.jpg', N'Dessert')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52808', NULL, N'Lamb Rogan josh', N'
Put the onions in a food processor and whizz until very finely chopped. Heat the oil in a large heavy-based pan, then fry the onion with the lid on, stirring every now and then, until it is really golden and soft. Add the garlic and ginger, then fry for 5 mins more.
Tip the curry paste, all the spices and the bay leaves into the pan, with the tomato purée. Stir well over the heat for about 30 secs, then add the meat and 300ml water. Stir to mix, turn down the heat, then add the yogurt.
Cover the pan, then gently simmer for 40-60 mins until the meat is tender and the sauce nice and thick. Serve scattered with coriander, with plain basmati or pilau rice.', N'active', NULL, N'images/52808.jpg', N'Lamb')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52814', NULL, N'Thai Green Curry', N'Put the potatoes in a pan of boiling water and cook for 5 minutes. Throw in the beans and cook for a further 3 minutes, by which time both should be just tender but not too soft. Drain and put to one side.
In a wok or large frying pan, heat the oil until very hot, then drop in the garlic and cook until golden, this should take only a few seconds. Don’t let it go very dark or it will spoil the taste. Spoon in the curry paste and stir it around for a few seconds to begin to cook the spices and release all the flavours. Next, pour in the coconut milk and let it come to a bubble.
Stir in the fish sauce and sugar, then the pieces of chicken. Turn the heat down to a simmer and cook, covered, for about 8 minutes until the chicken is cooked.
Tip in the potatoes and beans and let them warm through in the hot coconut milk, then add a lovely citrussy flavour by stirring in the shredded lime leaves (or lime zest). The basil leaves go in next, but only leave them briefly on the heat or they will quickly lose their brightness. Scatter with the lime garnish and serve immediately with boiled rice.', N'active', NULL, N'images/52814.jpg', N'Chicken')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52832', NULL, N'Coq au vin', N'Heat 1 tbsp of the oil in a large, heavy-based saucepan or flameproof dish. Tip in the bacon and fry until crisp. Remove and drain on kitchen paper. Add the shallots to the pan and fry, stirring or shaking the pan often, for 5-8 mins until well browned all over. Remove and set aside with the bacon.
Pat the chicken pieces dry with kitchen paper. Pour the remaining oil into the pan, then fry half the chicken pieces, turning regularly, for 5-8 mins until well browned. Remove, then repeat with the remaining chicken. Remove and set aside.
Scatter in the garlic and fry briefly, then, with the heat medium-high, pour in the brandy or Cognac, stirring the bottom of the pan to deglaze. The alcohol should sizzle and start to evaporate so there is not much left.
Return the chicken legs and thighs to the pan along with any juices, then pour in a little of the wine, stirring the bottom of the pan again. Stir in the rest of the wine, the stock and tomato purée, drop in the bouquet garni, season with pepper and a pinch of salt, then return the bacon and shallots to the pan. Cover, lower the heat to a gentle simmer, add the chicken breasts and cook for 50 mins-1hr.
Just before ready to serve, heat the oil for the mushrooms in a large non-stick frying pan. Add the mushrooms and fry over a high heat for a few mins until golden. Remove and keep warm.
Lift the chicken, shallots and bacon from the pan and transfer to a warmed serving dish. Remove the bouquet garni. To make the thickener, mix the flour, olive oil and butter in a small bowl using the back of a teaspoon. Bring the wine mixture to a gentle boil, then gradually drop in small pieces of the thickener, whisking each piece in using a wire whisk. Simmer for 1-2 mins. Scatter the mushrooms over the chicken, then pour over the wine sauce. Garnish with chopped parsley.', N'active', CAST(N'2020-10-16T16:34:13.090' AS DateTime), N'images/52832.jpg', N'Chicken')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52843', NULL, N'Lamb Tagine', N'Heat the olive oil in a heavy-based pan and add the onion and carrot. Cook for 3- 4 mins until softened.

Add the diced lamb and brown all over. Stir in the garlic and all the spices and cook for a few mins more or until the aromas are released.

Add the honey and apricots, crumble in the stock cube and pour over roughly 500ml boiling water or enough to cover the meat. Give it a good stir and bring to the boil. Turn down to a simmer, put the lid on and cook for 1 hour.

Remove the lid and cook for a further 30 mins, then stir in the squash. Cook for 20 – 30 mins more until the squash is soft and the lamb is tender. Serve alongside rice or couscous and sprinkle with parsley and pine nuts, if using.', N'active', CAST(N'2020-10-16T16:34:10.440' AS DateTime), N'images/52843.jpg', N'Lamb')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52846', NULL, N'Chicken & mushroom Hotpot', N'Heat oven to 200C/180C fan/gas 6. Put the butter in a medium-size saucepan and place over a medium heat. Add the onion and leave to cook for 5 mins, stirring occasionally. Add the mushrooms to the saucepan with the onions.

Once the onion and mushrooms are almost cooked, stir in the flour – this will make a thick paste called a roux. If you are using a stock cube, crumble the cube into the roux now and stir well. Put the roux over a low heat and stir continuously for 2 mins – this will cook the flour and stop the sauce from having a floury taste.

Take the roux off the heat. Slowly add the fresh stock, if using, or pour in 500ml water if you’ve used a stock cube, stirring all the time. Once all the liquid has been added, season with pepper, a pinch of nutmeg and mustard powder. Put the saucepan back onto a medium heat and slowly bring it to the boil, stirring all the time. Once the sauce has thickened, place on a very low heat. Add the cooked chicken and vegetables to the sauce and stir well. Grease a medium-size ovenproof pie dish with a little butter and pour in the chicken and mushroom filling.

Carefully lay the potatoes on top of the hot-pot filling, overlapping them slightly, almost like a pie top.

Brush the potatoes with a little melted butter and cook in the oven for about 35 mins. The hot-pot is ready once the potatoes are cooked and golden brown.', N'active', CAST(N'2020-10-16T16:34:05.847' AS DateTime), N'images/52846.jpg', N'Chicken')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52851', NULL, N'Nutty Chicken Curry', N'Finely slice a quarter of the chilli, then put the rest in a food processor with the ginger, garlic, coriander stalks and one-third of the leaves. Whizz to a rough paste with a splash of water if needed.
Heat the oil in a frying pan, then quickly brown the chicken chunks for 1 min. Stir in the paste for another min, then add the peanut butter, stock and yogurt. When the sauce is gently bubbling, cook for 10 mins until the chicken is just cooked through and sauce thickened. Stir in most of the remaining coriander, then scatter the rest on top with the chilli, if using. Eat with rice or mashed sweet potato.', N'active', CAST(N'2020-10-16T16:34:03.610' AS DateTime), N'images/52851.jpg', N'Chicken')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52859', NULL, N'Key Lime Pie', N'Heat the oven to 160C/fan 140C/gas 3. Whizz the biscuits to crumbs in a food processor (or put in a strong plastic bag and bash with a rolling pin). Mix with the melted butter and press into the base and up the sides of a 22cm loose-based tart tin. Bake in the oven for 10 minutes. Remove and cool.
Put the egg yolks in a large bowl and whisk for a minute with electric beaters. Add the condensed milk and whisk for 3 minutes then add the zest and juice and whisk again for 3 minutes. Pour the filling into the cooled base then put back in the oven for 15 minutes. Cool then chill for at least 3 hours or overnight if you like.
When you are ready to serve, carefully remove the pie from the tin and put on a serving plate. To decorate, softly whip together the cream and icing sugar. Dollop or pipe the cream onto the top of the pie and finish with extra lime zest.', N'active', NULL, N'images/52859.jpg', N'Dessert')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52877', NULL, N'Lamb and Potato pie', N'Dust the meat with flour to lightly coat.
Heat enough vegetable oil in a large saucepan to fill the base, and fry the onion and meat until lightly browned. Season with salt and pepper.
Add the carrots, stock and more seasoning to taste.
Bring to the boil, cover and reduce the heat to a simmer. Simmer for at least an hour or until the meat is tender. Take your time cooking the meat, the longer you leave it to cook, the better the flavour will be.
Preheat the oven to 180C/350F/Gas 4.
Add the drained potato cubes to the lamb.
Turn the mixture into a pie dish or casserole and cover with the shortcrust pastry. Make three slits in the top of the pastry to release any steam while cooking.
Brush with beaten egg and bake for about 40 minutes, until the pastry is golden brown.
Serve.', N'active', NULL, N'images/52877.jpg', N'Lamb')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52910', NULL, N'Chinon Apple Tarts', N'To make the red wine jelly, put the red wine, jam sugar, star anise, clove, cinnamon stick, allspice, split vanilla pod and seeds in a medium saucepan. Stir together, then heat gently to dissolve the sugar. Turn up the heat and boil for 20 mins until reduced and syrupy. Strain into a small, sterilised jam jar and leave to cool completely. Will keep in the fridge for up to 1 month.

Take the pastry out of the fridge and leave at room temperature for 10 mins, then unroll. Heat the grill to high and heat the oven to 180C/160C fan/gas 4. Cut out 2 x 13cm circles of pastry, using a plate as a guide, and place on a non-stick baking sheet. Sprinkle each circle with 1 tbsp sugar and grill for 5 mins to caramelise, watching carefully so that the sugar doesn’t burn. Remove from the grill. Can be done a few hours ahead, and left, covered, out of the fridge.

Peel, quarter and core the apples, cut into 2mm-thin slices and arrange on top of the pastry. Sprinkle over the remaining sugar and pop in the oven for 20-25 mins until the pastry is cooked through and golden, and the apples are softened. Remove and allow to cool slightly. Warm 3 tbsp of the red wine jelly in a small pan over a low heat with 1 tsp water to make it a little more runny, then brush over the top of the tarts.

Tip the crème fraîche into a bowl, sift over the icing sugar and cardamom, and mix together. Carefully lift the warm tarts onto serving plates and serve with the cardamom crème fraîche.', N'active', NULL, N'images/52910.jpg', N'Dessert')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52938', NULL, N'Jamaican Beef Patties', N'Make the Pastry Dough

To a large bowl, add flour, 1 teaspoon salt, and turmeric and mix thoroughly.
Rub shortening into flour until there are small pieces of shortening completely covered with flour.
Pour in 1/2 cup of the ice water and mix with your hands to bring the dough together. Keep adding ice water 2 to 3 tablespoons at a time until the mixture forms a dough.
At this stage, you can cut the dough into 2 large pieces, wrap in plastic and refrigerate for 30 minutes before using it.
Alternatively, cut the dough into 10 to 12 equal pieces, place on a platter or baking sheet, cover securely with plastic wrap and let chill for 30 minutes while you make the filling.
Make the Filling

Add ground beef to a large bowl. Sprinkle in allspice and black pepper. Mix together and set aside.
Heat oil in a skillet until hot.
Add onions and sauté until translucent. Add hot pepper, garlic and thyme and continue to sauté for another minute. Add 1/4 teaspoon salt.
Add seasoned ground beef and toss to mix, breaking up any clumps, and let cook until the meat is no longer pink.
Add ketchup and more salt to taste.
Pour in 2 cups of water and stir. Bring the mixture to a boil then reduce heat and let simmer until most of the liquid has evaporated and whatever is remaining has reduced to a thick sauce.
Fold in green onions. Remove from heat and let cool completely.
Assemble the Patties

Beat the egg and water together to make an egg wash. Set aside.
Now you can prepare the dough in two ways.
First Method: Flour the work surface and rolling pin. If you had cut it into 2 large pieces, then take one of the large pieces and roll it out into a very large circle. Take a bowl with a wide rim (about 5 inches) and cut out three circles.

Place about 3 heaping tablespoons of the filling onto 1/2 of each circle. Dip a finger into the water and moisten the edges of the pastry. Fold over the other half and press to seal. 

Take a fork and crimp the edges. Cut off any extra to make it look neat and uniform. Place on a parchment-lined baking sheet and continue to work until you have rolled all the dough and filled the patties.
Second Method: If you had pre-cut the dough into individual pieces, work with one piece of dough at a time. Roll it out on a floured surface into a 5-inch circle or a little larger. Don’t worry if the edges are not perfect.

Place 3 heaping tablespoons of the filling on one side of the circle. Dip a finger into the water and moisten the edges of the pastry. Fold over the other half and press to seal.

Take a fork and crimp the edges. Cut off any extra to make it look neat and uniform. Place on a parchment-lined baking sheet and continue work until you have rolled all the dough and filled the patties.

Frying and Serving the Patties

After forming the patties, place the pans in the refrigerator while you heat the oven to 350 F.
Just before adding the pans with the patties to the oven, brush the patties with egg wash.
Bake patties for 30 minutes or until golden brown.
Cool on wire racks.
Serve warm.', N'active', CAST(N'2020-10-16T16:34:12.063' AS DateTime), N'images/52938.jpg', N'Beef')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52945', NULL, N'Kung Pao Chicken', N'Combine the sake or rice wine, soy sauce, sesame oil and cornflour dissolved in water. Divide mixture in half.
In a glass dish or bowl, combine half of the sake mixture with the chicken pieces and toss to coat. Cover dish and place in refrigerator for about 30 minutes.
In a medium frying pan, combine remaining sake mixture, chillies, vinegar and sugar. Mix together and add spring onion, garlic, water chestnuts and peanuts. Heat sauce slowly over medium heat until aromatic.
Meanwhile, remove chicken from marinade and sauté in a large frying pan until juices run clear. When sauce is aromatic, add sautéed chicken and let simmer together until sauce thickens.', N'active', NULL, N'images/52945.jpg', N'Chicken')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52950', NULL, N'Szechuan Beef', N'STEP 1 - MARINATING THE BEEF
In a bowl, add the beef, salt, sesame seed oil, white pepper, egg white, 2 Tablespoon of corn starch and 1 Tablespoon of oil.
STEP 2 - STIR FRY
First Cook the beef by adding 2 Tablespoon of oil until the beef is golden brown.
Set the beef aside
In a wok add 1 Tablespoon of oil, minced ginger, minced garlic and stir-fry for few seconds.
Next add all of the vegetables and then add sherry cooking wine and 1 cup of water.
To make the sauce add oyster sauce, hot pepper sauce, and sugar.
add the cooked beef and 1 spoon of soy sauce
To thicken the sauce, whisk together 1 Tablespoon of cornstarch and 2 Tablespoon of water in a bowl and slowly add to your stir-fry until it''s the right thickness.', N'active', NULL, N'images/52950.jpg', N'Beef')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52961', NULL, N'Budino Di Ricotta', N'Mash the ricotta and beat well with the egg yolks, stir in the flour, sugar, cinnamon, grated lemon rind and the rum and mix well. You can do this in a food processor. Beat the egg whites until stiff, fold in and pour into a buttered and floured 25cm cake tin. Bake in the oven at 180ºC/160ºC fan/gas 4 for about 40 minutes, or until it is firm.

Serve hot or cold dusted with icing sugar.', N'active', NULL, N'images/52961.jpg', N'Dessert')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52990', NULL, N'Christmas cake', N'Heat oven to 160C/fan 140C/gas 3. Line the base and sides of a 20 cm round, 7.5 cm deep cake tin. Beat the butter and sugar with an electric hand mixer for 1-2 mins until very creamy and pale in colour, scraping down the sides of the bowl half way through. Stir in a spoonful of the flour, then stir in the beaten egg and the rest of the flour alternately, a quarter at a time, beating well each time with a wooden spoon. Stir in the almonds.

Mix in the sherry (the mix will look curdled), then add the peel, cherries, raisins, cherries, nuts, lemon zest, spice, rosewater and vanilla. Beat together to mix, then stir in the baking powder.

Spoon mixture into the tin and smooth the top, making a slight dip in the centre. Bake for 30 mins, then lower temperature to 150C/fan 130C/gas 2 and bake a further 2-2¼ hrs, until a skewer insterted in the middle comes out clean. Leave to cool in the tin, then take out of the tin and peel off the lining paper. When completely cold, wrap well in cling film and foil to store until ready to decorate. The cake will keep for several months.', N'active', CAST(N'2020-10-16T16:34:08.990' AS DateTime), N'images/52990.jpg', N'Dessert')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'52993', NULL, N'Honey Balsamic Chicken with Crispy Broccoli & Potatoes', N'2 Servings

1. Preheat oven to 425 degrees. Wash and dry all produce. Cut potatoes into 1/2-inch-thick wedges. Toss on one side of a baking sheet with a drizzle of oil, salt, and pepper. (For 4 servings, spread potatoes out across entire sheet.) Roast on top rack for 5 minutes (we''ll add the broccoli then). 

2. Meanwhile, cut broccoli florets into bite-size pieces, if necessary. Peel and finely chop garlic. In a small microwave-safe bowl, combine 1 TBSP olive oil (2 TBSP for 4 servings) and half the garlic. Microwave until garlic sizzles, 30 seconds. 

3. Once potatoes have roasted 5 minutes, remove sheet from oven and add broccoli to empty side; carefully toss with garlic oil, salt, and pepper. (For 4 servings, add broccoli to a second sheet.) Continue roasting until potatoes and broccoli are browned and crispy, 15-20 minutes more. 

4. While veggies roast, pat chicken dry with paper towels; season all over with salt and pepper. Heat a drizzle of oil in a large pan over medium-high heat. Add chicken and cook until browned and cooked through, 5-6 minutes per side. (If chicken browns too quickly, reduce heat to medium.) Turn off heat; set chicken aside to rest. Wash out pan. 

5. Heat pan used for chicken over medium-high heat. Add a drizzle of oil and remaining garlic; cook until fragrant, 30 seconds. Stir in vinegar, honey, stock concentrate, and 1/4 cup water (1/3 cup for 4 servings). Simmer until thick and glossy, 2-3 minutes. Remove from heat and stir in 1 TBSP butter (2 TBSP for 4). Season with salt and pepper. 

6. Return chicken to pan and turn to coat in glaze. Divide chicken, broccoli, and potatoes between plates. Spoon any remaining glaze over chicken and serve. ', N'active', CAST(N'2020-10-16T16:34:07.917' AS DateTime), N'images/52993.jpg', N'Chicken')
INSERT [dbo].[Recipe] ([recipe_id], [email], [title], [description], [status], [date], [image], [category]) VALUES (N'53014', NULL, N'Pizza Express Margherita', N'1 Preheat the oven to 230°C.

2 Add the sugar and crumble the fresh yeast into warm water.

3 Allow the mixture to stand for 10 – 15 minutes in a warm place (we find a windowsill on a sunny day works best) until froth develops on the surface.

4 Sift the flour and salt into a large mixing bowl, make a well in the middle and pour in the yeast mixture and olive oil.

5 Lightly flour your hands, and slowly mix the ingredients together until they bind.

6 Generously dust your surface with flour.

7 Throw down the dough and begin kneading for 10 minutes until smooth, silky and soft.

8 Place in a lightly oiled, non-stick baking tray (we use a round one, but any shape will do!)

9 Spread the passata on top making sure you go to the edge.

10 Evenly place the mozzarella (or other cheese) on top, season with the oregano and black pepper, then drizzle with a little olive oil.

11 Cook in the oven for 10 – 12 minutes until the cheese slightly colours.

12 When ready, place the basil leaf on top and tuck in!', N'active', NULL, N'images/53014.jpg', N'Miscellaneous')
GO
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'104', NULL, N'4 tsp ground ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'111', NULL, N'1 can')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'116', NULL, N'1/2 tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'149', NULL, N'3 cloves')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'196', NULL, N'1 chopped')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'224', NULL, N'1 tbls')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'284', NULL, N'1 tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'293', NULL, N'1 tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'302', NULL, N'1 Small')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'333', NULL, N'3 cups')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'364', NULL, N'1')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'38', NULL, N'1 1/2 cups')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'49', NULL, N'3 chopped')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'51', NULL, N'1 Cup')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'72', NULL, N'1 tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'84', NULL, N'1/2 tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'89', NULL, N'1 tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'9', NULL, N'1 tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52784', N'95', NULL, N'2 tsp ground')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52808', N'149', NULL, N'4 cloves')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52808', N'154', NULL, N'Thumb sized peeled and very finely grated')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52808', N'191', NULL, N'1kg cubed')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52808', N'20', NULL, N'2')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52808', N'206', NULL, N'2 tbsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52808', N'232', NULL, N'2 tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52808', N'307', NULL, N'4 tbsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52808', N'364', NULL, N'2 quartered')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52808', N'47', NULL, N'6 bashed to break shells')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52808', N'95', NULL, N'Garnish chopped ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52814', N'1', NULL, N'450g boneless')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52814', N'268', NULL, N'Boiled')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52814', N'305', NULL, N'1 tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52832', N'14', NULL, N'3 rashers (100g) chopped dry-cured')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52832', N'149', NULL, N'3 finely chopped')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52832', N'224', NULL, N'1½ tbsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52832', N'266', NULL, N'600ml')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52832', N'275', NULL, N'2 sprigs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52832', N'289', NULL, N'12 small')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52832', N'34', NULL, N'3 tbsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52832', N'396', NULL, N'2 sprigs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52832', N'66', NULL, N'2 (280g)')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52832', N'67', NULL, N'2 (460g)')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52832', N'68', NULL, N'150ml')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52832', N'70', NULL, N'4 (650g)')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'104', NULL, N'½ tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'149', NULL, N'2 cloves minced')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'154', NULL, N'½ tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'177', NULL, N'1 tblsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'224', NULL, N'2 tblsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'237', NULL, N'Chopped')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'276', NULL, N'¼ tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'329', NULL, N'1')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'364', NULL, N'1 finely sliced')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'380', NULL, N'500g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'382', NULL, N'100g ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'383', NULL, N'1 medium chopped')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'384', NULL, N'Steamed')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'49', NULL, N'2 chopped')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52843', N'84', NULL, N'1 tsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52846', N'1', NULL, N'250g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52846', N'218', NULL, N'100g ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52846', N'220', NULL, N'pinch')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52846', N'222', NULL, N'pinch')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52846', N'248', NULL, N'40g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52846', N'253', NULL, N'2 large')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52846', N'364', NULL, N'1 chopped')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52846', N'368', NULL, N'1')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52846', N'390', NULL, N'2 Handfuls')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52846', N'41', NULL, N'50g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52851', N'149', NULL, N'1 large')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52851', N'154', NULL, N'0.5')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52851', N'162', NULL, N'200g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52851', N'238', NULL, N'5 tblsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52851', N'259', NULL, N'1 large')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52851', N'307', NULL, N'1 tbsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52851', N'66', NULL, N'4')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52851', N'68', NULL, N'150ml')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52851', N'95', NULL, N'Bunch')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52859', N'112', NULL, N'300g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52859', N'115', NULL, N'300ml ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52859', N'122', NULL, N'3')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52859', N'202', NULL, N'4')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52859', N'347', NULL, N'1 tbls')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52859', N'41', NULL, N'150g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52859', N'94', NULL, N'400g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52877', N'123', NULL, N'To Glaze')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52877', N'137', NULL, N'1 tbls')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52877', N'253', NULL, N'500g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52877', N'327', NULL, N'Dash')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52877', N'328', NULL, N'350ml/12fl')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52877', N'364', NULL, N'1 sliced')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52877', N'381', NULL, N'500g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52877', N'419', NULL, N'450g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52877', N'49', NULL, N'2 sliced')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52910', N'101', NULL, N'100ml')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52910', N'255', NULL, N'320g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52910', N'347', NULL, N'1 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52910', N'414', NULL, N'4 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52910', N'464', NULL, N'3')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52910', N'47', NULL, N'3')
GO
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52910', N'487', NULL, N'4 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'106', NULL, N'1 tsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'149', NULL, N'2 tsp ground')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'227', NULL, N'1 cup ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'248', NULL, N'4 cups ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'264', NULL, N'Ground')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'281', NULL, N'1 tsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'29', NULL, N'1/2 tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'313', NULL, N'1 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'315', NULL, N'2 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'327', NULL, N'2 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'333', NULL, N'1 cup ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'387', NULL, N'900g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'41', NULL, N'250g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'483', NULL, N'1 beaten')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52938', N'548', NULL, N'1 tsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52945', N'1', NULL, N'500g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52945', N'150', NULL, N'6 cloves')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52945', N'240', NULL, N'100g ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52945', N'278', NULL, N'2 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52945', N'296', NULL, N'2 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52945', N'301', NULL, N'4 Chopped')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52945', N'333', NULL, N'2 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52945', N'354', NULL, N'2 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52945', N'40', NULL, N'1 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52945', N'443', NULL, N'2 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52945', N'520', NULL, N'1 tsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52945', N'521', NULL, N'220g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52945', N'75', NULL, N'1 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'121', NULL, N'1')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'149', NULL, N'1 tsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'154', NULL, N'1 tsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'180', NULL, N'1/2 tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'218', NULL, N'1 cup ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'223', NULL, N'4 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'231', NULL, N'1 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'244', NULL, N'1 pinch')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'281', NULL, N'1/2 tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'296', NULL, N'1 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'3', NULL, N'1/2 lb')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'305', NULL, N'1 tsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'333', NULL, N'1 cup ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'364', NULL, N'3/4 cup ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'425', NULL, N'3/4 cup ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'443', NULL, N'1 tsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'49', NULL, N'1/2 cup ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'528', NULL, N'3 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'530', NULL, N'1 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52950', N'55', NULL, N'1 cup ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52961', N'123', NULL, N'4 large')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52961', N'137', NULL, N'3 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52961', N'200', NULL, N'Grated Zest of 2')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52961', N'305', NULL, N'250g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52961', N'347', NULL, N'sprinking')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52961', N'403', NULL, N'500g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52961', N'536', NULL, N'5 tbs')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52961', N'84', NULL, N'1 tsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'123', NULL, N'4 Beaten')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'15', NULL, N'1/2 tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'169', NULL, N'50g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'197', NULL, N'Grated zest of 1')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'217', NULL, N'200g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'248', NULL, N'200g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'324', NULL, N'1/2 tsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'41', NULL, N'200g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'411', NULL, N'100g ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'457', NULL, N'250g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'458', NULL, N'250g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'479', NULL, N'85g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'559', NULL, N'85g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'561', NULL, N'100ml')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'562', NULL, N'1 ½ tbsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52990', N'563', NULL, N'1 ½ tbsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52993', N'149', NULL, N'2 cloves')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52993', N'16', NULL, N' ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52993', N'177', NULL, N' ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52993', N'224', NULL, N'1 tbsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52993', N'253', NULL, N'5')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52993', N'327', NULL, N'1 tbsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52993', N'37', NULL, N'1')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52993', N'41', NULL, N'1 tbsp')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52993', N'65', NULL, N'2')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'52993', N'68', NULL, N' ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'53014', N'17', NULL, N'Leaves')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'53014', N'224', NULL, N'Drizzle')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'53014', N'230', NULL, N'Peeled and Sliced')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'53014', N'248', NULL, N'225g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'53014', N'281', NULL, N'1 1/2 tsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'53014', N'29', NULL, N'Pinch')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'53014', N'305', NULL, N'1 tsp ')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'53014', N'333', NULL, N'150ml')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'53014', N'377', NULL, N'80g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'53014', N'402', NULL, N'70g')
INSERT [dbo].[RecipeIngredient] ([recipe_id], [ingre_id], [note], [amount_ingre]) VALUES (N'53014', N'475', NULL, N'15g')
GO
INSERT [dbo].[User] ([email], [username], [password], [role], [image], [status]) VALUES (N'test1@gmail.com', N'admin', N'1', N'admin', N'no image', N'active')
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD FOREIGN KEY([email])
REFERENCES [dbo].[User] ([email])
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD FOREIGN KEY([recipe_id])
REFERENCES [dbo].[Recipe] ([recipe_id])
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
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD CHECK  (([score]>=(1) AND [score]<=(5)))
GO
/****** Object:  StoredProcedure [dbo].[insertOrIgnoreIngredient]    Script Date: 10/17/2020 10:43:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertOrIgnoreIngredient] (@ingre_id VARCHAR(100), @name NVARCHAR(100), @desc NVARCHAR(MAX)) 
AS BEGIN
	IF NOT EXISTS(SELECT ingre_id FROM dbo.Ingredient WHERE ingre_id = @ingre_id)
	BEGIN
		INSERT INTO Ingredient(ingre_id, [name], [description], [status])
		VALUES(@ingre_id, @name, @desc, 'active') 
	END
END
GO
/****** Object:  StoredProcedure [dbo].[insertOrIgnoreIngredientRecipe]    Script Date: 10/17/2020 10:43:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertOrIgnoreIngredientRecipe] (@recipe_id VARCHAR(100), @ingre_id NVARCHAR(100), @amount NVARCHAR(MAX)) 
AS BEGIN
	IF NOT EXISTS(SELECT ingre_id,recipe_id FROM dbo.RecipeIngredient WHERE ingre_id = @ingre_id AND recipe_id = @recipe_id)
	BEGIN
		INSERT INTO RecipeIngredient(recipe_id, ingre_id, amount_ingre)
		VALUES(@recipe_id, @ingre_id, @amount) 
	END
END
GO
/****** Object:  StoredProcedure [dbo].[insertOrIgnoreRecipe]    Script Date: 10/17/2020 10:43:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertOrIgnoreRecipe] (@recipe_id VARCHAR(100), @title NVARCHAR(100), @desc NVARCHAR(MAX),
@image varchar(500), @category nvarchar(100)) 
AS BEGIN
	IF NOT EXISTS(SELECT recipe_id FROM dbo.Recipe WHERE recipe_id = @recipe_id)
	BEGIN
		INSERT INTO Recipe(recipe_id, title, [description], [status], [date], [image], category)
		VALUES(@recipe_id, @title, @desc, 'active', CURRENT_TIMESTAMP, @image, @category) 
	END
END
GO
USE [master]
GO
ALTER DATABASE [FoodIt] SET  READ_WRITE 
GO
