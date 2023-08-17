namespace RecipeWinForms
{
    public partial class frmChangeStatus : Form
    {
        DataTable dtrecipe = new DataTable();
        BindingSource bindsource = new BindingSource();
        public frmChangeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
            this.Activated += FrmChangeStatus_Activated;
        }

        private void FrmChangeStatus_Activated(object? sender, EventArgs e)
        {
            SetButtonsEnabledBasedOnRecipeStatus();
        }

        public void LoadForm(int recipeidval)
        {

            this.Tag = recipeidval;
            dtrecipe = Recipes.Load(recipeidval);
            bindsource.DataSource = dtrecipe;
            if (recipeidval == 0)
            {
                dtrecipe.Rows.Add();
            }
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtdatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
            this.Text = GetChangeStatusDesc();
        }

        private void UpdateRecipeStatus(string proc, Button btn)
        {

            try
            {
                var response = MessageBox.Show($"Are you sure you want to Change this recipe to {btn.Text}?", Application.ProductName, MessageBoxButtons.YesNo);
                if (response == DialogResult.No)
                {
                    return;
                }
                DataRow r = dtrecipe.Rows[0];
                SQLUtility.SaveDataRow(r, proc);
                int id = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                dtrecipe = Recipes.Load(id);
                bindsource.DataSource = dtrecipe;
                SetButtonsEnabledBasedOnRecipeStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void SetButtonsEnabledBasedOnRecipeStatus()
        {
            foreach (Control c in tblButtonStatusDates.Controls)
            {
                c.Enabled = true;
            }
            switch (lblRecipeStatus.Text)
            {
                case "Drafted":
                    btnDraft.Enabled = false;
                    break;
                case "Published":
                    btnPublish.Enabled = false;
                    break;
                case "Archived":
                    btnArchive.Enabled = false;
                    break;
            }
        }

        private string GetChangeStatusDesc()
        {
            string value = "Change Status - " + "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = "Change Status - " + SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            UpdateRecipeStatus("RecipeDateArchivedUpdate", (Button)sender);
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            UpdateRecipeStatus("RecipeDatePublishedUpdate", (Button)sender);
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            UpdateRecipeStatus("RecipeDateDraftedUpdate", (Button)sender);
        }
    }
}
