create or alter proc dbo.CookbookRecipeGet(
	@CookbookRecipeId int = 0,
	@CookbookId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin 
	declare @return int = 0

	select @All = ISNULL(@All, 0), @CookbookRecipeId = ISNULL(@CookbookRecipeId, 0), @CookbookId = ISNULL(@CookbookId, 0)

	select cr.CookbookRecipeId, cr.CookbookId, cr.RecipeId, cr.CookbookRecipeSequence
	from CookbookRecipe cr
	where cr.CookbookRecipeId = @CookbookRecipeId
	or @All = 1
	or cr.CookbookId = @CookbookId
	order by cr.CookbookRecipeSequence

	return @return
end
go