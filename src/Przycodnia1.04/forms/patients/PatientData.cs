using Przychodnia.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia.forms.patients
{
    public partial class PatientData : UserControl
    {
        //private Patient patient;
        //public PatientData(Patient patient)
        public PatientData()
        {
            InitializeComponent();
            //this.patient = patient;
            //DataPatient(patient);
        }

        //Funkcja wypełniajaca formularz danymi uzytkownika
        public void DataPatient(Patient patient)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            PatientsControl control = new PatientsControl();

            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control);
            }
        }

        

    }
}
