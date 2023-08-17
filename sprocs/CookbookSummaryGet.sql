create or alter proc dbo.CookbookSummaryGet(
	@CookbookId int = 0,
	@All bit = 0
)
as
begin 
	select c.CookbookId, c.CookbookName, Users = CONCAT(u.FirstName, ' ', u.LastName), NumRecipes = COUNT(cr.CookbookRecipeId), c.Price
	from Cookbook c
	join users u
	on u.UsersId = c.UsersId
	left join CookbookRecipe cr
	on c.CookbookId = cr.CookbookId
	where c.CookbookId = @CookbookId
	or @All = 1
	group by c.CookbookId, c.CookbookName, u.FirstName, u.LastName, c.Price
	order by c.CookbookName
end
go