-- SM Excellent neat work!
use HeartyHearthDB 
go
delete CookbookRecipe
delete Cookbook
delete MealcourseRecipe
delete MealCourse
delete Meal
delete Course
delete RecipeIngredients
delete RecipeInstructions
delete Recipe
delete Measurement
delete Ingredients
delete CuisineType
delete Users

insert users(FirstName, LastName, UserName)
select 'Ava', 'Medrano', 'AvaMedrano'
union select 'Elle', 'Gould', 'ElleGould'
union select 'Mercy', 'Moss', 'MercyMoss'
union select 'Stephanie', 'Griffin', 'StephanieGriffin'
union select 'Mariana', 'Decker', 'MarianaDecker'
union select 'Miley', 'Stevenson', 'MileyStevenson'
union select 'Nicole', 'Moon', 'NicoleMoon'
union select 'Flora', 'Gross', 'FloraGross'

insert CuisineType(CuisineTypeName)
select 'American'
union select 'French'
union select 'English'
union select 'Japanese'
union select 'Zhejiang'
union select 'Thai' 
union select 'Mexican'
union select 'Caribbean'

insert Ingredients(Ingredient)
select 'sugar'
union select 'oil'
union select 'eggs'
union select 'flour'
union select 'vanilla sugar'
union select 'baking powder'
union select 'baking soda'
union select 'chocolate chips'
union select 'granny smith apples'
union select 'vanilla yogurt'
union select 'orange juice'
union select 'honey'
union select 'ice cubes'
union select 'club bread'
union select 'butter'
union select 'shredded cheese'
union select 'garlic (crushed)'
union select 'black pepper'
union select 'salt'
union select 'vanilla pudding'
union select 'whipped cream cheese'
union select 'sour cream cheese'
union select 'salted butter'
union select 'peanut butter'
union select 'raspberry jam'
union select 'brown sugar'
union select 'rolled oats'
union select 'jar whole olives'
union select 'crushed red pepper'
union select 'garlic'
union select 'rib steak'
union select 'rosemary spice'
union select 'onions'
union select 'mushrooms'
union select 'Cranberry juice'
union select 'favorite fruit tea'
union select 'cinnamon'
union select 'water'
union select 'cinnamon sticks'

insert Measurement(UnitOfMeasure)
select 'cup'
union select 'tsp'
union select 'tbsp'
union select 'oz'
union select 'cloves'
union select 'pinch'
union select 'stick'
union select 'box'
union select 'package'
union select 'Ib'
union select 'quart'

;
with x as(
    select UserName = 'AvaMedrano', CuisineTypeName = 'American', RecipeName = 'Chocolate Chip Cookies', Calories = 488, Datedrafted = '04-05-2020', DatePublished = '07-06-2020', DateArchived = null
    union select 'StephanieGriffin', 'French', 'Apple Yogurt Smoothie', 169, '10-27-2022', '11-1-2022', null
    union select 'MercyMoss', 'English', 'Cheese Bread', 650, '05-10-2023', null, null
    union select 'AvaMedrano', 'American', 'Butter Muffins', 169, '07-06-2015', '10-26-2015', '07-20-2023'
    union select 'FloraGross', 'Mexican', 'Peanut Butter & Jam Flapjacks', 156, '01-30-2017', null, '02-28-2017'
    union select 'FloraGross', 'Caribbean', 'spicy Olive Dip', 433, '02-10-2018', '02-11-2018', null
    union select 'AvaMedrano', 'French', 'Juicy Rib Steak', 291, '03-22-2023', null, null
    union select 'NicoleMoon', 'English', 'Fruit Tea', 4, '06-14-2021', null, null
)
insert Recipe(UsersId, CuisinetypeId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
select un.UsersId, ct.CuisineTypeId, x.RecipeName, x.Calories, x.Datedrafted, x.DatePublished, x.DateArchived
from x
join Users un
on x.UserName = un.UserName
join CuisineType ct
on x.CuisineTypeName = ct.CuisineTypeName

;
with x as(
    select RecipeName = 'Chocolate Chip Cookies', Instructions = 'First combine sugar, oil and eggs in a bowl', InstructionsSequence = 1
    union select 'Chocolate Chip Cookies', 'mix well', 2
    union select 'Chocolate Chip Cookies', 'add flour, vanilla sugar, baking powder and baking soda', 3
    union select 'Chocolate Chip Cookies', 'beat for 5 minutes', 4
    union select 'Chocolate Chip Cookies', 'add chocolate chips', 5
    union select 'Chocolate Chip Cookies', 'freeze for 1-2 hours', 6
    union select 'Chocolate Chip Cookies', 'roll into balls and place spread out on a cookie sheet', 7
    union select 'Chocolate Chip Cookies', 'bake on 350 for 10 min', 8
    union select 'Apple Yogurt Smoothie', 'Peel the apples and dice', 1
    union select 'Apple Yogurt Smoothie', 'Combine all ingredients in bowl except for apples and ice cubes', 2
    union select 'Apple Yogurt Smoothie', 'mix until smooth', 3
    union select 'Apple Yogurt Smoothie', 'add apples and ice cubes', 4
    union select 'Apple Yogurt Smoothie', 'pour into glasses', 5 
    union select 'Cheese Bread', 'Slit bread every 3/4 inch', 1
    union select 'Cheese Bread', 'Combine all ingredients in bowl', 2
    union select 'Cheese Bread', 'fill slits with cheese mixture', 3
    union select 'Cheese Bread', 'wrap bread into a foil and bake for 30 minutes', 4
    union select 'Butter Muffins', 'Cream butter with sugars', 1
    union select 'Butter Muffins', 'Add eggs and mix well', 2
    union select 'Butter Muffins', 'Slowly add rest of ingredients and mix well', 3
    union select 'Butter Muffins', 'fill muffin pans 3/4 full and bake for 30 minutes', 4
    union select 'Peanut butter & jam flapjacks', 'Put 3 tbsp each of the peanut butter and jam in separate small bowls and set aside', 1
    union select 'Peanut butter & jam flapjacks', 'Tip the remaining peanut butter, the rest of the jam and the butter and sugar into a pan set over a medium heat and stir until everything has melted together', 2
    union select 'Peanut butter & jam flapjacks', 'Quickly stir in the oats, then leave to cool for 5 mins', 3
    union select 'Peanut butter & jam flapjacks', 'line the base and sides of a 20cm square cake tin with baking parchment', 4
    union select 'Peanut butter & jam flapjacks', 'Spoon the mixture into the prepared cake tin and gently press down with your hands', 5
    union select 'Peanut butter & jam flapjacks', 'Dot over the reserved peanut butter and jam',6
    union select 'Peanut butter & jam flapjacks', ' bake on 350 for 20-25 mins or until golden brown', 7
    union select 'Peanut butter & jam flapjacks', 'Leave to cool completely in the tin, then turn out onto a board and cut into squares', 8
    union select 'spicy Olive Dip', 'Blend the garlic and oil in a food proccesor, set aside', 1
    union select 'spicy Olive Dip', 'Blend the olives watching it should not get overblended', 2
    union select 'spicy Olive Dip', 'Mix together the garlic mixture with the olives', 3
    union select 'spicy Olive Dip', 'Add the crushed red pepper and toss to combine', 4
    union select 'Juicy Rib Steak', 'Marinate the rib steak with the rosmary, oil and salt for 1/2 hour', 1
    union select 'Juicy Rib Steak', 'Sautee onions and mushrooms', 2
    union select 'Juicy Rib Steak', 'Grill the rib steak', 3
    union select 'Juicy Rib Steak', 'pour hot mushrooms on to rib steak before serving', 4
    union select 'Fruit Tea', 'Boil water in a pot', 1
    union select 'Fruit Tea', 'Add fruit tea packets and cranberry juice and simmer on low heat for 20 minutes', 2
    union select 'Fruit Tea', 'Add the cinnamon while stirring the tea', 3
    union select 'Fruit Tea', 'Place a stick into each cup and serve warm', 4

)
insert RecipeInstructions(RecipeId, Instructions, InstructionsSequence)
select r.RecipeId, x.Instructions, x.InstructionsSequence
from x
join Recipe r
on x.RecipeName = r.RecipeName

;
with x as(
    select RecipeName = 'Chocolate Chip Cookies', Ingredient = 'sugar', UnitOfMeasure = 'cup', Quantity = 1, IngredientSequence = 1
    union select 'Chocolate Chip Cookies', 'oil', 'cup', 0.5, 2
    union select 'Chocolate Chip Cookies', 'eggs', null, 3, 3 
    union select 'Chocolate Chip Cookies', 'flour', 'cup', 2, 4
    union select 'Chocolate Chip Cookies', 'vanilla sugar', 'tsp', 1, 5
    union select 'Chocolate Chip Cookies', 'baking powder', 'tsp', 2, 6
    union select 'Chocolate Chip Cookies', 'baking soda', 'tsp', 0.5, 7
    union select 'Chocolate Chip Cookies', 'chocolate chips', 'cup', 1, 8
    union select 'Apple Yogurt Smoothie', 'granny smith apples', null, 3, 1
    union select 'Apple Yogurt Smoothie', 'vanilla yogurt', 'cup', 2, 2
    union select 'Apple Yogurt Smoothie', 'sugar', 'tsp', 2, 3
    union select 'Apple Yogurt Smoothie', 'orange juice', 'cup', 0.5, 4
    union select 'Apple Yogurt Smoothie', 'honey', 'tbsp', 2, 5
    union select 'Apple Yogurt Smoothie', 'ice cubes', null, 6, 6
    union select 'Cheese Bread', 'club bread', null, 1, 1
    union select 'Cheese Bread', 'butter', 'oz', 4, 2
    union select 'Cheese Bread', 'shredded cheese', 'oz', 8, 3
    union select 'Cheese Bread', 'garlic (crushed)', 'cloves', 2, 4
    union select 'Cheese Bread', 'black pepper', 'tsp', 0.25, 5
    union select 'Cheese Bread', 'salt', 'pinch', 1, 6
    union select 'Butter Muffins', 'butter', 'stick', 1, 1
    union select 'Butter Muffins', 'sugar', 'cup', 3, 2
    union select 'Butter Muffins', 'vanilla pudding', 'tbsp', 2, 3
    union select 'Butter Muffins', 'eggs', null, 4, 4
    union select 'Butter Muffins', 'whipped cream cheese', 'oz', 8, 5
    union select 'Butter Muffins', 'sour cream cheese', 'oz', 8, 6
    union select 'Butter Muffins', 'flour', 'cup', 1, 7
    union select 'Butter Muffins', 'baking powder', 'tsp', 2, 8
    union select 'Peanut butter & jam flapjacks', 'salted butter', 'tbsp', 5, 1
    union select 'Peanut butter & jam flapjacks', 'peanut butter', 'oz', 9, 2
    union select 'Peanut butter & jam flapjacks', 'raspberry jam', 'tbsp', 8, 3
    union select 'Peanut butter & jam flapjacks', 'brown sugar', 'oz', 3, 4
    union select 'Peanut butter & jam flapjacks', 'rolled oats', 'oz', 7, 5
    union select 'spicy Olive Dip', 'garlic', 'cloves', 6, 1
    union select 'spicy Olive Dip', 'oil', 'cup', 0.5, 2
    union select 'spicy Olive Dip', 'jar whole olives', null, 1, 3
    union select 'spicy Olive Dip', 'crushed red pepper', 'tsp', 2, 4
    union select 'Juicy Rib Steak', 'rib steak', 'Ib', 5, 1 
    union select 'Juicy Rib Steak', 'rosemary spice', 'tbsp', 1, 2
    union select 'Juicy Rib Steak', 'oil', 'tbsp', 5, 3
    union select 'Juicy Rib Steak', 'salt', 'tsp', 0.5, 4
    union select 'Juicy Rib Steak', 'onions', null, 2, 5
    union select 'Juicy Rib Steak', 'mushrooms', 'box', 1, 6
    union select 'Fruit Tea', 'water', 'quart', 2, 1
    union select 'Fruit Tea', 'favorite fruit tea', 'package', 6, 2
    union select 'Fruit Tea', 'cranberry juice', 'cup', 2, 3
    union select 'Fruit Tea', 'cinnamon', 'tbsp', 1, 4
    union select 'Fruit Tea', 'cinnamon sticks', 'stick', 6, 5
)
insert RecipeIngredients(RecipeId, IngredientsId, MeasurementId, Quantity, IngredientSequence)
select r.RecipeId, i.IngredientsId, m.MeasurementId, x.Quantity, x.IngredientSequence
from x
join Recipe r
on x.RecipeName = r.RecipeName
join Ingredients i
on x.Ingredient = i.Ingredient
left join Measurement m
on x.UnitOfMeasure = m.UnitOfMeasure

insert Course(CourseName, CourseSequence)
select 'Appetizer', 1
union select 'Soup', 2
union select 'Main Dish', 3
union select 'Dessert', 4

;
with x as(
    select UserName = 'MileyStevenson', MealName = 'Breakfast Bash', DateCreated = '07-13-2022', Active = 1
    union select 'MileyStevenson', 'Wish Meal', '01-01-2023', 1
    union select 'FloraGross', 'Diet to Go', '10-28-2019', 0
    union select 'ElleGould', 'Home Chef', '06-06-2020', 1
)
insert Meal(UsersId, MealName, Datecreated, Active)
select un.UsersId, x.MealName, x.DateCreated, x.Active
from x
join Users un
on x.UserName = un.UserName

;
with x as(
    select MealName = 'Breakfast Bash', CourseName = 'Main Dish'
    union select 'Breakfast Bash', 'Dessert'
    union select 'Wish Meal', 'Appetizer'
    union select 'Wish Meal', 'Main Dish'
    union select 'Wish Meal', 'Dessert'
    union select 'Diet to Go', 'Appetizer'
    union select 'Home Chef', 'Main Dish'
    union select 'Home Chef', 'Dessert'
)
insert MealCourse(MealId, CourseId)
select m.MealId, c.CourseId
from x
join Meal m
on x.MealName = m.MealName
join Course c
on x.CourseName = c.CourseName

;
with x as(
    select MealName = 'Breakfast Bash', CourseName = 'Main Dish', RecipeName = 'Cheese Bread', IsMain = 1
    union select 'Breakfast Bash', 'Main Dish', 'spicy Olive Dip', 0
    union select 'Breakfast Bash', 'Dessert', 'Chocolate Chip Cookies', 0
    union select 'Wish Meal', 'Appetizer', 'Peanut butter & jam flapjacks', 0
    union select 'Wish Meal', 'Main Dish', 'Juicy Rib Steak', 1
    union select 'Wish Meal', 'Main Dish', 'spicy Olive Dip', 0
    union select 'Wish Meal', 'Dessert', 'Fruit Tea', 0
    union select 'Diet to Go', 'Appetizer', 'Apple Yogurt Smoothie', 0
    union select 'Home Chef',  'Main Dish', 'Cheese Bread', 1
    union select 'Home Chef', 'Dessert', 'Chocolate Chip Cookies', 0
    union select 'Home Chef', 'Dessert', 'Butter Muffins', 0
)
insert MealcourseRecipe(MealcourseId, RecipeId, IsMain)
select mc.MealCourseId, r.RecipeId, x.IsMain
from x
join Recipe r
on x.RecipeName = r.RecipeName
join meal m
on x.MealName = m.MealName
join Course c
on x.CourseName = c.CourseName
join MealCourse mc
on c.CourseId = mc.CourseId
and m.MealId = mc.MealId

;
with x as(
    select UserName = 'ElleGould', CookbookName = 'Treats for two', Price = 30, DateCreated = '05-10-2017', Active = 1
    union select 'ElleGould', 'Essentials of Cooking', 40.80, '11-22-2022', 1
    union select 'MarianaDecker', 'Plated', 30.50, '08-17-2013', 0
    union select 'FloraGross', 'What is Cooking?', 22.95, '04-23-2023', 1
)
insert Cookbook(UsersId, CookbookName, Price, DateCreated, Active)
select un.UsersId, x.CookbookName, x.Price, x.DateCreated, x.Active
from x
join users un
on x.UserName = un.UserName

;
with x as(
    select CookbookName = 'Treats for two', RecipeName = 'Chocolate Chip Cookies', CookbookRecipeSequence = 1
    union select 'Treats for two', 'Apple Yogurt Smoothie', 2
    union select 'Treats for two', 'Cheese Bread', 3
    union select 'Treats for two', 'Butter Muffins', 4
    union select 'Essentials of Cooking', 'Cheese Bread', 1
    union select 'Essentials of Cooking', 'Juicy Rib Steak', 2
    union select 'Essentials of Cooking', 'Chocolate Chip Cookies', 3
    union select 'Plated', 'Peanut butter & jam flapjacks', 1
    union select 'Plated', 'Butter Muffins', 2
    union select 'What is Cooking?', 'Peanut butter & jam flapjacks', 1
    union select 'What is Cooking?', 'Cheese Bread', 2
    union select 'What is Cooking?', 'Butter Muffins', 3
    union select 'What is Cooking?', 'Fruit Tea', 4
    union select 'What is Cooking?', 'Apple Yogurt Smoothie', 5
)
insert CookbookRecipe(CookbookId, RecipeId, CookbookRecipeSequence)
select c.CookbookId, r.RecipeId, x.CookbookRecipeSequence
from x
join Cookbook c
on x.CookbookName = c.CookbookName
join Recipe r
on x.RecipeName = r.RecipeName