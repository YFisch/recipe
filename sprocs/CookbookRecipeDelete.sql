create or alter proc dbo.CookbookRecipeDelete(
	@CookbookRecipeId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int =0

	select @CookbookRecipeId = ISNULL(@CookbookRecipeId, 0)

	delete CookbookRecipe where CookbookRecipeId = @CookbookRecipeId

	return @return
end
go