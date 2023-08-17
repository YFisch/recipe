create or alter proc dbo.RecipeInstructionsUpdate(
	@RecipeInstructionsId int = 0,
	@RecipeId int,
	@Instructions varchar(500),
	@InstructionsSequence int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeInstructionsId = ISNULL(@RecipeInstructionsId, 0)

	if @RecipeInstructionsId = 0
	begin
		insert RecipeInstructions(RecipeId, Instructions, InstructionsSequence)
		values(@RecipeId, @Instructions, @InstructionsSequence)

		select @RecipeInstructionsId = SCOPE_IDENTITY()
	end
	else
	begin
		update RecipeInstructions
		set
			RecipeId = @RecipeId,
			Instructions = @Instructions,
			InstructionsSequence = @InstructionsSequence
		where RecipeInstructionsId = @RecipeInstructionsId
	end

	return @return
end
go