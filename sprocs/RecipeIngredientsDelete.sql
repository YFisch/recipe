create or alter proc dbo.RecipeIngredientsDelete(
	@RecipeIngredientsId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int =0

	select @RecipeIngredientsId = ISNULL(@RecipeIngredientsId, 0)

	delete RecipeIngredients where RecipeIngredientsId = @RecipeIngredientsId

	return @return
end
go