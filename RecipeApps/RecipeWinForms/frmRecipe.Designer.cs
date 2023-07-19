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
            txtRecipe = new TextBox();
            txtUserName = new TextBox();
            txtCuisineName = new TextBox();
            txtCalories = new TextBox();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            txtRecipeStatus = new TextBox();
            txtRecipePicture = new TextBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblCaptionRecipe, 0, 0);
            tblMain.Controls.Add(lblCaptionUserName, 0, 1);
            tblMain.Controls.Add(lblCaptionCuisineName, 0, 2);
            tblMain.Controls.Add(lblCaptionCalories, 0, 3);
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 4);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 5);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 7);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 6);
            tblMain.Controls.Add(lblCaptionRecipePicture, 0, 8);
            tblMain.Controls.Add(txtRecipe, 1, 0);
            tblMain.Controls.Add(txtUserName, 1, 1);
            tblMain.Controls.Add(txtCuisineName, 1, 2);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(txtDateDrafted, 1, 4);
            tblMain.Controls.Add(txtDatePublished, 1, 5);
            tblMain.Controls.Add(txtDateArchived, 1, 6);
            tblMain.Controls.Add(txtRecipeStatus, 1, 7);
            tblMain.Controls.Add(txtRecipePicture, 1, 8);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMain.Size = new Size(923, 489);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipe
            // 
            lblCaptionRecipe.Anchor = AnchorStyles.Left;
            lblCaptionRecipe.AutoSize = true;
            lblCaptionRecipe.Location = new Point(4, 17);
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
            lblCaptionUserName.Location = new Point(4, 73);
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
            lblCaptionCuisineName.Location = new Point(4, 129);
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
            lblCaptionCalories.Location = new Point(4, 185);
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
            lblCaptionDateDrafted.Location = new Point(4, 241);
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
            lblCaptionDatePublished.Location = new Point(4, 297);
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
            lblCaptionRecipeStatus.Location = new Point(4, 409);
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
            lblCaptionDateArchived.Location = new Point(4, 353);
            lblCaptionDateArchived.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(107, 21);
            lblCaptionDateArchived.TabIndex = 6;
            lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionRecipePicture
            // 
            lblCaptionRecipePicture.AutoSize = true;
            lblCaptionRecipePicture.Location = new Point(3, 455);
            lblCaptionRecipePicture.Margin = new Padding(3, 7, 3, 0);
            lblCaptionRecipePicture.Name = "lblCaptionRecipePicture";
            lblCaptionRecipePicture.Size = new Size(108, 21);
            lblCaptionRecipePicture.TabIndex = 8;
            lblCaptionRecipePicture.Text = "Recipe Picture";
            // 
            // txtRecipe
            // 
            txtRecipe.Dock = DockStyle.Fill;
            txtRecipe.Location = new Point(125, 3);
            txtRecipe.Name = "txtRecipe";
            txtRecipe.Size = new Size(795, 29);
            txtRecipe.TabIndex = 9;
            // 
            // txtUserName
            // 
            txtUserName.Dock = DockStyle.Fill;
            txtUserName.Location = new Point(125, 59);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(795, 29);
            txtUserName.TabIndex = 10;
            // 
            // txtCuisineName
            // 
            txtCuisineName.Dock = DockStyle.Fill;
            txtCuisineName.Location = new Point(125, 115);
            txtCuisineName.Name = "txtCuisineName";
            txtCuisineName.Size = new Size(795, 29);
            txtCuisineName.TabIndex = 11;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(125, 171);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(795, 29);
            txtCalories.TabIndex = 12;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Location = new Point(125, 227);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(795, 29);
            txtDateDrafted.TabIndex = 13;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(125, 283);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(795, 29);
            txtDatePublished.TabIndex = 14;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(125, 339);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(795, 29);
            txtDateArchived.TabIndex = 15;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Location = new Point(125, 395);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.Size = new Size(795, 29);
            txtRecipeStatus.TabIndex = 16;
            // 
            // txtRecipePicture
            // 
            txtRecipePicture.Dock = DockStyle.Fill;
            txtRecipePicture.Location = new Point(125, 451);
            txtRecipePicture.Name = "txtRecipePicture";
            txtRecipePicture.Size = new Size(795, 29);
            txtRecipePicture.TabIndex = 17;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 489);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmRecipe";
            Text = "Recipe Info";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
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
        private TextBox txtRecipe;
        private TextBox txtUserName;
        private TextBox txtCuisineName;
        private TextBox txtCalories;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtRecipeStatus;
        private TextBox txtRecipePicture;
    }
}