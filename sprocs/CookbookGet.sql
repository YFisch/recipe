create or alter procedure CookbookGet(
	@CookbookId int = 0, 
	@All bit = 0,
	@IncludeBlank bit = 0
)
as
begin 
	select c.CookbookId, c.UsersId, c.CookbookName, c.DateCreated, c.Price, c.Active, c.CookbookPicture
	from Cookbook c
	where c.CookbookId = @CookbookId
	or @All = 1
	union select 0, 0, '', '', 0, '', ''
	where @IncludeBlank = 1
end
go