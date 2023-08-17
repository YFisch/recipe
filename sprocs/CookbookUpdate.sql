create or alter proc dbo.CookbookUpdate(
	@CookbookId int  output,
	@UsersId int ,
	@CookbookName varchar (100),
    @Price int,
    @DateCreated date,
    @Active bit, 
	@Message varchar (500) = '' output
)
as
begin
	declare @return int = 0

	select @CookbookId = ISNULL(@CookbookId, 0), @DateCreated = ISNULL(@DateCreated, GETDATE())

	if @CookbookId = 0
	begin
		insert Cookbook(UsersId, CookbookName, Price, DateCreated, Active)
		values (@UsersId, @CookbookName, @Price, @DateCreated, @Active)

			select @CookbookId = SCOPE_IDENTITY()
	end
	else
	begin
		update Cookbook
		set UsersId = @UsersId, 
			CookbookName = @CookbookName,
			Price = @Price,
			DateCreated = @DateCreated,
			Active = @Active
		where CookbookId = @CookbookId
	end
end
go