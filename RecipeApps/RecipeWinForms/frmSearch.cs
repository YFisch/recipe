using CPUFramework;
using System.Data;
using CPUWindowsFormFramework;

namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
            WindowsFormsUtility.FormatGridForSearchResult(gRecipe);
        }

        private void SearchForRecipe(string recipe)
        {
            string sql = "select RecipeId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived, RecipeStatus, RecipePicture from Recipe r where r.RecipeName like '%" + recipe + "%' ";
            DataTable dt = SQLUtility.GetDatatable(sql);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if(rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }    
            
            frmRecipe frm = new frmRecipe();
            frm.ShowForm(id);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipe.Text);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
    }
}
