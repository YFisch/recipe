namespace RecipeWinForms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            tblMain = new TableLayoutPanel();
            lblWelcome = new Label();
            gDataOverview = new DataGridView();
            tblListButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            lblDescription = new Label();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDataOverview).BeginInit();
            tblListButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.Controls.Add(lblWelcome, 1, 0);
            tblMain.Controls.Add(gDataOverview, 1, 2);
            tblMain.Controls.Add(tblListButtons, 1, 3);
            tblMain.Controls.Add(lblDescription, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.32653F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.32653F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 51.02041F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.32653F));
            tblMain.Size = new Size(758, 625);
            tblMain.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.ForestGreen;
            lblWelcome.Location = new Point(193, 0);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(371, 102);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Hearty Hearth Desktop App";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gDataOverview
            // 
            gDataOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gDataOverview.Dock = DockStyle.Fill;
            gDataOverview.Location = new Point(193, 208);
            gDataOverview.Margin = new Padding(4);
            gDataOverview.Name = "gDataOverview";
            gDataOverview.RowTemplate.Height = 25;
            gDataOverview.Size = new Size(371, 310);
            gDataOverview.TabIndex = 2;
            // 
            // tblListButtons
            // 
            tblListButtons.ColumnCount = 3;
            tblListButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblListButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblListButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblListButtons.Controls.Add(btnRecipeList, 0, 0);
            tblListButtons.Controls.Add(btnMealList, 1, 0);
            tblListButtons.Controls.Add(btnCookbookList, 2, 0);
            tblListButtons.Dock = DockStyle.Fill;
            tblListButtons.Location = new Point(192, 525);
            tblListButtons.Name = "tblListButtons";
            tblListButtons.RowCount = 1;
            tblListButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblListButtons.Size = new Size(373, 97);
            tblListButtons.TabIndex = 3;
            // 
            // btnRecipeList
            // 
            btnRecipeList.BackColor = Color.BurlyWood;
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.ForeColor = Color.ForestGreen;
            btnRecipeList.Location = new Point(3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(118, 91);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = false;
            // 
            // btnMealList
            // 
            btnMealList.BackColor = Color.BurlyWood;
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.ForeColor = Color.ForestGreen;
            btnMealList.Location = new Point(127, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(118, 91);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = false;
            // 
            // btnCookbookList
            // 
            btnCookbookList.BackColor = Color.BurlyWood;
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.ForeColor = Color.ForestGreen;
            btnCookbookList.Location = new Point(251, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(119, 91);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.BurlyWood;
            tblMain.SetColumnSpan(lblDescription, 3);
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(4, 102);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(750, 102);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Welcome to the Hearty hearth desktop app. In this app you can create recipes and cookbooks. You can also...\r\n\r\n\r\n\r\n";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 625);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gDataOverview).EndInit();
            tblListButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblWelcome;
        private Label lblDescription;
        private DataGridView gDataOverview;
        private TableLayoutPanel tblListButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}