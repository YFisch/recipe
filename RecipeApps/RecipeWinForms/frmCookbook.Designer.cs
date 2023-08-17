namespace RecipeWinForms
{
    partial class frmCookbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCookbook));
            tblMain = new TableLayoutPanel();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            lblCookbookName = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            txtCookbookName = new TextBox();
            lstUserName = new ComboBox();
            tblDetails = new TableLayoutPanel();
            txtPrice = new TextBox();
            txtDateCreated = new TextBox();
            lblDateCreated = new Label();
            chbActive = new CheckBox();
            btnSaveCookbookRecipe = new Button();
            gCookbookRecipes = new DataGridView();
            lblUser = new Label();
            tblMain.SuspendLayout();
            tsMain.SuspendLayout();
            tblDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipes).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tsMain, 0, 0);
            tblMain.Controls.Add(lblCookbookName, 0, 1);
            tblMain.Controls.Add(lblPrice, 0, 3);
            tblMain.Controls.Add(lblActive, 0, 4);
            tblMain.Controls.Add(txtCookbookName, 1, 1);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(tblDetails, 1, 3);
            tblMain.Controls.Add(chbActive, 1, 4);
            tblMain.Controls.Add(btnSaveCookbookRecipe, 0, 5);
            tblMain.Controls.Add(gCookbookRecipes, 0, 6);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tblMain.Size = new Size(872, 611);
            tblMain.TabIndex = 4;
            // 
            // tsMain
            // 
            tblMain.SetColumnSpan(tsMain, 2);
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2 });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(872, 28);
            tsMain.TabIndex = 13;
            tsMain.TabStop = true;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
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
            // lblCookbookName
            // 
            lblCookbookName.Anchor = AnchorStyles.Left;
            lblCookbookName.AutoSize = true;
            lblCookbookName.Location = new Point(3, 81);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(127, 21);
            lblCookbookName.TabIndex = 0;
            lblCookbookName.Text = "Cookbook Name";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 218);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 21);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // lblActive
            // 
            lblActive.Anchor = AnchorStyles.Left;
            lblActive.AutoSize = true;
            lblActive.Location = new Point(3, 294);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(52, 21);
            lblActive.TabIndex = 9;
            lblActive.Text = "Active";
            // 
            // txtCookbookName
            // 
            txtCookbookName.Anchor = AnchorStyles.Left;
            txtCookbookName.Location = new Point(136, 77);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(347, 29);
            txtCookbookName.TabIndex = 1;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(136, 141);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(347, 29);
            lstUserName.TabIndex = 3;
            // 
            // tblDetails
            // 
            tblDetails.ColumnCount = 2;
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDetails.Controls.Add(txtPrice, 0, 1);
            tblDetails.Controls.Add(txtDateCreated, 1, 1);
            tblDetails.Controls.Add(lblDateCreated, 1, 0);
            tblDetails.Dock = DockStyle.Fill;
            tblDetails.Location = new Point(136, 186);
            tblDetails.Name = "tblDetails";
            tblDetails.RowCount = 2;
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDetails.Size = new Size(733, 85);
            tblDetails.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(3, 45);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(152, 29);
            txtPrice.TabIndex = 6;
            // 
            // txtDateCreated
            // 
            txtDateCreated.Location = new Point(369, 45);
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.ReadOnly = true;
            txtDateCreated.Size = new Size(350, 29);
            txtDateCreated.TabIndex = 8;
            // 
            // lblDateCreated
            // 
            lblDateCreated.Anchor = AnchorStyles.None;
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(498, 10);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(103, 21);
            lblDateCreated.TabIndex = 7;
            lblDateCreated.Text = "Date Created:";
            // 
            // chbActive
            // 
            chbActive.Anchor = AnchorStyles.Left;
            chbActive.AutoSize = true;
            chbActive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbActive.Location = new Point(136, 297);
            chbActive.Name = "chbActive";
            chbActive.Size = new Size(15, 14);
            chbActive.TabIndex = 10;
            chbActive.UseVisualStyleBackColor = true;
            // 
            // btnSaveCookbookRecipe
            // 
            btnSaveCookbookRecipe.AutoSize = true;
            btnSaveCookbookRecipe.Location = new Point(3, 338);
            btnSaveCookbookRecipe.Name = "btnSaveCookbookRecipe";
            btnSaveCookbookRecipe.Size = new Size(75, 31);
            btnSaveCookbookRecipe.TabIndex = 11;
            btnSaveCookbookRecipe.Text = "Save";
            btnSaveCookbookRecipe.UseVisualStyleBackColor = true;
            // 
            // gCookbookRecipes
            // 
            gCookbookRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gCookbookRecipes, 2);
            gCookbookRecipes.Dock = DockStyle.Fill;
            gCookbookRecipes.Location = new Point(3, 399);
            gCookbookRecipes.Name = "gCookbookRecipes";
            gCookbookRecipes.RowTemplate.Height = 25;
            gCookbookRecipes.Size = new Size(866, 209);
            gCookbookRecipes.TabIndex = 12;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 142);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(42, 21);
            lblUser.TabIndex = 2;
            lblUser.Text = "User";
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 611);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmCookbook";
            Text = "33";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            tblDetails.ResumeLayout(false);
            tblDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private Label lblCookbookName;
        private Label lblUser;
        private Label lblPrice;
        private Label lblActive;
        private TextBox txtCookbookName;
        private ComboBox lstUserName;
        private TableLayoutPanel tblDetails;
        private TextBox txtPrice;
        private TextBox txtDateCreated;
        private Label lblDateCreated;
        private CheckBox chbActive;
        private Button btnSaveCookbookRecipe;
        private DataGridView gCookbookRecipes;
    }
}