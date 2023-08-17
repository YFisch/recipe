create or alter proc dbo.RecipeIngredientsGet(
	@RecipeIngredientsId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin 
	declare @return int = 0

	select @All = ISNULL(@All, 0), @RecipeIngredientsId = ISNULL(@RecipeIngredientsId, 0), @RecipeId = ISNULL(@RecipeId, 0)

	select ri.Quantity, ri.IngredientSequence, ri.RecipeIngredientsId, ri.RecipeId, ri.MeasurementId, ri.IngredientsId
	from RecipeIngredients ri
	where ri.RecipeIngredientsId = @RecipeIngredientsId
	or @All = 1
	or ri.RecipeId = @RecipeId
	order by ri.IngredientSequence

	return @return
end
go