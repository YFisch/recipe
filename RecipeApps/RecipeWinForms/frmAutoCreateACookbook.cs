namespace RecipeWinForms
{
    public partial class frmAutoCreateACookbook : Form
    {
        public frmAutoCreateACookbook()
        {
            InitializeComponent();
            BindData();
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }

        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(lstUserName, DataMaintenance.GetDataList("Users", true), null, "Users");
        }

        private void AutoCreateCookbook()
        {
            int basedonid = WindowsFormsUtility.GetIdFromComboBox(lstUserName);
            Cursor = Cursors.WaitCursor;
            try
            {
                Cookbooks.AutoCreateCookbook(basedonid);
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));
                    this.Close();
                }
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


        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            AutoCreateCookbook();
        }
    }
}
