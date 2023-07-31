create or alter function dbo.TotalMealCalories(@MealId int)
returns varchar(100)
as
begin
	declare @value varchar(100) = ''

	select @value = SUM(r.Calories)
	from Meal m
	join MealCourse mc
	on m.MealId = mc.MealId
	join MealcourseRecipe mcr
	on mc.MealCourseId = mcr.MealcourseId
	join Recipe r
	on mcr.RecipeId = r.RecipeId
	where m.MealId = @MealId
	group by m.MealName

	return @value

end
go
select m.MealName, TotalCalories = dbo.TotalMealCalories(m.MealId)
from Meal m