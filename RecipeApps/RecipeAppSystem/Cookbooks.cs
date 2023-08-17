namespace RecipeAppSystem
{
    public class Cookbooks
    {
        public static DataTable GetCookbookSummary()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookSummaryGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable Load(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookGet");
            SQLUtility.SetParamValue(cmd, "@CookbookId", cookbookid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtcookbook)
        {
            if (dtcookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot call cookbook save method because there are no rows in the table");
            }
            DataRow r = dtcookbook.Rows[0];
            SQLUtility.SaveDataRow(r, "CookbookUpdate");            
        }

        public static void Delete(DataTable dtcookbook)
        {
            int id = (int)dtcookbook.Rows[0]["CookbookId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookDelete");
            SQLUtility.SetParamValue(cmd, "@CookbookId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void AutoCreateCookbook(int basedonusersid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("AutoCreateRecipeCookbook");
            SQLUtility.SetParamValue(cmd, "@UsersId", basedonusersid);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
