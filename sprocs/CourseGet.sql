create or alter procedure CourseGet(
	@CourseId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0
)
as
begin 
	select @IncludeBlank = ISNULL(@IncludeBlank, 0)

	select c.CourseId, c.CourseName, c.CourseSequence
	from Course c
	where c.CourseId = @CourseId
	or @All = 1
	union select 0, '', 0
	where @IncludeBlank = 1
	order by c.CourseSequence
end
go
