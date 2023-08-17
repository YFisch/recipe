create or alter procedure dbo.IngredientsDelete(
	@IngredientsId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @IngredientsId = isnull(@IngredientsId,0)
	
	delete  ri
	from Ingredients i
	join RecipeIngredients ri
	on i.IngredientsId = ri.IngredientsId
	where i.IngredientsId = @IngredientsId

	delete r
	from Ingredients i
	join RecipeIngredients ri
	on i.IngredientsId = ri.IngredientsId
	join Recipe r
	on ri.RecipeId = r.RecipeId
	where i.IngredientsId = @IngredientsId
	
	delete i
	from Ingredients i
	where i.IngredientsId = @IngredientsId

	return @return
end
go