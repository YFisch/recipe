create or alter procedure dbo.CourseDelete(
	@CourseId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CourseId = isnull(@CourseId,0)

	delete mcr
	from Course c
	join MealCourse mc
	on mc.CourseId = c.CourseId
	join MealcourseRecipe mcr
	on mc.MealCourseId = mcr.MealcourseId
	where c.CourseId = @CourseId

	delete mc
	from Course c
	join MealCourse mc
	on mc.CourseId = c.CourseId
	where c.CourseId = @CourseId

	delete c
	from Course c
	where c.CourseId = @CourseId

	return @return
end
go