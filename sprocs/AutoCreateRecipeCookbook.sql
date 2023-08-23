create or alter proc dbo.AutoCreateRecipeCookbook(
	@CookbookId int = null output,
	@UsersId int,
	@Message varchar(500) = '' output
)
as
begin
	
	declare @return int = 0,
			@CookbookName varchar (500) ,
			@Price decimal(6, 2),
			@DateCreated date,
			@Active bit

	if exists(select * from users u left join Recipe r on u.UsersId = r.UsersId where r.RecipeId is null and u.UsersId = @UsersId)
	begin 
	select @return = 1, @Message = 'cannot auto create a cookbook if the chosen user has no recipes'
		goto finished
	end
	
	;with x as(
	select CookbookPrice = COUNT(r.RecipeId) * 1.33, u.UserName
	from users u
	join recipe r
	on u.UsersId = r.UsersId
	where u.UsersId = @UsersId
	group by u.UserName
	)
	select @CookbookName = CONCAT('Recipes by ', u.FirstName, u.LastName), @Price = x.CookbookPrice, @DateCreated = GETDATE(), @Active =  1
	from x
	join users u
	on u.UserName = x.UserName
	where u.UsersId = @UsersId

	select @CookbookId = ISNULL(@CookbookId, 0)

	insert Cookbook(UsersId, CookbookName, Price, DateCreated, Active)
	values(@UsersId, @CookbookName, @Price, @DateCreated, @Active)
	
	select @CookbookId = SCOPE_IDENTITY()


	insert CookbookRecipe(CookbookId, RecipeId, CookbookRecipeSequence)
	select @CookbookId, r.RecipeId, ROW_NUMBER() over (order by RecipeName)
	from users u
	join Recipe r
	on u.UsersId = r.UsersId
	where u.UsersId = @UsersId
	order by RecipeName
	
	finished:
	return @return
end
go	