create or alter procedure CuisineTypeGet(@All bit = 0, @CuisineTypeId int = 0, @CuisineTypeName  varchar(100) = '')
as
begin 
	select @CuisineTypeName = nullif(@CuisineTypeName, '')
	select ct.CuisineTypeId, ct.CuisinetypeName
	from CuisineType ct
	where ct.CuisineTypeId = @CuisineTypeId
	or @All = 1
	or ct.CuisinetypeName like '%' + @CuisineTypeName + '%'
	order by ct.CuisinetypeName
end
go

/*
exec CuisineTypeGet

exec CuisineTypeGet @All = 1

declare @Id int

select top 1 @Id = ct.CuisineTypeId from CuisineType ct

exec CuisineTypeGet @CuisineTypeId  = @Id

exec CuisineTypeGet @CuisineTypeName = ''

exec CuisineTypeGet @CuisineTypeName = null

exec CuisineTypeGet @CuisineTypeName = 'c'
*/
