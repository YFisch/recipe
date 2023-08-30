-- SM Excellent! See comments no need to resubmit.
use HeartyHearthDB
go
drop table if exists CookbookRecipe
drop table if exists Cookbook
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists Meal
drop table if exists Course
drop table if exists RecipeInstructions
drop table if exists RecipeIngredients
drop table if exists Recipe
drop table if exists Measurement
drop table if exists Ingredients
drop table if exists CuisineType
drop table if exists Users

create table dbo.users(
    UsersId int not null identity primary key,
    FirstName varchar (100) not null constraint ck_Users_first_name_cannot_be_blank check(FirstName <> ''),
    LastName varchar (100) not null constraint ck_Users_last_name_cannot_be_blank check(LastName <> ''),
    UserName varchar (100) not null
        constraint ck_Users_user_name_cannot_be_blank check(UserName <> '')
        constraint u_Users_UserName unique
)
go
create table dbo.CuisineType(
    CuisineTypeId int not null identity primary key,
    CuisinetypeName varchar (100) not null
        constraint ck_CuisineType_cuisine_type_name_cannot_be_blank check(CuisineTypeName <> '')
        constraint u_CuisineType_CuisineTypeName unique
)
go
create table dbo.Ingredients(
    IngredientsId int not null identity primary key,
    Ingredient varchar (100) not null
        constraint ck_Ingredients_ingredient_cannot_be_blank check(Ingredient <> '')
        constraint u_Ingredients_Ingredient unique,
    IngredientPicture as TRANSLATE(CONCAT('Ingredient', '-', Ingredient,'.jpg.'),' ','-') PERSISTED
)
go
create table dbo.Measurement(
    MeasurementId int not null identity primary key,
    UnitOfMeasure varchar (100) not null
        constraint ck_Measurement_unit_of_measure_cannot_be_blank check(UnitOfMeasure <> '')
        constraint u_Measurement_UnitOfMeasure unique
)
go
create table dbo.Recipe(
    RecipeId int not null identity primary key,
    UsersId int not null constraint f_Users_Recipe foreign key references users(UsersId),
    CuisinetypeId int not null constraint f_CuisineType_Recipe foreign key references CuisineType(CuisineTypeId),
    RecipeName varchar (100) not null 
        constraint ck_Recipe_recipe_name_cannot_be_blank check(RecipeName <> '')
        constraint u_Recipe_RecipeName unique,
    Calories int not null constraint ck_Recipe_calories_must_be_greater_than_zero check(Calories > 0),
    DateDrafted datetime not null constraint ck_Recipe_date_drafted_cannot_be_future_date check(DateDrafted <= getdate()),
    DatePublished datetime null constraint ck_Recipe_date_Published_cannot_be_future_date check(DatePublished <= getdate()),
    DateArchived datetime null constraint ck_Recipe_date_archived_cannot_be_future_date check(DateArchived<= getdate()),
    RecipeStatus as case 
        when DateArchived is null then
            case
            when  DatePublished is null then 'Drafted'
            else 'Published'
            end
        else 'Archived'
        end PERSISTED,
    RecipePicture as TRANSLATE(CONCAT('Recipe', '_',RecipeName,'.jpg'),' ','_') PERSISTED,
    constraint ck_Recipe_date_published_must_be_between_date_drafted_and_date_archived check(DatePublished between DateDrafted and DateArchived),
    constraint ck_Recipe_date_archived_must_be_greater_than_date_drafted check(DateArchived >= DateDrafted)
)
go
create table dbo.RecipeInstructions(
    RecipeInstructionsId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeInstructions foreign key references Recipe(RecipeId),
    Instructions varchar (500) not null constraint ck_recipeInstructions_instructions_cannot_be_blank check(Instructions <> ''),
    InstructionsSequence int not null constraint ck_RecipeInstructions_instructions_sequence_must_ve_greater_than_zero check(InstructionsSequence > 0),
    constraint u_RecipeInstructions_RecipeId_InstructionsSequence unique(RecipeId, InstructionsSequence) 
)
go
create table dbo.RecipeIngredients(
    RecipeIngredientsId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeIngredients foreign key references Recipe(RecipeId),
    IngredientsId int not null constraint f_Ingredients_RecipeIngredients foreign key references Ingredients(IngredientsId),
    MeasurementId int null constraint f_Measurement_RecipeIngredients foreign key references Measurement(MeasurementId),
    Quantity decimal (6,2) not null constraint ck_RecipeIngredients_quantity_must_be_greater_than_zero check(Quantity > 0),
    IngredientSequence int not null constraint ck_RecipeIngredients_ingredient_sequence_must_be_greater_than_zero check(IngredientSequence > 0),
    constraint u_RecipeIngredients_RecipeId_IngredientsId unique(RecipeId, IngredientsId),
    constraint u_RecipeIngredients_RecipeId_IngredientsSequence unique(RecipeId, IngredientSequence)
)
go
create table dbo.Course(
    CourseId int not null identity primary key,
    CourseName varchar (100) not null 
        constraint ck_Course_course_name_cannot_be_blank check(CourseName <> '')
        constraint u_Course_CourseName unique,
    CourseSequence int not null 
        constraint ck_Course_course_sequence_must_be_greater_than_zero check(CourseSequence > 0)
        constraint u_Course_CourseSequence unique
)
go
create table dbo.Meal(
    MealId int not null identity primary key,
    UsersId int not null constraint f_Users_Meal foreign key references Users(UsersId),
    MealName varchar (100) not null 
        constraint ck_Meal_meal_name_cannot_ba_blank check(MealName <> '')
        constraint u_Meal_MealName unique,
    Datecreated date not null constraint ck_Meal_date_created_cannot_be_future_date check(DateCreated <= getdate()),
-- SM No need for default constraint name. It's only needed when you're adding a new column to table and you want to be able to drop it.
    Active bit not null constraint d_Meal_Active default 1,
    MealPicture as TRANSLATE(CONCAT('Meal', '-',MealName,'.jpg.'),' ','-') PERSISTED
)
go 
create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null constraint f_Course_MealCourse foreign key references Course(courseId),
    constraint u_MealCourse_Mealid_CourseId unique(MealId, courseId)
)
go
create table dbo.MealcourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    MealcourseId int not null constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealcourseId),
    RecipeId int not null constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId),
    IsMain bit not null
    constraint u_MealcourseRecipe_MealcourseId_RecipeId unique(MealcourseId, RecipeId)
)
go
create table dbo.Cookbook(
    CookbookId int not null identity primary key,
    UsersId int not null constraint f_Users_Cookbook foreign key references users(UsersId),
    CookbookName varchar (100) not null
        constraint ck_Cookbook_cookbook_name_cannot_be_blank check(CookbookName <> '')
        constraint u_Cookbook_CookbookName unique,
    Price decimal (6,2) constraint ck_Cookbook_price_must_be_greater_than_zero check(price > 0),
    DateCreated date not null constraint ck_Cookbook_date_created_cannot_be_future_date check(DateCreated <= getdate()),
-- SM No need for default constraint name. It's only needed when you're adding a new column to table and you want to be able to drop it.
    Active bit not null constraint d_Cookbook_Active default 1,
    CookbookPicture as TRANSLATE(CONCAT('Cookbook', '-',CookbookName,'.jpg.'),' ','-') PERSISTED
)
go
create table dbo.CookbookRecipe(
    CookbookRecipeId int not null identity primary key,
    CookbookId int not null constraint f_Cookbook_CookbookRecipe foreign key references Cookbook(CookbookId),
    RecipeId int not null constraint f_Recipe_CookbookRecipe foreign key references Recipe(RecipeId),
    CookbookRecipeSequence int not null constraint ck_CookbookRecipe_cookbook_recipe_sequence_must_be_greater_than_zero check(CookbookRecipeSequence > 0),
    constraint u_CookbookRecipe_CookbookId_RecipeId unique(CookbookId, RecipeId),
    constraint u_CookbookRecipe_CookbookId_CookbookRecipeSequence unique(CookbookId, CookbookRecipeSequence)
)
go