create or alter procedure dbo.CuisineTypeDelete(
	@CuisineTypeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CuisineTypeId = isnull(@CuisineTypeId,0)

	delete mcr
	from CuisineType ct
	join Recipe r
	on r.CuisinetypeId = ct.CuisineTypeId
	join MealcourseRecipe mcr
	on r.RecipeId = mcr.RecipeId
	where ct.CuisineTypeId = @CuisineTypeId

	delete cr
	from CuisineType ct
	join Recipe r
	on r.CuisinetypeId = ct.CuisineTypeId
	join CookbookRecipe cr
	on r.RecipeId = cr.RecipeId
	where ct.CuisineTypeId = @CuisineTypeId

	delete ri
	from CuisineType ct
	join Recipe r
	on r.CuisinetypeId = ct.CuisineTypeId
	join RecipeInstructions ri
	on r.RecipeId = ri.RecipeId
	where ct.CuisineTypeId = @CuisineTypeId

	delete ri
	from CuisineType ct
	join Recipe r
	on r.CuisinetypeId = ct.CuisineTypeId
	join RecipeIngredients ri
	on r.RecipeId = ri.RecipeId
	where ct.CuisineTypeId = @CuisineTypeId

	delete r
	from CuisineType ct
	join Recipe r
	on r.CuisinetypeId = ct.CuisineTypeId
	where ct.CuisineTypeId = @CuisineTypeId

	delete ct
	from CuisineType ct
	where ct.CuisineTypeId = @CuisineTypeId

	return @return
end
go