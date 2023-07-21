
with x as(
    select UserName = 'AvaMedrano', CuisineTypeName = 'American', RecipeName = 'Battered Cheese Sticks', Calories = 123, DateDrafted = '07/21/2023', DatePublished = null, DateArchived = null
    union select 'StephanieGriffin', 'French', '360-Minute Steak', 455, '05/30/2020', '06/22/2020', null
    union select 'MercyMoss', 'English', 'Sweet and Salty Flowers', 233, '09/13/2018', '09/23/2018', '07/06/2021'
    union select 'AvaMedrano', 'American', 'Sweet Chili Salmon Cubes', 365, '02/22/2023', null, null
    union select 'FloraGross', 'Mexican', 'Mexican Hot Chocolate', 555, '10/20/2020', '10/20/2021', null
)
insert Recipe(UsersId, CuisineTypeId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
select un.UsersId, ct.CuisineTypeId, x.RecipeName, x.Calories, x.Datedrafted, x.DatePublished, x.DateArchived
from x
join Users un
on x.UserName = un.UserName
join CuisineType ct
on x.CuisineTypeName = ct.CuisinetypeName