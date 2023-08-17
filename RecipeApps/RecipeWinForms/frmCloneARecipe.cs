namespace RecipeWinForms
{
    public partial class frmCloneARecipe : Form
    {
        public frmCloneARecipe()
        {
            InitializeComponent();
            BindDate();
            btnClone.Click += BtnClone_Click;
        }

        private void BindDate()
        {
            WindowsFormsUtility.SetListBinding(lstRecipeName, DataMaintenance.GetDataList("Recipe", true), null, "Recipe");
        }

        private void CloneRecipe()
        {
            int basedonid = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);
            Cursor = Cursors.WaitCursor;
            try
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), Recipes.CloneRecipe(basedonid));
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneRecipe();
        }
    }
}
