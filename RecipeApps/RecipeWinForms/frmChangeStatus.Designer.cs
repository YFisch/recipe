namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeStatus));
            tblmain = new TableLayoutPanel();
            lblRecipeName = new Label();
            tblStatusDates = new TableLayoutPanel();
            txtDateDrafted = new TextBox();
            txtdatePublished = new TextBox();
            txtDateArchived = new TextBox();
            lblStatusDates = new Label();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            tblButtonStatusDates = new TableLayoutPanel();
            btnDraft = new Button();
            btnPublish = new Button();
            btnArchive = new Button();
            tblCurrentStatus = new TableLayoutPanel();
            lblCurrentStatus = new Label();
            lblRecipeStatus = new Label();
            tblmain.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tblButtonStatusDates.SuspendLayout();
            tblCurrentStatus.SuspendLayout();
            SuspendLayout();
            // 
            // tblmain
            // 
            tblmain.ColumnCount = 1;
            tblmain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblmain.Controls.Add(lblRecipeName, 0, 0);
            tblmain.Controls.Add(tblStatusDates, 0, 2);
            tblmain.Controls.Add(tblButtonStatusDates, 0, 3);
            tblmain.Controls.Add(tblCurrentStatus, 0, 1);
            tblmain.Dock = DockStyle.Fill;
            tblmain.Location = new Point(0, 0);
            tblmain.Name = "tblmain";
            tblmain.RowCount = 4;
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblmain.Size = new Size(800, 450);
            tblmain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeName.ForeColor = Color.ForestGreen;
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(794, 112);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 4;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.7323036F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0892315F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0892315F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0892315F));
            tblStatusDates.Controls.Add(txtDateDrafted, 1, 1);
            tblStatusDates.Controls.Add(txtdatePublished, 2, 1);
            tblStatusDates.Controls.Add(txtDateArchived, 3, 1);
            tblStatusDates.Controls.Add(lblStatusDates, 0, 1);
            tblStatusDates.Controls.Add(lblDrafted, 1, 0);
            tblStatusDates.Controls.Add(lblPublished, 2, 0);
            tblStatusDates.Controls.Add(lblArchived, 3, 0);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(3, 227);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.Size = new Size(794, 106);
            tblStatusDates.TabIndex = 2;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Location = new Point(127, 56);
            txtDateDrafted.Multiline = true;
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(217, 47);
            txtDateDrafted.TabIndex = 0;
            // 
            // txtdatePublished
            // 
            txtdatePublished.Dock = DockStyle.Fill;
            txtdatePublished.Location = new Point(350, 56);
            txtdatePublished.Multiline = true;
            txtdatePublished.Name = "txtdatePublished";
            txtdatePublished.ReadOnly = true;
            txtdatePublished.Size = new Size(217, 47);
            txtdatePublished.TabIndex = 1;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(573, 56);
            txtDateArchived.Multiline = true;
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(218, 47);
            txtDateArchived.TabIndex = 2;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusDates.Location = new Point(3, 53);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(118, 53);
            lblStatusDates.TabIndex = 3;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDrafted.Location = new Point(127, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(217, 53);
            lblDrafted.TabIndex = 4;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPublished.Location = new Point(350, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(217, 53);
            lblPublished.TabIndex = 5;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblArchived.Location = new Point(573, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(218, 53);
            lblArchived.TabIndex = 6;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblButtonStatusDates
            // 
            tblButtonStatusDates.ColumnCount = 3;
            tblButtonStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtonStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtonStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtonStatusDates.Controls.Add(btnDraft, 0, 0);
            tblButtonStatusDates.Controls.Add(btnPublish, 1, 0);
            tblButtonStatusDates.Controls.Add(btnArchive, 2, 0);
            tblButtonStatusDates.Dock = DockStyle.Fill;
            tblButtonStatusDates.Location = new Point(3, 339);
            tblButtonStatusDates.Name = "tblButtonStatusDates";
            tblButtonStatusDates.RowCount = 1;
            tblButtonStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtonStatusDates.Size = new Size(794, 108);
            tblButtonStatusDates.TabIndex = 3;
            // 
            // btnDraft
            // 
            btnDraft.Anchor = AnchorStyles.None;
            btnDraft.AutoSize = true;
            btnDraft.BackColor = Color.BurlyWood;
            btnDraft.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDraft.Location = new Point(94, 36);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(75, 35);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = false;
            // 
            // btnPublish
            // 
            btnPublish.Anchor = AnchorStyles.None;
            btnPublish.AutoSize = true;
            btnPublish.BackColor = Color.BurlyWood;
            btnPublish.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPublish.Location = new Point(354, 36);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(84, 35);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = false;
            // 
            // btnArchive
            // 
            btnArchive.Anchor = AnchorStyles.None;
            btnArchive.AutoSize = true;
            btnArchive.BackColor = Color.BurlyWood;
            btnArchive.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnArchive.Location = new Point(618, 36);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(85, 35);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = false;
            // 
            // tblCurrentStatus
            // 
            tblCurrentStatus.ColumnCount = 2;
            tblCurrentStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCurrentStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCurrentStatus.Controls.Add(lblCurrentStatus, 0, 0);
            tblCurrentStatus.Controls.Add(lblRecipeStatus, 1, 0);
            tblCurrentStatus.Dock = DockStyle.Fill;
            tblCurrentStatus.Location = new Point(3, 115);
            tblCurrentStatus.Name = "tblCurrentStatus";
            tblCurrentStatus.RowCount = 1;
            tblCurrentStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCurrentStatus.Size = new Size(794, 106);
            tblCurrentStatus.TabIndex = 4;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Dock = DockStyle.Fill;
            lblCurrentStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentStatus.ForeColor = Color.ForestGreen;
            lblCurrentStatus.Location = new Point(3, 0);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(391, 106);
            lblCurrentStatus.TabIndex = 1;
            lblCurrentStatus.Text = "Current Status: ";
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeStatus.Location = new Point(400, 0);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(391, 106);
            lblRecipeStatus.TabIndex = 2;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblmain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmChangeStatus";
            Text = "Change Status";
            tblmain.ResumeLayout(false);
            tblmain.PerformLayout();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tblButtonStatusDates.ResumeLayout(false);
            tblButtonStatusDates.PerformLayout();
            tblCurrentStatus.ResumeLayout(false);
            tblCurrentStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblmain;
        private Label lblRecipeName;
        private Label lblCurrentStatus;
        private TableLayoutPanel tblStatusDates;
        private TextBox txtDateDrafted;
        private TextBox txtdatePublished;
        private TextBox txtDateArchived;
        private Label lblStatusDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TableLayoutPanel tblButtonStatusDates;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
        private TableLayoutPanel tblCurrentStatus;
        private Label lblRecipeStatus;
    }
}