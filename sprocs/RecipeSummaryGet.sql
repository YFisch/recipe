create or alter proc dbo.RecipeSummaryGet(
	@RecipeId int = 0,
	@All bit = 0
)
as
begin 
	select r.RecipeId, r.UsersId, r.RecipeName, r.RecipeStatus, Users = CONCAT(u.FirstName, ' ', u.LastName), r.Calories, Users = COUNT(ri.RecipeId), r.RecipePicture, r.Vegan
	from Recipe r
	join users u
	on u.UsersId = r.UsersId
	left join RecipeIngredients ri
	on r.RecipeId = ri.RecipeId
	where r.RecipeId = @RecipeId
	or @All = 1
	group by r.RecipeId, r.UsersId, r.RecipeName, r.RecipeStatus, u.FirstName, u.LastName, r.Calories, r.RecipePicture, r.Vegan
	order by r.RecipeStatus desc, r.RecipeName
end
go

--exec RecipeSummaryGet @All = 1