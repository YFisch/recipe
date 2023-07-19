-- SM Excellent sketch! See comments, I believe you can start creating the DB. Good Luck!!!
/*
UserName
    Firstname varchar (100)
    LastName varchar (100)
    UserName varchar (100) unique

CuisineType
    CuisineTypeName varchar (100) unique

Ingredients
    Ingredient varchar (100) unique
    IngredientsPicture computed

Measurement
    UnitOfMeasure varchar (100) unique

RecipeIngredients
    RecipeId
    IngredientsId
    MeasurementId
    Quantity int
    IngredientsSequence int
        constraint RecipeId and IngredientsId unique
        constraint RecipeId and IngredientsSequence unique

RecipeInstructions
    RecipeId
    Instructions varchar (500)
    InstructionsSequence int
        constraint RecipeId and InstructionsSequence unique

Recipe
    UserId
    CuisineTypeId
    RecipeName varchar (100) unique
    Calories int
    RecipePicture computed
    DateDrafted datetime
    DatePublished datetime
    DateArchived datetime
    RecipeStatus conputed based on latest date
-- SM Excellent! you can do DatePublished between DateDrafted and DateArchived instead of first 2 constraints.
        constraint DatePublished between DateDrafted and DateArchived
        constraint DateArchived >= DateDrafted

Course
    CourseName varchar (100) unique
    Sequence unique
Meal
    UserId
    MealName varchar (100) unique
    MealPicture computed
    DateCreated date
    Active bit

Mealcourse
    CourseId
    MealId
        constraint courseId and MealId unique

MealCourseRecipe
    MealCourseId
    RecipeId
    IsMain bit
        constraint MealCourseId and RecipeId unique

Cookbook
    UserId
    CookbookName varchar (100) unique
    Price
    CookbookPicture computed
    Active bit
    DateCreated date
        
CookbookRecipe
    CookbookId
    RecipeId
    CookbookRecipeSequence int
        constraint CookbookId and RecipeId unique
        contsraint CookbookId and CookbookRecipeSequence unique
*/