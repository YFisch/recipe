create or alter procedure UsersGet(@All bit = 0, @UsersId int = 0, @UserName  varchar(100) = '')
as
begin 
	select @UserName = nullif(@UserName, '')
	select u.UsersId, u.FirstName, u.LastName, u.UserName
	from users u
	where u.UsersId = @UsersId
	or @All = 1
	or u.UserName like '%' + @UserName + '%'
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