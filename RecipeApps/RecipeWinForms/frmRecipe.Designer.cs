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
            lblCaptionDateDrafted = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionRecipeStatus = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionRecipePicture = new Label();
            txtRecipeName = new TextBox();
            txtCalories = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            lstUserName = new ComboBox();
            lstCuisineTypeName = new ComboBox();
            dtpDateDrafted = new DateTimePicker();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            lblRecipeStatus = new Label();
            lblRecipePicture = new Label();
            tblMain.SuspendLayout();
            tsMain.SuspendLayout();
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
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 5);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 6);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 8);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 7);
            tblMain.Controls.Add(lblCaptionRecipePicture, 0, 9);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(txtCalories, 1, 4);
            tblMain.Controls.Add(txtDatePublished, 1, 6);
            tblMain.Controls.Add(txtDateArchived, 1, 7);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(lstCuisineTypeName, 1, 3);
            tblMain.Controls.Add(dtpDateDrafted, 1, 5);
            tblMain.Controls.Add(tsMain, 0, 0);
            tblMain.Controls.Add(lblRecipeStatus, 1, 8);
            tblMain.Controls.Add(lblRecipePicture, 1, 9);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 10;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.Size = new Size(478, 560);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipe
            // 
            lblCaptionRecipe.Anchor = AnchorStyles.Left;
            lblCaptionRecipe.AutoSize = true;
            lblCaptionRecipe.Location = new Point(4, 73);
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
            lblCaptionUserName.Location = new Point(4, 129);
            lblCaptionUserName.Margin = new Padding(4, 0, 4, 0);
            lblCaptionUserName.Name = "lblCaptionUserName";
            lblCaptionUserName.Size = new Size(88, 21);
            lblCaptionUserName.TabIndex = 1;
            lblCaptionUserName.Text = "User Name";
            // 
            // lblCaptionCuisineName
            // 
            lblCaptionCuisineName.Anchor = AnchorStyles.Left;
            lblCaptionCuisineName.AutoSize = true;
            lblCaptionCuisineName.Location = new Point(4, 185);
            lblCaptionCuisineName.Margin = new Padding(4, 0, 4, 0);
            lblCaptionCuisineName.Name = "lblCaptionCuisineName";
            lblCaptionCuisineName.Size = new Size(107, 21);
            lblCaptionCuisineName.TabIndex = 2;
            lblCaptionCuisineName.Text = "Cuisine Name";
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Location = new Point(4, 241);
            lblCaptionCalories.Margin = new Padding(4, 0, 4, 0);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(66, 21);
            lblCaptionCalories.TabIndex = 3;
            lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.Anchor = AnchorStyles.Left;
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Location = new Point(4, 297);
            lblCaptionDateDrafted.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(98, 21);
            lblCaptionDateDrafted.TabIndex = 4;
            lblCaptionDateDrafted.Text = "Date Drafted";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.Anchor = AnchorStyles.Left;
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Location = new Point(4, 353);
            lblCaptionDatePublished.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(114, 21);
            lblCaptionDatePublished.TabIndex = 5;
            lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.Anchor = AnchorStyles.Left;
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Location = new Point(4, 465);
            lblCaptionRecipeStatus.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(102, 21);
            lblCaptionRecipeStatus.TabIndex = 7;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.Anchor = AnchorStyles.Left;
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Location = new Point(4, 409);
            lblCaptionDateArchived.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(107, 21);
            lblCaptionDateArchived.TabIndex = 6;
            lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionRecipePicture
            // 
            lblCaptionRecipePicture.AutoSize = true;
            lblCaptionRecipePicture.Location = new Point(3, 511);
            lblCaptionRecipePicture.Margin = new Padding(3, 7, 3, 0);
            lblCaptionRecipePicture.Name = "lblCaptionRecipePicture";
            lblCaptionRecipePicture.Size = new Size(108, 21);
            lblCaptionRecipePicture.TabIndex = 8;
            lblCaptionRecipePicture.Text = "Recipe Picture";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(125, 59);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(350, 29);
            txtRecipeName.TabIndex = 9;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(125, 227);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(350, 29);
            txtCalories.TabIndex = 12;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(125, 339);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(350, 29);
            txtDatePublished.TabIndex = 14;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(125, 395);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(350, 29);
            txtDateArchived.TabIndex = 15;
            // 
            // lstUserName
            // 
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(125, 115);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(158, 29);
            lstUserName.TabIndex = 18;
            // 
            // lstCuisineTypeName
            // 
            lstCuisineTypeName.FormattingEnabled = true;
            lstCuisineTypeName.Location = new Point(125, 171);
            lstCuisineTypeName.Name = "lstCuisineTypeName";
            lstCuisineTypeName.Size = new Size(158, 29);
            lstCuisineTypeName.TabIndex = 19;
            // 
            // dtpDateDrafted
            // 
            dtpDateDrafted.Format = DateTimePickerFormat.Short;
            dtpDateDrafted.Location = new Point(125, 283);
            dtpDateDrafted.Name = "dtpDateDrafted";
            dtpDateDrafted.Size = new Size(158, 29);
            dtpDateDrafted.TabIndex = 20;
            // 
            // tsMain
            // 
            tblMain.SetColumnSpan(tsMain, 2);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2 });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(478, 28);
            tsMain.TabIndex = 21;
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
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(125, 448);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(350, 56);
            lblRecipeStatus.TabIndex = 22;
            // 
            // lblRecipePicture
            // 
            lblRecipePicture.AutoSize = true;
            lblRecipePicture.Dock = DockStyle.Fill;
            lblRecipePicture.Location = new Point(125, 504);
            lblRecipePicture.Name = "lblRecipePicture";
            lblRecipePicture.Size = new Size(350, 56);
            lblRecipePicture.TabIndex = 23;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 560);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmRecipe";
            Text = "Recipe Info";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
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
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private ComboBox lstUserName;
        private ComboBox lstCuisineType;
        private DateTimePicker dtpDateDrafted;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ComboBox lstCuisineTypeName;
        private Label lblRecipeStatus;
        private Label lblRecipePicture;
    }
}