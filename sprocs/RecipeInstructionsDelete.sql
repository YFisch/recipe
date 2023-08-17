create or alter proc dbo.RecipeInstructionsDelete(
	@RecipeInstructionsId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int =0

	select @RecipeInstructionsId = ISNULL(@RecipeInstructionsId, 0)

	delete RecipeInstructions where RecipeInstructionsId = @RecipeInstructionsId

	return @return
end
go