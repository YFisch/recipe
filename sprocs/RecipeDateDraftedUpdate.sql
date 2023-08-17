Create or alter proc dbo.RecipeDateDraftedUpdate(
	@RecipeId int  output,
	@DateDrafted Date, 
	@Message varchar (500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeId = ISNULL(@RecipeId, 0), @DateDrafted = GETDATE()

	if @RecipeId = 0
	begin
		insert Recipe(DateDrafted)
		values (@DateDrafted)
	
			select @RecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update Recipe
		set  
			DateDrafted = @DateDrafted
		where RecipeId = @RecipeId
	end
end
go
