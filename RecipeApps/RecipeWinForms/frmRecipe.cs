using CPUFramework;
using System.Data;
using CPUWindowsFormFramework;
using System.Diagnostics;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtRecipe;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select r.*, u.UserName, ct.CuisineTypeName from Recipe r join users u on r.UsersId = u.UsersId join CuisineType ct on r.CuisinetypeId = ct.CuisineTypeId where r.RecipeId = " + recipeid.ToString();
            dtRecipe = SQLUtility.GetDatatable(sql);
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtusername = SQLUtility.GetDatatable("select UsersId, UserName from Users");
            DataTable dtcuisinename = SQLUtility.GetDatatable("select CuisineTypeId, CuisineTypeName from CuisineType");
            WindowsFormsUtility.SetListBinding(lstUserName, dtusername, dtRecipe, "Users");
            WindowsFormsUtility.SetListBinding(lstCuisineTypeName, dtcuisinename, dtRecipe, "CuisineType");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, dtRecipe);
            WindowsFormsUtility.SetControlBinding(dtpDateDrafted, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, dtRecipe);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, dtRecipe);
            WindowsFormsUtility.SetControlBinding(lblRecipePicture, dtRecipe);
            this.Show();
        }

        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtRecipe);
            DataRow r = dtRecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"Update Recipe set",
                    $"UsersId = '{r["UsersId"]}',",
                    $"CuisineTypeId = '{r["CuisineTypeId"]}',",
                    $"Recipe = '{r["Recipe"]}',",
                    $"Calories = '{r["Calories"]}',",
                    $"DateDrafted = '{r["DateDrafted"]}',",
                    $"DatePublished = '{r["DatePublished"]}',",
                    $"DateArchived = '{r["DateArchived"]}',",
                    $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert Recipe(UsersId, CuisineTypeId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)";
                sql += $"select '{r["UsersId"]}', '{r["CuisineTypeId"]}', '{r["RecipeName"]}', {r["Calories"]}, '{r["DateDrafted"]}', '{r["DatePublished"]}', '{r["DateArchived"]}'";
            }


            Debug.Print("-----------------");

            SQLUtility.ExecuteSQL(sql);
        }

        private void Delete()
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
