namespace RecipeWinForms
{
    partial class frmAutoCreateACookbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoCreateACookbook));
            tblMain = new TableLayoutPanel();
            btnCreateCookbook = new Button();
            lstUserName = new ComboBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tblMain.Controls.Add(btnCreateCookbook, 0, 1);
            tblMain.Controls.Add(lstUserName, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 88F));
            tblMain.Size = new Size(705, 460);
            tblMain.TabIndex = 0;
            // 
            // btnCreateCookbook
            // 
            btnCreateCookbook.BackColor = Color.BurlyWood;
            btnCreateCookbook.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateCookbook.ForeColor = Color.ForestGreen;
            btnCreateCookbook.Location = new Point(4, 59);
            btnCreateCookbook.Margin = new Padding(4);
            btnCreateCookbook.Name = "btnCreateCookbook";
            btnCreateCookbook.Size = new Size(269, 65);
            btnCreateCookbook.TabIndex = 0;
            btnCreateCookbook.Text = "Create Cookook";
            btnCreateCookbook.UseVisualStyleBackColor = false;
            // 
            // lstUserName
            // 
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(4, 14);
            lstUserName.Margin = new Padding(4, 14, 4, 4);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(269, 29);
            lstUserName.TabIndex = 1;
            // 
            // frmAutoCreateACookbook
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 460);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmAutoCreateACookbook";
            Text = "Auto Create a Cookbook";
            tblMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnCreateCookbook;
        private ComboBox lstUserName;
    }
}