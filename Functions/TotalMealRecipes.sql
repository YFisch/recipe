create or alter function dbo.TotalMealRecipes(@MealId int)
returns int
as
begin
	declare @value int = 0

	select @value = Count(r.RecipeId)
	from MealCourse mc
	join MealcourseRecipe mcr
	on mc.MealCourseId = mcr.MealcourseId
	join Recipe r
	on mcr.RecipeId = r.RecipeId
	where mc.MealId = @MealId

	return @value

end
go
select m.MealName, TotalRecipes = dbo.TotalMealRecipes(m.MealId)
from Meal m