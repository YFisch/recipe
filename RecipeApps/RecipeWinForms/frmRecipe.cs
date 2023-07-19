using CPUFramework;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select r.*, u.UserName, ct.CuisineTypeName from Recipe r join users u on r.UsersId = u.UsersId join CuisineType ct on r.CuisinetypeId = ct.CuisineTypeId where r.RecipeId = " + recipeid.ToString();
            DataTable dt = SQLUtility.GetDatatable(sql);
            txtRecipe.DataBindings.Add("Text", dt, "RecipeName");
            txtUserName.DataBindings.Add("Text", dt, "UserName");
            txtCuisineName.DataBindings.Add("Text", dt, "CuisineTypeName");
            txtCalories.DataBindings.Add("Text", dt, "Calories");
            txtDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            txtRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            txtRecipePicture.DataBindings.Add("Text", dt, "RecipePicture");
            this.Show();
        }
    }
}
