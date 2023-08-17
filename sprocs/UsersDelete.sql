create or alter procedure dbo.UsersDelete(
	@UsersId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @UsersId = isnull(@UsersId,0)

	delete cr
	from users u
	join Cookbook c
	on u.UsersId = c.UsersId
	join CookbookRecipe cr
	on c.CookbookId = cr.CookbookId
	where u.UsersId = @UsersId
	
	delete cr
	from Users u
	join Recipe r
	on u.UsersId = r.UsersId
	join CookbookRecipe cr
	on r.RecipeId = cr.RecipeId
	where u.UsersId = @UsersId
	
	delete c
	from users u
	join Cookbook c
	on u.UsersId = c.UsersId
	where u.UsersId = @UsersId
	
	delete mcr
	from users u
	join Meal m
	on u.UsersId = m.UsersId
	join MealCourse mc
	on m.MealId = mc.MealId
	join MealcourseRecipe mcr
	on mc.MealCourseId = mcr.MealcourseId
	where u.UsersId = @UsersId
	
	delete mcr
	from Users u
	join Recipe r
	on u.UsersId = r.UsersId
	join MealcourseRecipe mcr
	on r.RecipeId = mcr.RecipeId
	where u.UsersId = @UsersId
	
	delete mc
	from users u
	join Meal m
	on u.UsersId = m.UsersId
	join MealCourse mc
	on m.MealId = mc.MealId
	where u.UsersId = @UsersId
	
	delete m
	from users u
	join Meal m
	on u.UsersId = m.UsersId
	where u.UsersId = @UsersId
	
	delete ri
	from Users u
	join Recipe r
	on u.UsersId = r.UsersId
	join RecipeInstructions ri
	on r.RecipeId = ri.RecipeId
	where u.UsersId = @UsersId
	
	delete rin
	from Users u
	join Recipe r
	on u.UsersId = r.UsersId
	join RecipeIngredients rin
	on r.RecipeId = rin.RecipeId
	where u.UsersId = @UsersId
		
	delete r
	from Users u
	join Recipe r
	on u.UsersId = r.UsersId
	where u.UsersId = @UsersId
	
	delete u
	from Users u
	where u.UsersId = @UsersId

	return @return
end
go