namespace receptionist_app_winforms
{
    partial class PatientDetailsForm
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
            lblFullName = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblAge = new Label();
            lblDateOfBirth = new Label();
            tbFullName = new TextBox();
            tbAddress = new TextBox();
            tbPhone = new TextBox();
            tbAge = new TextBox();
            tbDateOfBirth = new TextBox();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(12, 9);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(203, 9);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(58, 15);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address 1";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(15, 87);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(153, 87);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(243, 87);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(73, 15);
            lblDateOfBirth.TabIndex = 4;
            lblDateOfBirth.Text = "Date of Birth";
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(15, 27);
            tbFullName.Name = "tbFullName";
            tbFullName.ReadOnly = true;
            tbFullName.Size = new Size(166, 23);
            tbFullName.TabIndex = 5;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(203, 27);
            tbAddress.Name = "tbAddress";
            tbAddress.ReadOnly = true;
            tbAddress.Size = new Size(231, 23);
            tbAddress.TabIndex = 6;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(15, 105);
            tbPhone.Name = "tbPhone";
            tbPhone.ReadOnly = true;
            tbPhone.Size = new Size(101, 23);
            tbPhone.TabIndex = 7;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(153, 105);
            tbAge.Name = "tbAge";
            tbAge.ReadOnly = true;
            tbAge.Size = new Size(52, 23);
            tbAge.TabIndex = 8;
            // 
            // tbDateOfBirth
            // 
            tbDateOfBirth.Location = new Point(243, 105);
            tbDateOfBirth.Name = "tbDateOfBirth";
            tbDateOfBirth.ReadOnly = true;
            tbDateOfBirth.Size = new Size(94, 23);
            tbDateOfBirth.TabIndex = 9;
            // 
            // PatientDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 150);
            Controls.Add(tbDateOfBirth);
            Controls.Add(tbAge);
            Controls.Add(tbPhone);
            Controls.Add(tbAddress);
            Controls.Add(tbFullName);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblAge);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblFullName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PatientDetailsForm";
            Text = "PatientDetailsForm";
            Load += PatientDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblAge;
        private Label lblDateOfBirth;
        private TextBox tbFullName;
        private TextBox tbAddress;
        private TextBox tbPhone;
        private TextBox tbAge;
        private TextBox tbDateOfBirth;
    }
}