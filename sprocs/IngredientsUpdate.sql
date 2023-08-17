create or alter procedure dbo.IngredientsUpdate(
		@IngredientsId int  output,
		@Ingredient varchar (100),
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @IngredientsId = isnull(@IngredientsId,0)
	
	if @IngredientsId = 0
	begin
		insert Ingredients(Ingredient)
		values(@Ingredient)

		select @IngredientsId= scope_identity()
	end
	else
	begin
		update Ingredients
		set
			Ingredient = @Ingredient
		where IngredientsId = @IngredientsId
	end
	
	return @return
end
go