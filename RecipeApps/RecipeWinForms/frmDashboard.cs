namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            btnRecipeList.Click += BtnRecipeList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
            btnMealList.Click += BtnMealList_Click;
            this.Activated += FrmDashboard_Activated;
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gDataOverview.DataSource = DataMaintenance.GetDashboard();
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ((frmMain)this.MdiParent).OpenForm(typeof(frmMealList));
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeList));
        }
    }
}
