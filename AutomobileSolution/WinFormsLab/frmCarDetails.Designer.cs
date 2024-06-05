namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            txtCarID = new TextBox();
            lbCarID = new Label();
            lbCarName = new Label();
            txtCarName = new TextBox();
            cboManufacturer = new ComboBox();
            lbManufacturer = new Label();
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            lbReleaseYear = new Label();
            lbPrice = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(109, 32);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(290, 23);
            txtCarID.TabIndex = 0;
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Font = new Font("Segoe UI", 10F);
            lbCarID.Location = new Point(14, 35);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(48, 19);
            lbCarID.TabIndex = 1;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Font = new Font("Segoe UI", 10F);
            lbCarName.Location = new Point(14, 81);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(70, 19);
            lbCarName.TabIndex = 2;
            lbCarName.Text = "Car Name";
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(109, 78);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(290, 23);
            txtCarName.TabIndex = 3;
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(109, 134);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(290, 23);
            cboManufacturer.TabIndex = 4;
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Font = new Font("Segoe UI", 10F);
            lbManufacturer.Location = new Point(14, 137);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(92, 19);
            lbManufacturer.TabIndex = 5;
            lbManufacturer.Text = "Manufacturer";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(109, 186);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(290, 23);
            txtPrice.TabIndex = 6;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(109, 240);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(290, 23);
            txtReleaseYear.TabIndex = 7;
            txtReleaseYear.Text = "0";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Font = new Font("Segoe UI", 10F);
            lbReleaseYear.Location = new Point(14, 243);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(84, 19);
            lbReleaseYear.TabIndex = 8;
            lbReleaseYear.Text = "Release Year";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 10F);
            lbPrice.Location = new Point(14, 189);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(38, 19);
            lbPrice.TabIndex = 9;
            lbPrice.Text = "Price";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(109, 305);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(316, 305);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(83, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 352);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbPrice);
            Controls.Add(lbReleaseYear);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(cboManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Controls.Add(txtCarID);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCarID;
        private Label lbCarID;
        private Label lbCarName;
        private TextBox txtCarName;
        private ComboBox cboManufacturer;
        private Label lbManufacturer;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
        private Label lbReleaseYear;
        private Label lbPrice;
        private Button btnSave;
        private Button btnCancel;
    }
}