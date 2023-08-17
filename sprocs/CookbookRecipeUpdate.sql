create or alter proc dbo.CookbookRecipeUpdate(
	@CookbookRecipeId int = 0,
	@RecipeId int,
	@CookbookId int,
	@CookbookRecipeSequence int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CookbookRecipeId = ISNULL(@CookbookRecipeId, 0)

	if @CookbookRecipeId = 0
	begin
		insert CookbookRecipe(RecipeId, CookbookId, CookbookRecipeSequence)
		values(@RecipeId, @CookbookId, @CookbookRecipeSequence)

		select @CookbookRecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update CookbookRecipe
		set
			RecipeId = @RecipeId,
			CookbookId = @CookbookId,
			@CookbookRecipeSequence = @CookbookRecipeSequence
		where CookbookRecipeId = @CookbookRecipeId
	end

	return @return
end
go