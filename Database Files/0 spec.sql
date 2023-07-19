/*
Hi, we have a very popular website and as it grows I get more and more problems and I'm looking for help.
We have recipes, meals and cookbooks but we can show the recipes also in a meal or in a cookbook so we have it duplicated so that's the source of our problem.
I need a database so nothing should be duplicated and it should be organized.
we have recipes that have a cuisine type, Ingredients that have a measurement type and an amount and also a sequence of the ingredients. then we have directions and steps for it.
The recipe also has a status if its drafted, published or archived and also the dates and times for it.
Then we have meals that has courses wich has a sequence in the meal and courses have recipes. meals should only have one of each course but each course can have multiple recipes.
Then we have cookbooks that has a name, price and recipes that has a certain sequence how it's presented in the cookbook
We also have pictures for ingredients, recipes, meals, and cookbooks that is named first the name of the type and then the specific name for that type and then .jpg. and we replace the spaces with dashes.

Question: what should be unique?
Answer: name of ingredient, name of recipe, name of meal, name of book

Question: should meals and cookbooks also have status recorded?
Answer: no, we only need to know if it's active or inactive.

Question: do you have staff that are going to use your website?
Answer: yes, we need to know who created what and we call them users so we need to know their first and last names and their username.
*/