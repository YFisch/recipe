namespace RecipeAppSystem
{

    public class Meals
    {
        public static DataTable GetMealSummary()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("MealSummaryGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
