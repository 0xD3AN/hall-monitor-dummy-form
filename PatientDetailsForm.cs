using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace receptionist_app_winforms
{
    public partial class PatientDetailsForm : Form
    {
        private PatientData.PatientModel _model;

        private static Random _rnd = new Random();
        private static readonly int _minDelayMS = int.Parse(ConfigurationManager.AppSettings["MinDetailsDelayMS"]!);
        private static readonly int _maxDelayMS = int.Parse(ConfigurationManager.AppSettings["MaxDetailsDelayMS"]!);

        public PatientDetailsForm(PatientData.PatientModel model)
        {
            InitializeComponent();

            _model = model;
        }

        private void PatientDetailsForm_Load(object sender, EventArgs e)
        {
            // set window title
            this.Text = string.Format("Details for:   {0}", _model.FullName);

            // random delay
            var delayMS = _rnd.Next(_minDelayMS, _maxDelayMS);
            System.Threading.Thread.Sleep(delayMS);

            // show data
            tbFullName.Text = _model.FullName;
            tbAddress.Text = _model.Address;
            tbPhone.Text = _model.Phone;
            tbAge.Text = _model.Age.ToString();
            tbDateOfBirth.Text = _model.DateOfBirth.ToString("M/d/yyyy");
        }
    }
}
