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
            dtRecipe = Recipes.Load(recipeid);
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtusername = Recipes.GetUserNameList();
            DataTable dtcuisinename = Recipes.GetCuisineTypeList();
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
            Recipes.Save(dtRecipe);
        }

        private void Delete()
        {
            Recipes.Delete(dtRecipe);
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
