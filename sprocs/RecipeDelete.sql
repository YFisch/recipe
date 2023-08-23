create or alter procedure dbo.RecipeDelete(@RecipeId int, @Message varchar (500) = '' output)
as 
begin
	declare @return int = 0
	if exists(select * from Recipe r where r.RecipeId = @RecipeId and (DATEDIFF(day, r.DateArchived, GETDATE()) <= 30 or r.RecipeStatus = 'Published'))
		begin 
		select @return = 1, @Message = 'cannot delete recipe that is not drafted or archived for over 30 days'
			goto finished
		end
	
	begin try
		begin tran
		delete RecipeIngredients where RecipeId = @RecipeId
		delete RecipeInstructions where RecipeId = @RecipeId
		delete CookbookRecipe where RecipeId = @RecipeId
		delete MealcourseRecipe where RecipeId = @RecipeId
		delete Recipe where RecipeId = @RecipeId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	finished:
	return @return
end
go

/*
set nocount on

declare @RecipeId int

select top 1 @RecipeId  = r.RecipeId
from Recipe r
where DATEDIFF(day, r.DateArchived, GETDATE()) <= 30 
or r.RecipeStatus <> 'Drafted'


select 'Recipe', r.RecipeId, r.RecipeName from Recipe r where r.RecipeId = @RecipeId

declare @return int, @message varchar(500)
exec @return = RecipeDelete @RecipeId = @RecipeId, @message = @message output

select @return, @message

select 'Recipe', r.RecipeId, r.RecipeName from Recipe r where r.RecipeId = @RecipeId
*/