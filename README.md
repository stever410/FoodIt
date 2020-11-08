# FoodIt
- Add [email] to 'Recipe' as Foreign Key
- Add [category] to 'Recipe' as attribute
- Remove not null contraint from [image] of 'Ingredient'
- Change 'amount_ingre' type from float to varchar(50)
- Add procedure insertOrIgnoreRecipe
- Add procedure insertOrIgnoreIngredient
- Add procedure insertOrIgnoreIngredientRecipe
- Insert 20 recipes with associated Ingredient and RecipeIngredient(temporary description of Recipe is its steps)
- Tables mordified:
+ Recipe (insert, update)
+ Ingredient (insert, update)
+ RecipeIngredient (insert, update)
# FoodIt database v2
- Required for branch foodit-newui-v2
- Add brand new 55 recipes
- Remove redundant ingredients (ones we'll might never use)
- Still with minor bugs
