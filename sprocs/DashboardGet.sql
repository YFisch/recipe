create or alter proc dbo.DashboardGet(
	@Message varchar (500) = '' output
)
as
begin 
	select Type = 'Recipes', Number = COUNT(r.RecipeId)
	from Recipe r
	union select 'Meals', COUNT(m.MealId)
	from Meal m
	union select 'Cookbooks', COUNT(c.CookbookId)
	from Cookbook c
	order by Type desc
end