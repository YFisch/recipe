create or alter proc dbo.CloneRecipe(
	@RecipeId int = null output,
	@BaseRecipeId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0,
		@RecipeName varchar(100) ,	
		@UsersId int,
		@CuisineTypeId int,
		@Calories int,
		@DateDrafted date,
		@DatePublished date,
		@DateArchived date

		select @UsersId =  r.UsersId, @CuisineTypeId = r.CuisinetypeId, @RecipeName = CONCAT(r.RecipeName, ' - clone'), @Calories = r.Calories, @DateDrafted = r.DateDrafted, @DatePublished = r.DatePublished, @DateArchived = r.DateArchived
		from Recipe r
		where r.RecipeId = @BaseRecipeId

		select @RecipeId = ISNULL(@RecipeId, 0)

		insert Recipe(UsersId, CuisinetypeId,RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
		values(@UsersId, @CuisineTypeId, @RecipeName, @Calories, @DateDrafted, @DatePublished, @DateArchived)

		select @RecipeId = SCOPE_IDENTITY()
		
		insert RecipeIngredients(RecipeId, IngredientsId, MeasurementId, Quantity, IngredientSequence)
		select @RecipeId, ri.IngredientsId, ri.MeasurementId, ri.Quantity, ri.IngredientSequence
		from RecipeIngredients ri
		where ri.RecipeId = @BaseRecipeId
		
		insert RecipeInstructions(RecipeId, Instructions, InstructionsSequence)
		select @RecipeId, rin.Instructions, rin.InstructionsSequence
		from  RecipeInstructions rin
		where rin.RecipeId = @BaseRecipeId

	return @return
end
go	

