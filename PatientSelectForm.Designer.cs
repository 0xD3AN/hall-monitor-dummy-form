namespace receptionist_app_winforms
{
    partial class PatientSelectForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPatients = new DataGridView();
            SelectPatientActionCol = new DataGridViewButtonColumn();
            gbPatientListing = new GroupBox();
            btnDummy1 = new Button();
            btnDummyButton2 = new Button();
            cbDummy1 = new CheckBox();
            comboBoxDummy1 = new ComboBox();
            rbDummy1 = new RadioButton();
            rbDummy2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            gbPatientListing.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToDeleteRows = false;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Columns.AddRange(new DataGridViewColumn[] { SelectPatientActionCol });
            dgvPatients.Dock = DockStyle.Fill;
            dgvPatients.Location = new Point(10, 21);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.Size = new Size(771, 385);
            dgvPatients.TabIndex = 0;
            // 
            // SelectPatientActionCol
            // 
            SelectPatientActionCol.HeaderText = "";
            SelectPatientActionCol.Name = "SelectPatientActionCol";
            SelectPatientActionCol.ReadOnly = true;
            SelectPatientActionCol.Resizable = DataGridViewTriState.True;
            SelectPatientActionCol.SortMode = DataGridViewColumnSortMode.Automatic;
            SelectPatientActionCol.Text = "View Details";
            SelectPatientActionCol.ToolTipText = "View";
            SelectPatientActionCol.UseColumnTextForButtonValue = true;
            // 
            // gbPatientListing
            // 
            gbPatientListing.Controls.Add(dgvPatients);
            gbPatientListing.Location = new Point(12, 12);
            gbPatientListing.Name = "gbPatientListing";
            gbPatientListing.Padding = new Padding(10, 5, 10, 5);
            gbPatientListing.Size = new Size(791, 411);
            gbPatientListing.TabIndex = 1;
            gbPatientListing.TabStop = false;
            gbPatientListing.Text = "So many choices...";
            // 
            // btnDummy1
            // 
            btnDummy1.Location = new Point(12, 429);
            btnDummy1.Name = "btnDummy1";
            btnDummy1.Size = new Size(359, 120);
            btnDummy1.TabIndex = 2;
            btnDummy1.Text = "Dummy Button 1";
            btnDummy1.UseVisualStyleBackColor = true;
            // 
            // btnDummyButton2
            // 
            btnDummyButton2.Location = new Point(377, 429);
            btnDummyButton2.Name = "btnDummyButton2";
            btnDummyButton2.Size = new Size(226, 58);
            btnDummyButton2.TabIndex = 3;
            btnDummyButton2.Text = "Dummy Button 2";
            btnDummyButton2.UseVisualStyleBackColor = true;
            // 
            // cbDummy1
            // 
            cbDummy1.AutoSize = true;
            cbDummy1.Location = new Point(645, 450);
            cbDummy1.Name = "cbDummy1";
            cbDummy1.Size = new Size(133, 19);
            cbDummy1.TabIndex = 4;
            cbDummy1.Text = "Dummy CheckBox 1";
            cbDummy1.UseVisualStyleBackColor = true;
            // 
            // comboBoxDummy1
            // 
            comboBoxDummy1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDummy1.FormattingEnabled = true;
            comboBoxDummy1.Items.AddRange(new object[] { "First Dummy Item", "Second Dummy Item", "Third Dummy Item" });
            comboBoxDummy1.Location = new Point(377, 526);
            comboBoxDummy1.Name = "comboBoxDummy1";
            comboBoxDummy1.Size = new Size(416, 23);
            comboBoxDummy1.TabIndex = 5;
            // 
            // rbDummy1
            // 
            rbDummy1.AutoSize = true;
            rbDummy1.Location = new Point(377, 495);
            rbDummy1.Name = "rbDummy1";
            rbDummy1.Size = new Size(146, 19);
            rbDummy1.TabIndex = 6;
            rbDummy1.TabStop = true;
            rbDummy1.Text = "Dummy RadioButton 1";
            rbDummy1.UseVisualStyleBackColor = true;
            // 
            // rbDummy2
            // 
            rbDummy2.AutoSize = true;
            rbDummy2.Location = new Point(529, 495);
            rbDummy2.Name = "rbDummy2";
            rbDummy2.Size = new Size(146, 19);
            rbDummy2.TabIndex = 7;
            rbDummy2.TabStop = true;
            rbDummy2.Text = "Dummy RadioButton 2";
            rbDummy2.UseVisualStyleBackColor = true;
            // 
            // PatientSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(815, 561);
            Controls.Add(rbDummy2);
            Controls.Add(rbDummy1);
            Controls.Add(comboBoxDummy1);
            Controls.Add(cbDummy1);
            Controls.Add(btnDummyButton2);
            Controls.Add(btnDummy1);
            Controls.Add(gbPatientListing);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "PatientSelectForm";
            Text = "Patient Select";
            Load += PatientSelectForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            gbPatientListing.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPatients;
        private GroupBox gbPatientListing;
        private DataGridViewButtonColumn SelectPatientActionCol;
        private Button btnDummy1;
        private Button btnDummyButton2;
        private CheckBox cbDummy1;
        private ComboBox comboBoxDummy1;
        private RadioButton rbDummy1;
        private RadioButton rbDummy2;
    }
}
