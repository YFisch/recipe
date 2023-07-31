create or alter proc dbo.RecipeUpdate(
	@RecipeId int  output,
	@UsersId int ,
	@CuisinetypeId int ,
	@RecipeName varchar (100),
	@Calories int ,
	@DateDrafted datetime ,
	@Message varchar (500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeId = ISNULL(@RecipeId, 0)

	if @RecipeId = 0
	begin
		insert Recipe(UsersId, CuisinetypeId, RecipeName, Calories, DateDrafted)
		values (@UsersId, @CuisinetypeId, @RecipeName, @Calories, @DateDrafted)

			select @RecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update Recipe
		set UsersId = @UsersId, 
			CuisinetypeId = @CuisinetypeId, 
			RecipeName = @RecipeName, 
			Calories = @Calories, 
			DateDrafted = @DateDrafted
		where RecipeId = @RecipeId
	end
end
go