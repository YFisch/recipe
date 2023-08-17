namespace RecipeAppSystem
{
    public class RecipeIngredientsAndSteps
    {
        public static DataTable LoadByRecipeid(int recipeid, string proc)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand(proc);
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveTable(DataTable dt, int recipeid, string proc)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, proc);
        }

        public static void Delete(string proc, int tableid, string Parameter)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(proc);
            cmd.Parameters[Parameter].Value = tableid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
