using System.Runtime.CompilerServices;

namespace RecipeAppSystem
{
    public class Recipes
    {
        public static DataTable SearchRecipes(string recipe)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@RecipeName", recipe);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetUserNameList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("UsersGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineTypeList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CuisineTypeGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtrecipe)
        {
           if(dtrecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call recipe save method because there are no rows in the table");
            }
            DataRow r = dtrecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }


        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static DataTable GetRecipeSummary()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeSummaryGet");
            SQLUtility.SetParamValue(cmd,"@All", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static int CloneRecipe(int basedrecipeid)
        {
            SqlCommand cmd = new();
            int id = SQLUtility.GetParamValue(cmd, "CloneRecipe", "@RecipeId" ,"@BaseRecipeId", basedrecipeid);
            return id;
        }
    }
}
