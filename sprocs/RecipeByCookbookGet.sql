create or alter proc dbo.RecipeByCookbookGet(
	@CookbookDesc varchar(500),
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin 
	declare @return int = 0

	select r.RecipeId, r.UsersId, r.CuisineTypeId, r.Recipename, r.RecipeStatus,  Users = CONCAT(u.FirstName, ' ', u.LastName), r.Calories, NumIngredients = COUNT(ri.RecipeId), r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipePicture, r.Vegan, c.CookbookDesc
	from Cookbook c
	join CookbookRecipe cr
	on cr.CookbookId = c.CookbookId
	join Recipe r
	on cr.RecipeId = r.Recipeid
	join users u
	on u.UsersId = r.UsersId
	left join RecipeIngredients ri
	on r.RecipeId = ri.RecipeId
	join CuisineType ct
	on ct.CuisineTypeId = r.CuisinetypeId
	where c.CookbookDesc = @CookbookDesc
	or @All = 1
	or c.CookbookDesc = @CookbookDesc
	group by r.RecipeId, r.UsersId, r.CuisinetypeId, r.RecipeName, r.RecipeStatus, u.FirstName, u.LastName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipePicture, r.Vegan, c.CookBookDesc

	return @return
end
go

--exec RecipeByCookbookGet @CookbookDesc = 'Ess(3)2022-11-22'