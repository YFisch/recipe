create or alter function dbo.TotalMealCalories(@MealId int)
returns int
as
begin
	declare @value int = 0

	select @value = SUM(r.Calories)
	from MealCourse mc
	join MealcourseRecipe mcr
	on mc.MealCourseId = mcr.MealcourseId
	join Recipe r
	on mcr.RecipeId = r.RecipeId
	where mc.MealId = @MealId

	return @value

end
go
select m.MealName, TotalCalories = dbo.TotalMealCalories(m.MealId)
from Meal m