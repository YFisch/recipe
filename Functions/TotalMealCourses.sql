create or alter function dbo.TotalMealCourses(@MealId int)
returns int
as
begin
	declare @value int = 0

	select @value = Count(mc.CourseId)
	from MealCourse mc
	where mc.MealId = @MealId
	return @value

end
go
select m.MealName, TotalCourses = dbo.TotalMealCourses(m.MealId)
from Meal m