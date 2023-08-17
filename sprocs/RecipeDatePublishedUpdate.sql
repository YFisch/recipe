Create or alter proc dbo.RecipeDatePublishedUpdate(
	@RecipeId int  output,
	@DatePublished Date, 
	@Message varchar (500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeId = ISNULL(@RecipeId, 0), @DatePublished = GETDATE()

	if @RecipeId = 0
	begin
		insert Recipe(DatePublished)
		values (@DatePublished)
	
			select @RecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update Recipe
		set  
			DatePublished = @DatePublished
		where RecipeId = @RecipeId
	end
end
go