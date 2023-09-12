create or alter procedure dbo.IngredientsGet(
	@IngredientsId int = 0,
	@Ingredient varchar(35) = '',
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @IngredientsId = isnull(@IngredientsId,0), @Ingredient = nullif(@Ingredient, '')

	select i.IngredientsId, i.Ingredient
	from Ingredients i
	where IngredientsId = @IngredientsId
	or i.Ingredient like '%' + @Ingredient + '%'
	or @All = 1
	union select 0, ''
	where @IncludeBlank = 1

	return @return
end
go