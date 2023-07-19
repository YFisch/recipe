-- SM Excellent! See comments,  no need to resubmit.
use HeartyHearthDB
go
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
select ItemName = 'Recipes', Count = COUNT(*)
from Recipe r
union select 'Meals', COUNT(*)
from Meal m
union select 'Cookbooks', COUNT(*)
from Cookbook c
/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
select RecipeName = case when r.RecipeStatus = 'archived' then CONCAT('<span style="color:gray">',r.RecipeName,'</span>') else r.RecipeName end, r.RecipePicture, r.RecipeStatus, DatePublished = isnull(convert(varchar, r.DatePublished, 101), ' '), DateArchived = isnull(convert(varchar, r.DateArchived, 101), ' '), u.UserName, r.Calories, NumOfIngredients = COUNT(ri.IngredientsId)
from users u
join Recipe r
on u.UsersId = r.RecipeId
join RecipeIngredients ri
on r.RecipeId = ri.RecipeId
where r.RecipeStatus in ('published', 'archived')
group by r.RecipeName, r.RecipePicture, r.RecipeStatus, r.DatePublished, r.DateArchived, u.UserName, r.Calories
order by r.RecipeStatus desc
/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
select r.RecipeName, r.RecipePicture, r.Calories, NumOfIngredients = COUNT(distinct ri.IngredientsId), NumOfSteps = COUNT(distinct rin.Instructions)
from RecipeInstructions rin
join Recipe r
on rin.RecipeId = r.RecipeId
join RecipeIngredients ri
on r.RecipeId = ri.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
group by r.RecipeName, r.RecipePicture, r.Calories

select ListOfIngredients = CONCAT(ri.Quantity, ' ', m.UnitOfMeasure, ' ', i.Ingredient), i.IngredientPicture
from Recipe r
join RecipeIngredients ri
on r.RecipeId = ri.RecipeId
join Ingredients i
on ri.IngredientsId = i.IngredientsId
left join Measurement m
on ri.MeasurementId = m.MeasurementId
where r.RecipeName = 'Chocolate Chip Cookies'
order by ri.IngredientSequence

select ri.Instructions
from Recipe r
join RecipeInstructions ri
on r.RecipeId = ri.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
order by ri.InstructionsSequence
/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
    select m.MealName, un.UserName, NumOfCalories = SUM(r.Calories), NumOfCourses = COUNT(distinct mc.CourseId), NUmOfRecipes = COUNT(r.RecipeName)
    from Users un
    join Meal m
    on un.UsersId = m.UsersId
    join MealCourse mc
    on m.MealId = mc.MealId
    join MealcourseRecipe mcr
    on mc.MealCourseId = mcr.MealcourseId
    join Recipe r
    on mcr.RecipeId = r.RecipeId
    where m.Active = 1
    group by m.MealName, un.UserName
    order by m.MealName
/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
select m.MealName, m.MealPicture, un.UserName, m.Datecreated
from users un
join Meal m
on un.UsersId = m.UsersId
where m.MealName = 'Wish Meal'

-- SM Add column name. Change data that main course should be called main or main course not main dish.
-- Use case in concat() like that you wont need 3 concat()s
select MealRecipeList = 
    CONCAT(case when c.CourseName = 'Main' and mcr.IsMain = 1 then '<b>' end, 
        c.CourseName, case when c.CourseName = 'Main' then 
            case when mcr.IsMain = 1 then ': Main Dish - ' when mcr.IsMain = 0 then ': Side Dish - ' end 
            else ': ' end, 
        r.RecipeName, 
        case when c.CourseName = 'Main' and mcr.IsMain = 1 then '<b>' end)
from Course c
join MealCourse mc
on c.CourseId = mc.CourseId
join MealcourseRecipe mcr
on mc.MealCourseId = mcr.MealcourseId
join Recipe r
on mcr.RecipeId = r.RecipeId
join Meal m
on mc.MealId = m.MealId
where m.MealName = 'Wish Meal'
/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select c.CookbookName, c.CookbookPicture, un.UserName, NumOfRecipes = COUNT(cr.RecipeId)
from Users un
join Cookbook c
on un.UsersId = c.UsersId
join CookbookRecipe cr
on c.CookbookId = cr.CookbookId
where c.Active = 1
group by c.CookbookName, c.CookbookPicture, un.UserName
order by c.CookbookName
/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
select c.CookbookName, c.CookbookPicture, un.UserName, c.DateCreated, c.Price, NumOfRecipes = COUNT(cr.RecipeId)
from users un
join Cookbook c
on un.UsersId = c.UsersId
join CookbookRecipe cr
on c.CookbookId = cr.CookbookId
where c.CookbookName = 'What is Cooking?'
group by c.CookbookName, c.CookbookPicture, un.UserName, c.DateCreated, c.Price

select r.RecipeName, r.RecipePicture, ct.CuisinetypeName, NumOfIngredients = COUNT(distinct ri.IngredientsId), NumOfSteps = COUNT( distinct rin.Instructions)
from CuisineType ct
join Recipe r
on ct.CuisineTypeId = r.CuisinetypeId
join CookbookRecipe cr
on r.RecipeId = cr.RecipeId
join Cookbook c
on c.CookbookId = cr.CookbookId
join RecipeIngredients ri
on r.RecipeId = ri.RecipeId
join RecipeInstructions rin
on r.RecipeId = rin.RecipeId
where c.CookbookName = 'What is Cooking?' 
group by r.RecipeName, r.RecipePicture, ct.CuisinetypeName, cr.CookbookRecipeSequence
order by cr.CookbookRecipeSequence
/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/
-- SM You're repeating same recipe names multiple times. And use len() as last argument in substring() instead of literal value.
select distinct ReversedRecipeName = concat(UPPER(SUBSTRING(REVERSE(r.RecipeName),1,1)), LOWER(SUBSTRING(REVERSE(r.RecipeName),2,LEN(r.RecipeName)))), 
ReversedRecipeNamePicture = TRANSLATE(CONCAT('Recipe', '-',concat(UPPER(SUBSTRING(REVERSE(r.RecipeName),1,1)), LOWER(SUBSTRING(REVERSE(r.RecipeName),2,LEN(r.RecipeName)))),'.jpg.'),' ','-')
from Recipe r
join CookbookRecipe cr
on r.RecipeId = cr.RecipeId

;
with x as (
    select SpoofStepList = MAX(ri.InstructionsSequence), ri.RecipeId
    from RecipeInstructions ri
    group by ri.RecipeId
)
select SpoofStepList = ri.Instructions
from RecipeInstructions ri
join x
on ri.RecipeId = x.RecipeId
where ri.InstructionsSequence = x.SpoofStepList
/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/
select NumOfRecipes = COUNT(r.RecipeId), un.FirstName, un.LastName, RecipeStatus = isnull(r.RecipeStatus, '')
from users un
left join Recipe r
on un.UsersId = r.UsersId
group by r.RecipeStatus, un.FirstName, un.LastName
order by un.FirstName

select NumOfRecipes = COUNT(r.RecipeId), AvgDaysToGetPublished = isnull(AVG(DATEDIFF(day, r.DateDrafted, r.DatePublished)), ''), un.FirstName, un.LastName
from users un
left join Recipe r
on un.UsersId = r.UsersId
group by un.FirstName, un.LastName

select un.FirstName, un.LastName, NumOfMeals = COUNT(m.MealId), TotalActiveMeals = SUM(case when m.Active = 1 then 1 else 0 end), TotalInactiveMeals = SUM(case when m.Active = 0 then 1 else 0 end)
from users un
left join Meal m
on un.UsersId = m.UsersId
group by un.FirstName, un.LastName

select un.FirstName, un.LastName, NumOfCookbooks = COUNT(c.CookbookId), TotalActiveCookbooks = SUM(case when c.Active = 1 then 1 else 0 end), TotalInactiveCookbooks = SUM(case when c.Active = 0 then 1 else 0 end)
from users un
left join Cookbook c
on un.UsersId = c.UsersId
group by un.FirstName, un.LastName

select r.RecipeId, r.RecipeName, r.RecipePicture, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, DaysTookToGetArchived = DATEDIFF(DAY, r.DateDrafted, r.DateArchived)
from Recipe r
where r.DatePublished is null
and r.DateArchived is not null
/*
For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
    
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: For the number of recipes, use count of records that have a staffid or CTE.
*/
;
with x as (
    select un.UsersId
    from users un
    where un.UserName = 'FloraGross'
)
select ItemName = 'Recipes', Count = COUNT(*)
from Recipe r
join x
on r.UsersId = x.UsersId
union select 'Meals', COUNT(*)
from Meal m
join x
on m.UsersId = x.UsersId
union select 'Cookbooks', COUNT(*)
from Cookbook c
join x
on c.UsersId = x.UsersId

-- SM Tip: Use status column. Dates will always be in order. And split it in multiple lines
select r.RecipeName, r.RecipeStatus, 
HoursBetweenLastAndCurrentStatus = DATEDIFF(hour, case 
    when r.RecipeStatus = 'published' then r.DateDrafted 
    when r.RecipeStatus = 'archived' then 
-- SM Tip: No need for this case. Use isnull()
        case when  r.DatePublished is null then r.DateDrafted else r.DatePublished end end, 
case when r.RecipeStatus = 'published' then r.DatePublished 
    when r.RecipeStatus = 'archived' then r.DateArchived end)
from Users un
join Recipe r
on un.UsersId = r.UsersId
where un.UserName = 'FloraGross'
and r.RecipeStatus <> 'Drafted'

;
-- SM This returnes all cuisines. But the number of recipes is the same if that user created more than one in one cuisine and one in another it will return 2 for both.
-- You can prove it by changing the username to AvaMedrano that created 2 american recipes and 1 french, but results is 2 for both.
with x as(
    select ct.CuisinetypeName, NumOfRecipes = COUNT(r.RecipeId)
    from CuisineType ct
    left join Recipe r
    on ct.CuisineTypeId = r.CuisinetypeId
    join Users un
    on r.UsersId = un.UsersId
    where un.UserName = 'FloraGross'
    group by ct.CuisinetypeName
)
select ct.CuisinetypeName, NumOfRecipes = COUNT(x.NumOfRecipes)
from CuisineType ct
left join Recipe r
on ct.CuisineTypeId = r.CuisinetypeId
left join X
on x.CuisinetypeName = ct.CuisinetypeName
group by ct.CuisinetypeName

-- SM This is one way to do it. See it returns right results even for AvaMedrano
;with x as(
    select c.CuisinetypeName, NumOfRecipes = count(case when s.UsersId is not null then 1 end)
    from CuisineType C 
    left join recipe r 
    on c.CuisineTypeId = r.CuisinetypeId
    left join users s
    on r.UsersId = s.UsersId
    where s.Username = 'AvaMedrano'
    group by c.CuisineTypeName, s.Username
)
select c.CuisinetypeName, NumOfRecipes = isnull(x.NumOfRecipes,0)
from CuisineType c
left join x
on x.CuisinetypeName = c.CuisinetypeName