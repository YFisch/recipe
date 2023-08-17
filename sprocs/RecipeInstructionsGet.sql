create or alter proc dbo.RecipeInstructionsGet(
	@RecipeInstructionsId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin 
	declare @return int = 0

	select @All = ISNULL(@All, 0), @RecipeInstructionsId = ISNULL(@RecipeInstructionsId, 0), @RecipeId = ISNULL(@RecipeId, 0)

	select ri.RecipeInstructionsId, ri.RecipeId, ri.Instructions, ri.InstructionsSequence
	from RecipeInstructions ri
	where ri.RecipeInstructionsId = @RecipeInstructionsId
	or @All = 1
	or ri.RecipeId = @RecipeId
	order by ri.InstructionsSequence

	return @return
end
go