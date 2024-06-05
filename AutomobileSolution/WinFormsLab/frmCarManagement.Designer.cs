namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            lbManufacturer = new Label();
            lbCarName = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtPrice = new TextBox();
            txtManufacturer = new TextBox();
            txtCarName = new TextBox();
            txtReleaseYear = new TextBox();
            dgvCarList = new DataGridView();
            btnLoad = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Font = new Font("Segoe UI", 10F);
            lbCarID.Location = new Point(34, 36);
            lbCarID.Name = "lbCarID";
            lbCarID.RightToLeft = RightToLeft.No;
            lbCarID.Size = new Size(48, 19);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Font = new Font("Segoe UI", 10F);
            lbManufacturer.Location = new Point(34, 114);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.RightToLeft = RightToLeft.No;
            lbManufacturer.Size = new Size(92, 19);
            lbManufacturer.TabIndex = 1;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Font = new Font("Segoe UI", 10F);
            lbCarName.Location = new Point(34, 72);
            lbCarName.Name = "lbCarName";
            lbCarName.RightToLeft = RightToLeft.No;
            lbCarName.Size = new Size(70, 19);
            lbCarName.TabIndex = 2;
            lbCarName.Text = "Car Name";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 10F);
            lbPrice.Location = new Point(485, 36);
            lbPrice.Name = "lbPrice";
            lbPrice.RightToLeft = RightToLeft.No;
            lbPrice.Size = new Size(38, 19);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Font = new Font("Segoe UI", 10F);
            lbReleaseYear.Location = new Point(485, 72);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.RightToLeft = RightToLeft.No;
            lbReleaseYear.Size = new Size(84, 19);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(142, 35);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(293, 23);
            txtCarID.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(577, 35);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(277, 23);
            txtPrice.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(142, 114);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(293, 23);
            txtManufacturer.TabIndex = 7;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(142, 72);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(293, 23);
            txtCarName.TabIndex = 8;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(577, 72);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(277, 23);
            txtReleaseYear.TabIndex = 9;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(5, 193);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 100;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(938, 224);
            dgvCarList.TabIndex = 10;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(142, 152);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(109, 23);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(409, 152);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(654, 152);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(95, 23);
            btnNew.TabIndex = 13;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(409, 423);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 23);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 450);
            Controls.Add(btnClose);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(dgvCarList);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtCarName);
            Controls.Add(txtManufacturer);
            Controls.Add(txtPrice);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbCarName);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private Label lbManufacturer;
        private Label lbCarName;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtPrice;
        private TextBox txtManufacturer;
        private TextBox txtCarName;
        private TextBox txtReleaseYear;
        private DataGridView dgvCarList;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnNew;
        private Button btnClose;
    }
}