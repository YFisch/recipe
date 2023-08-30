use HeartyHearthDB
go
--select CONCAT('grant execute on ',r.ROUTINE_NAME, ' to approle')
--from INFORMATION_SCHEMA.ROUTINES r
grant execute on RecipeDateDraftedUpdate to approle
grant execute on RecipeDatePublishedUpdate to approle
grant execute on RecipeDateArchivedUpdate to approle
grant execute on CuisineTypeUpdate to approle
grant execute on IngredientsUpdate to approle
grant execute on MeasurementUpdate to approle
grant execute on RecipeIngredientsUpdate to approle
grant execute on CourseUpdate to approle
grant execute on UsersUpdate to approle
grant execute on CookbookGet to approle
grant execute on CourseGet to approle
grant execute on RecipeGet to approle
grant execute on CloneRecipe to approle
grant execute on AutoCreateRecipeCookbook to approle
grant execute on RecipeIngredientsDelete to approle
grant execute on CookbookRecipeGet to approle
grant execute on UsersDelete to approle
grant execute on UsersGet to approle
grant execute on CuisineTypeGet to approle
grant execute on DashboardGet to approle
grant execute on RecipeInstructionsGet to approle
grant execute on CookbookUpdate to approle
grant execute on CuisineTypeDelete to approle
grant execute on RecipeDelete to approle
grant execute on CookbookDelete to approle
grant execute on RecipeInstructionsUpdate to approle
grant execute on CookbookRecipeUpdate to approle
grant execute on IngredientsDelete to approle
grant execute on RecipeUpdate to approle
grant execute on TotalMealCalories to approle
grant execute on RecipeInfo to approle
grant execute on RecipeInstructionsDelete to approle
grant execute on CookbookRecipeDelete to approle
grant execute on CourseDelete to approle
grant execute on RecipeSummaryGet to approle
grant execute on IngredientsGet to approle
grant execute on MeasurementGet to approle
grant execute on TotalMealCourses to approle
grant execute on MealSummaryGet to approle
grant execute on TotalMealRecipes to approle
grant execute on MeasurementDelete to approle
grant execute on RecipeIngredientsGet to approle
grant execute on CookbookSummaryGet to approle