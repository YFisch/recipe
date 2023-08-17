create or alter proc dbo.RecipeUpdate(
	@RecipeId int  output,
	@UsersId int ,
	@CuisineTypeId int ,
	@RecipeName varchar (100),
	@Calories int ,
	@DateDrafted date,
	@Message varchar (500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeId = ISNULL(@RecipeId, 0), @DateDrafted = ISNULL(@DateDrafted, GETDATE())

	if @RecipeId = 0
	begin
		insert Recipe(UsersId, CuisinetypeId, RecipeName, Calories, DateDrafted)
		values (@UsersId, @CuisineTypeId, @RecipeName, @Calories, @DateDrafted)

			select @RecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update Recipe
		set UsersId = @UsersId, 
			CuisinetypeId = @CuisineTypeId, 
			RecipeName = @RecipeName, 
			Calories = @Calories
		where RecipeId = @RecipeId
	end
end
go