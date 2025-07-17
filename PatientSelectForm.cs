namespace receptionist_app_winforms
{
    public partial class PatientSelectForm : Form
    {
        private PatientData _patientData;

        public PatientSelectForm()
        {
            InitializeComponent();

            _patientData = new PatientData();

            dgvPatients.CellContentClick += DgvPatients_CellContentClick;
        }

        private void DgvPatients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender!;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var selectedPatient = (PatientData.PatientModel)senderGrid.Rows[e.RowIndex].DataBoundItem!;
                var detailsWindow = new PatientDetailsForm(selectedPatient);
                detailsWindow.ShowDialog();
            }
        }

        private void PatientSelectForm_Load(object sender, EventArgs e)
        {
            dgvPatients.DataSource = _patientData.AllPatients;
            comboBoxDummy1.SelectedIndex = 0;
            
        }
    }
}
