using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receptionist_app_winforms
{
    public class PatientData
    {
        public class PatientModel
        {
            public string FullName { get; set; }

            public string Address { get; set; }

            public string Phone { get; set; }

            public int Age { get; set; }

            public DateTime DateOfBirth { get; set; }

            public PatientModel() { FullName = string.Empty; Address = string.Empty; Phone = string.Empty; Age = 0; DateOfBirth = DateTime.MinValue; }
        }


        private List<PatientModel> _patients;

        public List<PatientModel> AllPatients { get { return _patients; } }

        public PatientData()
        {
            _patients = new List<PatientModel>();
            _patients.Add(new PatientModel { FullName = "John Doe", Address = "123 Wallaby Ln", Age = 23, DateOfBirth = DateTime.Now.AddYears(-23), Phone = "111-222-3333" });
            _patients.Add(new PatientModel { FullName = "John Doe 2", Address = "123 Wallaby Ln", Age = 23, DateOfBirth = DateTime.Now.AddYears(-23), Phone = "111-222-3333" });
            _patients.Add(new PatientModel { FullName = "John Doe 3", Address = "123 Wallaby Ln", Age = 23, DateOfBirth = DateTime.Now.AddYears(-23), Phone = "111-222-3333" });
            _patients.Add(new PatientModel { FullName = "John Doe 4", Address = "123 Wallaby Ln", Age = 23, DateOfBirth = DateTime.Now.AddYears(-23), Phone = "111-222-3333" });
            _patients.Add(new PatientModel { FullName = "John Doe 5", Address = "123 Wallaby Ln", Age = 23, DateOfBirth = DateTime.Now.AddYears(-23), Phone = "111-222-3333" });
            _patients.Add(new PatientModel { FullName = "John Doe 6", Address = "123 Wallaby Ln", Age = 23, DateOfBirth = DateTime.Now.AddYears(-23), Phone = "111-222-3333" });
            _patients.Add(new PatientModel { FullName = "John Doe 7", Address = "123 Wallaby Ln", Age = 23, DateOfBirth = DateTime.Now.AddYears(-23), Phone = "111-222-3333" });
        }
    }
}
