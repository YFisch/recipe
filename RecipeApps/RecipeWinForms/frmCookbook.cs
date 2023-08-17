using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        DataTable dtcookbook = new DataTable();
        DataTable dtcookbookrecipe = new DataTable();
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";
        int cookbookid = 0;
        public frmCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveCookbookRecipe.Click += BtnSaveCookbookRecipe_Click;
            gCookbookRecipes.CellContentClick += GCookbookRecipes_CellContentClick;
            this.FormClosing += FrmCookbook_FormClosing;
        }

        public void LoadForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = Cookbooks.Load(cookbookid);
            bindsource.DataSource = dtcookbook;
            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
            }
            DataTable dtusername = Recipes.GetUserNameList();
            WindowsFormsUtility.SetListBinding(lstUserName, dtusername, dtcookbook, "Users");
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(chbActive, bindsource);
            this.Text = GetCookbookDesc();
            LoadCookbookRecipes();
            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadCookbookRecipes()
        {
            dtcookbookrecipe = CookbookRecipes.LoadByCookbookId(cookbookid);
            gCookbookRecipes.Columns.Clear();
            gCookbookRecipes.DataSource = dtcookbookrecipe;
            WindowsFormsUtility.AddComboBoxToGrid(gCookbookRecipes, DataMaintenance.GetDataList("Recipe", true), "Recipe", "Recipename");
            WindowsFormsUtility.FormatGridForEdit(gCookbookRecipes, "CookbookRecipe");
            WindowsFormsUtility.AddDeleteButtonToGrid(gCookbookRecipes, deletecolname);
            ColumnDisplayOrder("Recipe, CookbookRecipeSequence, Delete", gCookbookRecipes);
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Cookbooks.Save(dtcookbook);
                b = true;
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
                this.Tag = cookbookid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetCookbookDesc();
                LoadForm(cookbookid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this cookbook?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Cookbooks.Delete(dtcookbook);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void SaveCookbookRecipe()
        {
            try
            {
                CookbookRecipes.SaveTable(dtcookbookrecipe, cookbookid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteCookbookRecipe(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gCookbookRecipes, rowIndex, "CookbookRecipeId");
            if (id > 0)
            {
                try
                {
                    CookbookRecipes.Delete(id);
                    LoadCookbookRecipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gCookbookRecipes.Rows.Count)
            {
                try
                {
                    gCookbookRecipes.Rows.RemoveAt(rowIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
        }

        private void ColumnDisplayOrder(string columnList, DataGridView gridView)
        {
            var columnListArray = columnList.Split(',');
            for (var i = 0; i < columnListArray.Length; i++)
            {
                var gridViewColumn = gridView.Columns[columnListArray[i].Trim()];
                if (gridViewColumn != null)
                    gridViewColumn.DisplayIndex = i;
            }
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveCookbookRecipe.Enabled = b;
        }

        private string GetCookbookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "cookbookid");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "Cookbookname");
            }
            return value;

        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void GCookbookRecipes_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteCookbookRecipe(e.RowIndex);
        }

        private void BtnSaveCookbookRecipe_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipe();
        }

        private void FrmCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtcookbook))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }
    }
}
