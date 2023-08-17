create or alter procedure UsersGet(
	@UsersId int = 0, 
	@All bit = 0,
	@IncludeBlank bit = 0
)
as
begin 
	select @IncludeBlank = ISNULL(@IncludeBlank, 0)


	select u.UsersId, u.FirstName, u.LastName, u.UserName
	from users u
	where u.UsersId = @UsersId
	or @All = 1
	union select 0, '', '', ''
	where @IncludeBlank = 1
	order by u.UserName
end
go

/*
exec UsersGet

exec UsersGet @All = 1

declare @Id int

select top 1 @Id = u.UsersId from users u

exec UsersGet @UsersId  = @Id

exec UsersGet @Username = ''

exec UsersGet @Username = null

exec UsersGet @Username = 'c'
*/