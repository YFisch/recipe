Create or alter proc dbo.RecipeDateArchivedUpdate(
	@RecipeId int  output,
	@DateArchived Date, 
	@Message varchar (500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeId = ISNULL(@RecipeId, 0), @DateArchived = GETDATE()

	if @RecipeId = 0
	begin
		insert Recipe(DateArchived)
		values (@DateArchived)
	
			select @RecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update Recipe
		set  
			DateArchived = @DateArchived
		where RecipeId = @RecipeId
	end
end
go