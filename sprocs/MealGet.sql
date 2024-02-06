create or alter procedure MealGet(
	@MealId int = 0, 
	@All bit = 0,
	@IncludeBlank bit = 0
)
as
begin 
	select m.MealId, m.UsersId, m.MealName, m.DateCreated, m.Active
	from Meal m
	where m.MealId = @MealId
	or @All = 1
	union select 0, 0, '', '', ''
	where @IncludeBlank = 1
end
go

exec MealGet @All = 1