namespace RecipeWinForms
{
    partial class frmRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            tblMain = new TableLayoutPanel();
            lblCaptionRecipe = new Label();
            lblCaptionUserName = new Label();
            lblCaptionCuisineName = new Label();
            lblCaptionCalories = new Label();
            txtRecipeName = new TextBox();
            txtCalories = new TextBox();
            lstUserName = new ComboBox();
            lstCuisineTypeName = new ComboBox();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnChangeStatus = new ToolStripButton();
            lblCurrentStatus = new Label();
            txtRecipeStatus = new TextBox();
            lblStatusDates = new Label();
            tblRecipeStatus = new TableLayoutPanel();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            lblPublished = new Label();
            lblDrafted = new Label();
            lblArchived = new Label();
            tbChildRecord = new TabControl();
            tbIngredients = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btnSaveIngredient = new Button();
            gIngredient = new DataGridView();
            tbSteps = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnSaveStep = new Button();
            gSteps = new DataGridView();
            tblMain.SuspendLayout();
            tsMain.SuspendLayout();
            tblRecipeStatus.SuspendLayout();
            tbChildRecord.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredient).BeginInit();
            tbSteps.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblCaptionRecipe, 0, 1);
            tblMain.Controls.Add(lblCaptionUserName, 0, 2);
            tblMain.Controls.Add(lblCaptionCuisineName, 0, 3);
            tblMain.Controls.Add(lblCaptionCalories, 0, 4);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(txtCalories, 1, 4);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(lstCuisineTypeName, 1, 3);
            tblMain.Controls.Add(tsMain, 0, 0);
            tblMain.Controls.Add(lblCurrentStatus, 0, 5);
            tblMain.Controls.Add(txtRecipeStatus, 1, 5);
            tblMain.Controls.Add(lblStatusDates, 0, 6);
            tblMain.Controls.Add(tblRecipeStatus, 1, 6);
            tblMain.Controls.Add(tbChildRecord, 0, 7);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 44F));
            tblMain.Size = new Size(633, 622);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipe
            // 
            lblCaptionRecipe.Anchor = AnchorStyles.Left;
            lblCaptionRecipe.AutoSize = true;
            lblCaptionRecipe.Location = new Point(4, 54);
            lblCaptionRecipe.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipe.Name = "lblCaptionRecipe";
            lblCaptionRecipe.Size = new Size(56, 21);
            lblCaptionRecipe.TabIndex = 0;
            lblCaptionRecipe.Text = "Recipe";
            // 
            // lblCaptionUserName
            // 
            lblCaptionUserName.Anchor = AnchorStyles.Left;
            lblCaptionUserName.AutoSize = true;
            lblCaptionUserName.Location = new Point(4, 97);
            lblCaptionUserName.Margin = new Padding(4, 0, 4, 0);
            lblCaptionUserName.Name = "lblCaptionUserName";
            lblCaptionUserName.Size = new Size(88, 21);
            lblCaptionUserName.TabIndex = 2;
            lblCaptionUserName.Text = "User Name";
            // 
            // lblCaptionCuisineName
            // 
            lblCaptionCuisineName.Anchor = AnchorStyles.Left;
            lblCaptionCuisineName.AutoSize = true;
            lblCaptionCuisineName.Location = new Point(4, 140);
            lblCaptionCuisineName.Margin = new Padding(4, 0, 4, 0);
            lblCaptionCuisineName.Name = "lblCaptionCuisineName";
            lblCaptionCuisineName.Size = new Size(107, 21);
            lblCaptionCuisineName.TabIndex = 4;
            lblCaptionCuisineName.Text = "Cuisine Name";
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Location = new Point(4, 183);
            lblCaptionCalories.Margin = new Padding(4, 0, 4, 0);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(66, 21);
            lblCaptionCalories.TabIndex = 6;
            lblCaptionCalories.Text = "Calories";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(118, 46);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(512, 29);
            txtRecipeName.TabIndex = 1;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(118, 175);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(512, 29);
            txtCalories.TabIndex = 7;
            // 
            // lstUserName
            // 
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(118, 89);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(158, 29);
            lstUserName.TabIndex = 3;
            // 
            // lstCuisineTypeName
            // 
            lstCuisineTypeName.FormattingEnabled = true;
            lstCuisineTypeName.Location = new Point(118, 132);
            lstCuisineTypeName.Name = "lstCuisineTypeName";
            lstCuisineTypeName.Size = new Size(158, 29);
            lstCuisineTypeName.TabIndex = 5;
            // 
            // tsMain
            // 
            tblMain.SetColumnSpan(tsMain, 2);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2, btnChangeStatus });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(633, 28);
            tsMain.TabIndex = 13;
            tsMain.TabStop = true;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(47, 25);
            btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(58, 25);
            btnDelete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnChangeStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeStatus.Image = (Image)resources.GetObject("btnChangeStatus.Image");
            btnChangeStatus.ImageTransparentColor = Color.Magenta;
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(113, 25);
            btnChangeStatus.Text = "Change Status";
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Left;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Location = new Point(3, 226);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(109, 21);
            lblCurrentStatus.TabIndex = 8;
            lblCurrentStatus.Text = "Current Status";
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Location = new Point(118, 218);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.ReadOnly = true;
            txtRecipeStatus.Size = new Size(512, 29);
            txtRecipeStatus.TabIndex = 9;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Left;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(3, 291);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(95, 21);
            lblStatusDates.TabIndex = 10;
            lblStatusDates.Text = "Status Dates";
            // 
            // tblRecipeStatus
            // 
            tblRecipeStatus.ColumnCount = 3;
            tblRecipeStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblRecipeStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblRecipeStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblRecipeStatus.Controls.Add(txtDateDrafted, 0, 1);
            tblRecipeStatus.Controls.Add(txtDatePublished, 1, 1);
            tblRecipeStatus.Controls.Add(txtDateArchived, 2, 1);
            tblRecipeStatus.Controls.Add(lblPublished, 1, 0);
            tblRecipeStatus.Controls.Add(lblDrafted, 0, 0);
            tblRecipeStatus.Controls.Add(lblArchived, 2, 0);
            tblRecipeStatus.Dock = DockStyle.Fill;
            tblRecipeStatus.Location = new Point(118, 261);
            tblRecipeStatus.Name = "tblRecipeStatus";
            tblRecipeStatus.RowCount = 2;
            tblRecipeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblRecipeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblRecipeStatus.Size = new Size(512, 81);
            tblRecipeStatus.TabIndex = 26;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Location = new Point(3, 43);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(128, 29);
            txtDateDrafted.TabIndex = 2;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Location = new Point(173, 43);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(128, 29);
            txtDatePublished.TabIndex = 14;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Location = new Point(343, 43);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(129, 29);
            txtDateArchived.TabIndex = 16;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Location = new Point(173, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(164, 40);
            lblPublished.TabIndex = 13;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Location = new Point(3, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(164, 40);
            lblDrafted.TabIndex = 0;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Location = new Point(343, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(166, 40);
            lblArchived.TabIndex = 15;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbChildRecord
            // 
            tblMain.SetColumnSpan(tbChildRecord, 2);
            tbChildRecord.Controls.Add(tbIngredients);
            tbChildRecord.Controls.Add(tbSteps);
            tbChildRecord.Dock = DockStyle.Fill;
            tbChildRecord.Location = new Point(3, 348);
            tbChildRecord.Name = "tbChildRecord";
            tbChildRecord.SelectedIndex = 0;
            tbChildRecord.Size = new Size(627, 271);
            tbChildRecord.TabIndex = 13;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngredients);
            tbIngredients.Location = new Point(4, 30);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(619, 237);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblIngredients.Controls.Add(btnSaveIngredient, 0, 0);
            tblIngredients.Controls.Add(gIngredient, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblIngredients.Size = new Size(613, 231);
            tblIngredients.TabIndex = 0;
            // 
            // btnSaveIngredient
            // 
            btnSaveIngredient.AutoSize = true;
            btnSaveIngredient.Location = new Point(3, 3);
            btnSaveIngredient.Name = "btnSaveIngredient";
            btnSaveIngredient.Size = new Size(75, 31);
            btnSaveIngredient.TabIndex = 1;
            btnSaveIngredient.Text = "Save";
            btnSaveIngredient.UseVisualStyleBackColor = true;
            // 
            // gIngredient
            // 
            gIngredient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredient.Dock = DockStyle.Fill;
            gIngredient.Location = new Point(3, 40);
            gIngredient.Name = "gIngredient";
            gIngredient.RowTemplate.Height = 25;
            gIngredient.Size = new Size(607, 188);
            gIngredient.TabIndex = 0;
            // 
            // tbSteps
            // 
            tbSteps.Controls.Add(tblSteps);
            tbSteps.Location = new Point(4, 24);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(3);
            tbSteps.Size = new Size(619, 243);
            tbSteps.TabIndex = 1;
            tbSteps.Text = "Steps";
            tbSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSteps.Controls.Add(btnSaveStep, 0, 0);
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSteps.Size = new Size(613, 237);
            tblSteps.TabIndex = 0;
            // 
            // btnSaveStep
            // 
            btnSaveStep.AutoSize = true;
            btnSaveStep.Location = new Point(3, 3);
            btnSaveStep.Name = "btnSaveStep";
            btnSaveStep.Size = new Size(75, 31);
            btnSaveStep.TabIndex = 0;
            btnSaveStep.Text = "Save";
            btnSaveStep.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 40);
            gSteps.Name = "gSteps";
            gSteps.RowTemplate.Height = 25;
            gSteps.Size = new Size(607, 194);
            gSteps.TabIndex = 0;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 622);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmRecipe";
            Text = "Recipe Info";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            tblRecipeStatus.ResumeLayout(false);
            tblRecipeStatus.PerformLayout();
            tbChildRecord.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredient).EndInit();
            tbSteps.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            tblSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipe;
        private Label lblCaptionUserName;
        private Label lblCaptionCuisineName;
        private Label lblCaptionCalories;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionDatePublished;
        private Label lblCaptionRecipeStatus;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipePicture;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private TextBox txtRecipeStatus;
        private ComboBox lstUserName;
        private ComboBox lstIngredients;
        private DateTimePicker dtpDateDrafted;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ComboBox lstCuisineTypeName;
        private Label lblCurrentStatus;
        private Label lblStatusDates;
        private TableLayoutPanel tblRecipeStatus;
        private ToolStripButton btnChangeStatus;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TabControl tbChildRecord;
        private TabPage tbIngredients;
        private TableLayoutPanel tblIngredients;
        private Button btnSaveIngredient;
        private DataGridView gIngredient;
        private TabPage tbSteps;
        private TableLayoutPanel tblSteps;
        private Button btnSaveStep;
        private DataGridView gSteps;
        private Label lblPublished;
        private Label lblDrafted;
        private Label lblArchived;
    }
}