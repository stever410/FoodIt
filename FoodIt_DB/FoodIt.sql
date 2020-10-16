CREATE DATABASE FoodIt;

USE FoodIt

CREATE TABLE [User](
	email VARCHAR(100) NOT NULL PRIMARY KEY,
	username VARCHAR(100) NOT NULL,
	[password] VARCHAR(100) NOT NULL,
	[role] VARCHAR(100) NOT NULL,
	[image] VARCHAR(500) NOT NULL,
	[status] VARCHAR(100) NOT NULL,
)

CREATE TABLE Recipe(
	recipe_id VARCHAR(100) NOT NULL PRIMARY KEY,
	email VARCHAR(100) FOREIGN KEY REFERENCES dbo.[User](email),
	title NVARCHAR(100) NOT NULL,
	[description] NVARCHAR(MAX) NOT NULL,
	[status] VARCHAR(100) NOT NULL,
	[date] DATETIME,
	[image] VARCHAR(500) NOT NULL,
	category NVARCHAR(100)
)

CREATE TABLE Ingredient(
	ingre_id VARCHAR(100) NOT NULL PRIMARY KEY,
	[name] NVARCHAR(100) NOT NULL,
	[description] NVARCHAR(MAX) NOT NULL,
	unit NVARCHAR(100),
	[image] VARCHAR(500),
	[status] VARCHAR(100) NOT NULL,
)

CREATE TABLE Rating(
	recipe_id VARCHAR(100) NOT NULL FOREIGN KEY REFERENCES dbo.Recipe(recipe_id),
	email VARCHAR(100) NOT NULL FOREIGN KEY REFERENCES dbo.[User](email),
	score INT NOT NULL CHECK(score >= 1 AND score <= 5),
	PRIMARY KEY(recipe_id,email),
)

CREATE TABLE RecipeStep(
	step_id VARCHAR(100) NOT NULL PRIMARY KEY,
	recipe_id VARCHAR(100) NOT NULL FOREIGN KEY REFERENCES dbo.Recipe(recipe_id),
	[description] NVARCHAR(MAX) NOT NULL,
	[image] VARCHAR(500) NOT NULL,
	
)

CREATE TABLE RecipeIngredient(
	recipe_id VARCHAR(100) NOT NULL FOREIGN KEY REFERENCES dbo.Recipe(recipe_id),
	ingre_id VARCHAR(100) NOT NULL FOREIGN KEY REFERENCES dbo.Ingredient(ingre_id),
	amount_ingre VARCHAR(50),
	note NVARCHAR(500),
	PRIMARY KEY(recipe_id,ingre_id),
)

CREATE PROCEDURE insertOrIgnoreRecipe (@recipe_id VARCHAR(100), @title NVARCHAR(100), @desc NVARCHAR(MAX),
@image varchar(500), @category nvarchar(100)) 
AS BEGIN
	IF NOT EXISTS(SELECT recipe_id FROM dbo.Recipe WHERE recipe_id = @recipe_id)
	BEGIN
		INSERT INTO Recipe(recipe_id, title, [description], [status], [date], [image], category)
		VALUES(@recipe_id, @title, @desc, 'active', CURRENT_TIMESTAMP, @image, @category) 
	END
END

CREATE PROCEDURE insertOrIgnoreIngredient (@ingre_id VARCHAR(100), @name NVARCHAR(100), @desc NVARCHAR(MAX)) 
AS BEGIN
	IF NOT EXISTS(SELECT ingre_id FROM dbo.Ingredient WHERE ingre_id = @ingre_id)
	BEGIN
		INSERT INTO Ingredient(ingre_id, [name], [description], [status])
		VALUES(@ingre_id, @name, @desc, 'active') 
	END
END

CREATE PROCEDURE insertOrIgnoreIngredientRecipe (@recipe_id VARCHAR(100), @ingre_id NVARCHAR(100), @amount NVARCHAR(MAX)) 
AS BEGIN
	IF NOT EXISTS(SELECT ingre_id,recipe_id FROM dbo.RecipeIngredient WHERE ingre_id = @ingre_id AND recipe_id = @recipe_id)
	BEGIN
		INSERT INTO RecipeIngredient(recipe_id, ingre_id, amount_ingre)
		VALUES(@recipe_id, @ingre_id, @amount) 
	END
END