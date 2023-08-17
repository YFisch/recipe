create or alter function dbo.RecipeInfo(@RecipeId int)
returns varchar(250)
as
begin
	declare @value varchar(250) = ''

	select @value = CONCAT(r.RecipeName, ' (', ct.IngredientsName, ') has ', COUNT(distinct rin.RecipeIngredientsId), ' ingredients and ', COUNT(distinct ri.RecipeInstructionsId), ' steps.')
	from Ingredients ct
	join Recipe r
	on ct.IngredientsId = r.IngredientsId
	join RecipeInstructions ri
	on r.RecipeId = ri.RecipeId
	join RecipeIngredients rin 
	on r.RecipeId = rin.RecipeId
	where r.RecipeId = @RecipeId
	group by r.RecipeName, ct.IngredientsName

	return @value
end
go
select RecipeInfo = dbo.RecipeInfo(r.RecipeId)
from Recipe r