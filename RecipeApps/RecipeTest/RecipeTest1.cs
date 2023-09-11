using System.Configuration;

namespace RecipeTest
{
    public class RecipeTest
    {
        string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string testconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(testconnstring, true);
        }

        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new();
            DBManager.SetConnectionString(testconnstring, false);
            dt = SQLUtility.GetDataTable(sql);
            DBManager.SetConnectionString(connstring, false);
            return dt;
        }

        private int GetFirstColumnFirstRowValue(string sql)
        {
            int n = 0;
            DBManager.SetConnectionString(testconnstring, false);
            n = SQLUtility.GetFirstColumnFirstRowValue(sql);
            DBManager.SetConnectionString(connstring, false);
            return n;
        }

        [Test]
        [TestCase("test", "2023-03-03")]
        public void InsertNewRecipe(string recipename, DateTime datedrafted)
        {
            DataTable dt = GetDataTable("select * from Recipe where RecipeId = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int usersid = GetFirstColumnFirstRowValue("select top 1 Usersid from Users");
            int cuisineid = GetFirstColumnFirstRowValue("select top 1 CuisineTypeid from CuisineType");
            Assume.That(usersid > 0, "can't run test, no users in the db");
            Assume.That(cuisineid > 0, "can't run test, no Cuisines in the db");

            int maxcalories = GetFirstColumnFirstRowValue("select max(calories) from recipe");
            maxcalories = maxcalories + 5;

            TestContext.WriteLine("insert recipe with max calories = " + maxcalories);

            r["UsersId"] = usersid;
            r["CuisineTypeId"] = cuisineid;
            r["RecipeName"] = recipename + " " + DateTime.Now;
            r["Calories"] = maxcalories;
            r["DateDrafted"] = datedrafted;
            bizRecipe recipe = new();
            recipe.Save(dt);

            int newid = GetFirstColumnFirstRowValue("select * from recipe where  calories = " + maxcalories);
            int pkid = 0;
            if (r["RecipeId"] != DBNull.Value)
            {
                pkid = (int)r["RecipeId"];
            }

            Assert.IsTrue(newid > 0, "Recipe with maxcalories = " + maxcalories + "is not found in DB");
            Assert.IsTrue(pkid > 0, "Primary key not updated in datatable");
            TestContext.WriteLine("recipe with " + maxcalories + " is found in db with pk value = " + newid);
            TestContext.WriteLine("new primary key = " + pkid);
        }

        [Test]
        public void ChangeExistingRecipeCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No Recipes in DB, can't run test");
            int calories = GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("calories for recipeid " + recipeid + " is " + calories);
            calories = calories + 1;
            TestContext.WriteLine("change calories to " + calories);

            DataTable dt = Recipes.Load(recipeid);
            dt.Rows[0]["calories"] = calories;
            Recipes.Save(dt);

            int newcalories = GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcalories == calories, "calories for recipe (" + recipeid + ") = " + newcalories);
            TestContext.WriteLine("calories for recipe (" + recipeid + ") = " + newcalories);

        }

        [Test]
        public void ChangeExistingRecipeName()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No Recipes in DB, can't run test");
            string recipename = GetFirstColumnFirstRowValueAsString("select recipeName from recipe where recipeid = " + recipeid.ToString());
            TestContext.WriteLine("recipename for recipeid " + recipeid + " is " + recipename);
            recipename = recipename + " Test";
            TestContext.WriteLine("change recipename to " + recipename);

            DataTable dt = Recipes.Load(recipeid);
            dt.Rows[0]["recipename"] = recipename;
            Recipes.Save(dt);

            string newrecipename = GetFirstColumnFirstRowValueAsString("select recipename from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newrecipename == recipename, "recipename for recipe (" + recipeid + ") = " + newrecipename);
            TestContext.WriteLine("recipename for recipe (" + recipeid + ") = " + newrecipename);
        }


        [Test]
        public void ChangeExistingRecipeToInvalidRecipeName1()
        {
            int recipeid = GetExistingRecipeId();
            string recipename = "";
            Assume.That(recipeid > 0, "No presidents in DB, can't run test");
            recipename = GetFirstColumnFirstRowValueAsString("select recipename from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("recipename for recipeid " + recipeid + " is " + recipename);
            recipename = "";
            TestContext.WriteLine("change recipename to " + recipename + " (blank)");

            DataTable dt = Recipes.Load(recipeid);
            dt.Rows[0]["recipename"] = recipename;

            Exception ex = Assert.Throws<Exception>(() => Recipes.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeExistingPresidentToInvalidRecipeName2()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No Recipes in DB, can't run test");
            string recipename = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid <> " + recipeid);
            string currentrecipename = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid = " + recipeid);
            Assume.That(recipename != "", "Cannot run test because there is no other president record in the table");
            TestContext.WriteLine("Change recipeid " + recipeid + " recipename from " + currentrecipename + " recipename to " + recipename + " wich belongs to a different recipe");

            DataTable dt = Recipes.Load(recipeid);
            dt.Rows[0]["RecipeName"] = recipename;

            Exception ex = Assert.Throws<Exception>(() => Recipes.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = GetDataTable("select top 1 r.RecipeId, r.RecipeName, r.RecipeStatus from Recipe r left join RecipeInstructions ri on r.RecipeId  = ri.RecipeId where ri.RecipeId is null");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"] + " " + dt.Rows[0]["RecipeStatus"];
            }
            Assume.That(recipeid > 0, "No recipes in DB without related records, can't run test");
            TestContext.WriteLine("existing recipe without related records, with  id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            bizRecipe recipe = new();
            recipe.Delete(dt);
            DataTable dtafterdelete = GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in db");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }

        [Test]
        public void DeleteRecipeWithRecipeInstructionsThatIsPublishedOrArchivedForLessThanThirtyDays()
        {
            string sql = @"
                select top 1 r.RecipeId, r.Recipename, r.RecipeStatus
                from Recipe r
                join RecipeInstructions ri
                on r.RecipeId = ri.RecipeId
                where DATEDIFF(day, r.DateArchived, GETDATE()) <= 30 
                or r.RecipeStatus <> 'Drafted'
                ";
            DataTable dt = GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"] + " " + dt.Rows[0]["Recipestatus"];
            }
            Assume.That(recipeid > 0, "No recipes that is published or archived for less than thirty days with recipe instructions in DB, can't run test");
            TestContext.WriteLine("existing recipe that is published or archived for less than thirty days with recipe instructions, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app cannot delete " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipes.Delete(dt));

            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            bizRecipe recipe = new();
            DataTable dt = recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, loadedid + "<>" + recipeid);
            TestContext.WriteLine("Loaded recipe " + recipeid);
        }


        [Test]
        public void SearchRecipes()
        {
            string criteria = "a";
            int num = GetFirstColumnFirstRowValue("select total = count(*) from recipe where recipename like '%" + criteria + "%'");
            TestContext.WriteLine(num + " recipes that match " + criteria);
            TestContext.WriteLine("Ensure that recipes search returns " + num + " rows ");

            DataTable dt = Recipes.SearchRecipes(criteria);
            int results = dt.Rows.Count;

            Assert.IsTrue(results == num, "Result of recipe search does not match number of recipes, " + results + " <> " + num);
            TestContext.WriteLine("Number of rows returned by recipe search is " + results);
        }


        [Test]
        public void GetListOfCuisineType()
        {
            int cuisinecount = GetFirstColumnFirstRowValue("select total = count(*) from CuisineType");
            TestContext.WriteLine("Num of cuisine in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + cuisinecount);

            DataTable dt = Recipes.GetCuisineTypeList();

            Assert.IsTrue(dt.Rows.Count == cuisinecount, "num rows returned by app (" + dt.Rows.Count + ") <> " + cuisinecount);

            TestContext.WriteLine("Number of rows in cuisine return by app = " + dt.Rows.Count);
        }

        [Test]
        public void GetListOfUsers()
        {
            int userscount = GetFirstColumnFirstRowValue("select total = count(*) from Users");
            TestContext.WriteLine("Num of users in DB = " + userscount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + userscount);

            DataTable dt = Recipes.GetUserNameList();

            Assert.IsTrue(dt.Rows.Count == userscount, "num rows returned by app (" + dt.Rows.Count + ") <> " + userscount);

            TestContext.WriteLine("Number of rows in users return by app = " + dt.Rows.Count);
        }

      
        private int GetExistingRecipeId()
        {
            return GetFirstColumnFirstRowValue("select top 1 RecipeId from Recipe");
        }

        private string GetFirstColumnFirstRowValueAsString(string sql)
        {
            string s = "";
            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {
                    s = dt.Rows[0][0].ToString();
                }
            }
            return s;
        }
    }
}