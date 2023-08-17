create or alter function dbo.RecipeInfo(@RecipeId int)
returns varchar(250)
as
begin
	declare @value varchar(250) = ''

	select @value = CONCAT(r.RecipeName, ' (', ct.CuisinetypeName, ') has ', COUNT(distinct rin.RecipeIngredientsId), ' ingredients and ', COUNT(distinct ri.RecipeInstructionsId), ' steps.')
	from CuisineType ct
	join Recipe r
	on ct.CuisineTypeId = r.CuisinetypeId
	join RecipeInstructions ri
	on r.RecipeId = ri.RecipeId
	join RecipeIngredients rin 
	on r.RecipeId = rin.RecipeId
	where r.RecipeId = @RecipeId
	group by r.RecipeName, ct.CuisinetypeName

	return @value
end
go
select RecipeInfo = dbo.RecipeInfo(r.RecipeId)
from Recipe r