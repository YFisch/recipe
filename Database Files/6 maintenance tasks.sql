-- SM Excellent! See comments, no need to resubmit.
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.
use HeartyHearthDB
go
--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.
-- SM -50% The recipe has a user and the meal/cookbook have users. You're only deleting the recipes. Try this with a user that has recipes and meals/cookbooks and you'll see it fails.
-- The issue is, because anyone that creates a meal can use recipes from different users. You also need to delete the recipes from this users meals.

-- SM This is not needed. You shouldn't delete the instructions of the recipes in ones cookbook, you should only delete the instructions from ones recipes.
-- You're not deleting the recipes. You're deleting the recipes in the cookbook. (cookbook recipe table)

-- SM Same here.

delete cr
from users un
join Cookbook c
on un.UsersId = c.UsersId
join CookbookRecipe cr
on c.CookbookId = cr.CookbookId
where un.UserName = 'FloraGross'

delete cr
from Users un
join Recipe r
on un.UsersId = r.UsersId
join CookbookRecipe cr
on r.RecipeId = cr.RecipeId
where un.UserName = 'FloraGross'

delete c
from users u
join Cookbook c
on u.UsersId = c.UsersId
where u.UserName = 'FloraGross'


-- SM Same here.

delete mcr
from users un
join Meal m
on un.UsersId = m.UsersId
join MealCourse mc
on m.MealId = mc.MealId
join MealcourseRecipe mcr
on mc.MealCourseId = mcr.MealcourseId
where un.UserName = 'FloraGross'

delete mcr
from Users un
join Recipe r
on un.UsersId = r.UsersId
join MealcourseRecipe mcr
on r.RecipeId = mcr.RecipeId
where un.UserName = 'FloraGross'
-- SM same here.

-- SM Same here.

-- SM Same here.

delete mc
from users u
join Meal m
on u.UsersId = m.UsersId
join MealCourse mc
on m.MealId = mc.MealId
where u.UserName = 'FloraGross'

delete m
from users u
join Meal m
on u.UsersId = m.UsersId
where u.UserName = 'FloraGross'

delete ri
from Users un
join Recipe r
on un.UsersId = r.UsersId
join RecipeInstructions ri
on r.RecipeId = ri.RecipeId
where un.UserName = 'FloraGross'

delete rin
from Users un
join Recipe r
on un.UsersId = r.UsersId
join RecipeIngredients rin
on r.RecipeId = rin.RecipeId
where un.UserName = 'FloraGross'

-- SM Move this one up with the cookbooks. It will make it more readable


delete r
from Users un
join Recipe r
on un.UsersId = r.UsersId
where un.UserName = 'FloraGross'

delete un
from Users un
where un.UserName = 'FloraGross'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
insert Recipe(UsersId, CuisinetypeId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
select r.UsersId, r.CuisinetypeId, CONCAT(r.RecipeName, ' - clone'), r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived
from Recipe r
where r.RecipeName = 'Apple Yogurt Smoothie'

insert RecipeIngredients(RecipeId, IngredientsId, MeasurementId, Quantity, IngredientSequence)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Apple Yogurt Smoothie - clone'), ri.IngredientsId, ri.MeasurementId, ri.Quantity, ri.IngredientSequence
from Recipe r
join RecipeIngredients ri
on r.RecipeId = ri.RecipeId
where r.RecipeName = 'Apple Yogurt Smoothie'

insert RecipeInstructions(RecipeId, Instructions, InstructionsSequence)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Apple Yogurt Smoothie - clone'), ri.Instructions, ri.InstructionsSequence
from Recipe r
join RecipeInstructions ri
on r.RecipeId = ri.RecipeId
where r.RecipeName = 'Apple Yogurt Smoothie'
/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
;
with x as(
	select NumOfRecipes = COUNT(r.RecipeId), un.UserName
	from Users un
	join Recipe r
	on un.UsersId = r.UsersId
	where un.UserName = 'FloraGross'
	group by UserName
)
insert Cookbook(UsersId, CookbookName, Price, DateCreated, Active)
select un.UsersId, CONCAT('Recipes by ',un.FirstName, ' ', un.LastName ), NUmOfRecipes * 1.33, '05-15-2023', 1
from x
join users un
on x.UserName = un.UserName
where un.UserName = 'FloraGross'

insert CookbookRecipe(CookbookId, RecipeId, CookbookRecipeSequence)
select c.CookbookId, r.RecipeId, ROW_NUMBER() over (order by RecipeId)
from Cookbook c
join Users un
on c.UsersId = un.UsersId
join Recipe r
on un.UsersId = r.UsersId
where un.UserName = 'FloraGross'
-- SM Tip: Use concat() here same as you did when creating the recipe name. It will help you in future sessions.
and c.CookbookName = CONCAT('Recipes by ',un.FirstName, ' ', un.LastName )
/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
-- SM Use calories = calories - (case... end * quantity) no need for else
update r
set r.Calories =  r.Calories -
case 
when m.UnitOfMeasure = 'cup' then  2
when m.UnitOfMeasure = 'tsp' then 10
end
* ri.Quantity
from Recipe r 
join RecipeIngredients ri
on r.RecipeId = ri.RecipeId
join Ingredients i
on ri.IngredientsId = i.IngredientsId
join Measurement m
on ri.MeasurementId = m.MeasurementId
where i.Ingredient = 'sugar'
/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;
-- SM Sorry I made a mistake last time. You need to use getdate() for some datediff()
with x as(
	select AvgTimePublished = AVG(DATEDIFF(hour, r.DateDrafted, r.DatePublished))
	from Recipe r
)
select un.FirstName, un.LastName, EmailAddress = CONCAT(SUBSTRING(un.FirstName, 1, 1), un.LastName, '@heartyhearth.com'), 
	Alert = CONCAT('Your recipe ', r.RecipeName, ' is sitting in draft for ', DATEDIFF(hour, r.DateDrafted, GETDATE()), ' hours. That is ', DATEDIFF(hour, r.DateDrafted, GETDATE()) - x.AvgTimePublished, ' hours more than the average ', x.AvgTimePublished, ' hours all other recipes took to be published.')
from users un
join Recipe r
on un.UsersId = r.UsersId
join x
on x.AvgTimePublished < DATEDIFF(hour, r.DateDrafted, GETDATE())
where r.RecipeStatus = 'Drafted'
/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and recieve a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
;
-- SM This doesnt round up. Use convert() to decimal()
with x as(
	select NumOfBooks = COUNT(c.CookbookName), AvgPrice =  convert(decimal(4,2),AVG(c.Price)), TotalPrice =  SUM(c.Price) - SUM(c.Price) * 25 / 100
	from Cookbook c
)
select EmailBody = concat('Order cookbooks from HeartyHearth.com! We have ', x.NumOfBooks, ' books for sale, average price is ', x.AvgPrice, '. You can order them all and recieve a 25% discount, for a total of ', x.TotalPrice, 
'. Click <a href = "www.heartyhearth.com/order/', newid(), '">here</a> to order.')
from x