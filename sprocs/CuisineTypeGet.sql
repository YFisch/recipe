create or alter procedure CuisineTypeGet(
	@IngredientsId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0
)
as
begin 
	select @IncludeBlank = ISNULL(@IncludeBlank, 0)

	select ct.CuisineTypeId, ct.CuisinetypeName
	from CuisineType ct
	where ct.CuisineTypeId = @IngredientsId
	or @All = 1
	union select 0, ''
	where @IncludeBlank = 1
	order by ct.CuisinetypeName
end
go

/*
exec IngredientsGet

exec IngredientsGet @All = 1

declare @Id int

select top 1 @Id = ct.IngredientsId from Ingredients ct

exec IngredientsGet @IngredientsId  = @Id

exec IngredientsGet @IngredientsName = ''

exec IngredientsGet @IngredientsName = null

exec IngredientsGet @IngredientsName = 'c'
*/
