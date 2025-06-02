using Przychodnia.models;
using Przychodnia.repositories;
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
    public partial class PatientEdit : UserControl
    {
        //public Patient patient;
        //public PatientEdit(Patient patient)
        public PatientEdit()
        {
            InitializeComponent();
            var repoRole = new RoleRepository();
            foreach (Role rola in repoRole.GetRole())
            {
                this.Gender.Items.Add(rola.NazwaRoli);
            }

            //this.patient = patient;
            //EditPatient(patient);

        }

        //Funkcja uzupelniajaca formularz danymi uzytkownika
        public void EditPatient(Patient patient)
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


        //Obsługa zapisu do bazy 
        private void Save_Click(object sender, EventArgs e)
        {

        }

        //Walidacja formularza
        public bool ValidateInput()
        {
            return true;
        }
    }
}
