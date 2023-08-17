create or alter procedure RecipeGet(
	@RecipeId int = 0, 
	@RecipeName varchar(100) = '',
	@All bit = 0,
	@IncludeBlank bit = 0
)
as
begin 
	select @RecipeName = nullif(@RecipeName, '')
	select r.RecipeId, r.UsersId, r.CuisinetypeId, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePicture
	from Recipe r
	where r.RecipeId = @RecipeId
	or @All = 1
	or (r.RecipeName like '%' + @RecipeName + '%')
	union select 0, 0, 0, '', 0, '', '', '', '', ''
	where @IncludeBlank = 1
	order by r.RecipeName
end
go

/*
exec RecipeGet

exec RecipeGet @All = 1

declare @Id int

select top 1 @Id = r.RecipeId from Recipe r

exec RecipeGet @RecipeId  = @Id

exec RecipeGet @Recipename = ''

exec RecipeGet @Recipename = null

exec RecipeGet @Recipename = 'c'
*/