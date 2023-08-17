create or alter proc dbo.RecipeIngredientsUpdate(
	@RecipeIngredientsId int = 0,
	@RecipeId int,
	@IngredientsId int,
	@MeasurementId int,
	@Quantity int,
	@IngredientSequence int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeIngredientsId = ISNULL(@RecipeIngredientsId, 0)

	if @RecipeIngredientsId = 0
	begin
		insert RecipeIngredients(RecipeId, IngredientsId, MeasurementId, Quantity, IngredientSequence)
		values(@RecipeId, @IngredientsId, @MeasurementId, @Quantity, @IngredientSequence)

		select @RecipeIngredientsId = SCOPE_IDENTITY()
	end
	else
	begin
		update RecipeIngredients
		set
			RecipeId = @RecipeId,
			IngredientsId = @IngredientsId,
			MeasurementId = @MeasurementId,
			Quantity = @Quantity,
			IngredientSequence = @IngredientSequence
		where RecipeIngredientsId = @RecipeIngredientsId
	end

	return @return
end
go