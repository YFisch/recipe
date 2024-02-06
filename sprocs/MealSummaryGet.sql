create or alter proc dbo.MealSummaryGet(
	@MealId int = 0,
	@All bit = 0
)
as
begin 
	select m.MealId, m.MealName, Users = CONCAT(u.FirstName, ' ', u.LastName), NumCalories = dbo.TotalMealCalories(m.MealId), NumCourses = dbo.TotalMealCourses(m.MealId), NumRecipes = dbo.TotalMealRecipes(m.MealId), m.MealDesc
	from Meal m
	join users u
	on u.UsersId = m.UsersId
	join MealCourse mc
	on m.MealId = mc.MealId
	where m.MealId = @MealId
	or @All = 1
	group by m.MealId, m.MealName, u.FirstName, u.LastName, m.MealDesc
	order by m.MealName
end
go

--exec MealSummaryGet @All = 1