namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtRecipe = new DataTable();
        DataTable dtRecipeIngredients = new DataTable();
        DataTable dtRecipeSteps = new DataTable();
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";
        int recipeid = 0;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveIngredient.Click += BtnSaveIngredient_Click;
            btnSaveStep.Click += BtnSaveStep_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            gIngredient.CellContentClick += GIngredient_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            this.FormClosing += FrmRecipe_FormClosing;
            this.Activated += FrmRecipe_Activated;
        }

        private void FrmRecipe_Activated(object? sender, EventArgs e)
        {
            LoadForm(recipeid);
        }

        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtRecipe = Recipes.Load(recipeid);
            bindsource.DataSource = dtRecipe;
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtusername = Recipes.GetUserNameList();
            DataTable dtcuisinename = Recipes.GetCuisineTypeList();
            WindowsFormsUtility.SetListBinding(lstUserName, dtusername, dtRecipe, "Users");
            WindowsFormsUtility.SetListBinding(lstCuisineTypeName, dtcuisinename, dtRecipe, "CuisineType");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, bindsource);
            this.Text = GetRecipeDesc();
            LoadRecipeSteps();
            LoadRecipeIngredients();
            SetButtonsEnabledBasedOnNewRecord();
        }
        private void LoadRecipeIngredients()
        {
            dtRecipeIngredients = RecipeIngredientsAndSteps.LoadByRecipeid(recipeid, "RecipeIngredientsGet");
            gIngredient.Columns.Clear();
            gIngredient.DataSource = dtRecipeIngredients;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredient, DataMaintenance.GetDataList("Ingredients", true), "Ingredients", "Ingredient");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredient, DataMaintenance.GetDataList("Measurement", true), "Measurement", "UnitOfMeasure");
            WindowsFormsUtility.FormatGridForEdit(gIngredient, "RecipeIngredients");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredient, deletecolname);
        }

        private void LoadRecipeSteps()
        {
            dtRecipeSteps = RecipeIngredientsAndSteps.LoadByRecipeid(recipeid, "RecipeInstructionsGet");
            gSteps.Columns.Clear();
            gSteps.DataSource = dtRecipeSteps;
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gSteps, "RecipeInstructions");
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipes.Save(dtRecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
                this.Tag = recipeid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetRecipeDesc();
                LoadForm(recipeid);
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
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipes.Delete(dtRecipe);
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

        private void SaveRelatedRecipeRecords(DataTable dt, string proc)
        {
            try
            {
                RecipeIngredientsAndSteps.SaveTable(dt, recipeid, proc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteRelatedRecipeRecords(DataGridView g, int rowindex, string tableid, string proc, string Parameter)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(g, rowindex, tableid);
            if (id > 0)
            {
                try
                {
                    RecipeIngredientsAndSteps.Delete(proc, id, Parameter);
                    LoadRecipeIngredients();
                    LoadRecipeSteps();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < g.Rows.Count)
            {
                try
                {
                    g.Rows.RemoveAt(rowindex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveIngredient.Enabled = b;
            btnSaveStep.Enabled = b;
            btnChangeStatus.Enabled = b;
        }

        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtRecipe, "RecipeName");
            }
            return value;
        }

        private void ShowChangeStatusForm()
        {
            int id = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), id);
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnSaveStep_Click(object? sender, EventArgs e)
        {
            SaveRelatedRecipeRecords(dtRecipeSteps, "RecipeInstructionsUpdate");
        }

        private void BtnSaveIngredient_Click(object? sender, EventArgs e)
        {
            SaveRelatedRecipeRecords(dtRecipeIngredients, "RecipeIngredientsUpdate");
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRelatedRecipeRecords(gSteps, e.RowIndex, "RecipeInstructionsId", "RecipeInstructionsDelete", "@RecipeInstructionsId");
        }

        private void GIngredient_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRelatedRecipeRecords(gIngredient, e.RowIndex, "RecipeIngredientsId", "RecipeIngredientsDelete", "@RecipeIngredientsId");
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ShowChangeStatusForm();
        }

        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtRecipe))
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
