namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataMaintenance));
            tblMain = new TableLayoutPanel();
            btnSave = new Button();
            gData = new DataGridView();
            pnlOptionButtions = new FlowLayoutPanel();
            optUsers = new RadioButton();
            optCuisineType = new RadioButton();
            optIngredients = new RadioButton();
            optMeasurement = new RadioButton();
            optCourse = new RadioButton();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            pnlOptionButtions.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2827988F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.7172F));
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(gData, 1, 1);
            tblMain.Controls.Add(pnlOptionButtions, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 84.6666641F));
            tblMain.Size = new Size(1029, 630);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(4, 4);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(222, 51);
            gData.Name = "gData";
            gData.RowTemplate.Height = 25;
            gData.Size = new Size(804, 576);
            gData.TabIndex = 1;
            // 
            // pnlOptionButtions
            // 
            pnlOptionButtions.AutoSize = true;
            pnlOptionButtions.Controls.Add(optUsers);
            pnlOptionButtions.Controls.Add(optCuisineType);
            pnlOptionButtions.Controls.Add(optIngredients);
            pnlOptionButtions.Controls.Add(optMeasurement);
            pnlOptionButtions.Controls.Add(optCourse);
            pnlOptionButtions.Dock = DockStyle.Fill;
            pnlOptionButtions.Location = new Point(3, 51);
            pnlOptionButtions.Name = "pnlOptionButtions";
            pnlOptionButtions.Size = new Size(213, 576);
            pnlOptionButtions.TabIndex = 2;
            // 
            // optUsers
            // 
            optUsers.AutoSize = true;
            optUsers.Checked = true;
            optUsers.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            optUsers.Location = new Point(3, 3);
            optUsers.Name = "optUsers";
            optUsers.Size = new Size(111, 34);
            optUsers.TabIndex = 0;
            optUsers.TabStop = true;
            optUsers.Text = "Users     ";
            optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisineType
            // 
            optCuisineType.AutoSize = true;
            optCuisineType.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            optCuisineType.Location = new Point(3, 43);
            optCuisineType.Name = "optCuisineType";
            optCuisineType.Size = new Size(107, 34);
            optCuisineType.TabIndex = 1;
            optCuisineType.Text = "Cuisines";
            optCuisineType.UseVisualStyleBackColor = true;
            // 
            // optIngredients
            // 
            optIngredients.AutoSize = true;
            optIngredients.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            optIngredients.Location = new Point(3, 83);
            optIngredients.Name = "optIngredients";
            optIngredients.Size = new Size(135, 34);
            optIngredients.TabIndex = 2;
            optIngredients.Text = "Ingredients";
            optIngredients.UseVisualStyleBackColor = true;
            // 
            // optMeasurement
            // 
            optMeasurement.AutoSize = true;
            optMeasurement.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            optMeasurement.Location = new Point(3, 123);
            optMeasurement.Name = "optMeasurement";
            optMeasurement.Size = new Size(168, 34);
            optMeasurement.TabIndex = 3;
            optMeasurement.Text = "Measurements";
            optMeasurement.UseVisualStyleBackColor = true;
            // 
            // optCourse
            // 
            optCourse.AutoSize = true;
            optCourse.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            optCourse.Location = new Point(3, 163);
            optCourse.Name = "optCourse";
            optCourse.Size = new Size(104, 34);
            optCourse.TabIndex = 4;
            optCourse.Text = "Courses";
            optCourse.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1029, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmDataMaintenance";
            Text = "Data Maintenance";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            pnlOptionButtions.ResumeLayout(false);
            pnlOptionButtions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private DataGridView gData;
        private FlowLayoutPanel pnlOptionButtions;
        private RadioButton optUsers;
        private RadioButton optCuisineType;
        private RadioButton optIngredients;
        private RadioButton optMeasurement;
        private RadioButton optCourse;
    }
}