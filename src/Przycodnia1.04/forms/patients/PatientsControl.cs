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
    public partial class PatientsControl : UserControl
    {
        public PatientsControl()
        {
            InitializeComponent();
            this.Load += PatientsControl_Load;
        }

        private void PatientsControl_Load(object sender, EventArgs e)
        {
            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                var id = appForm.RoleId;

                var repoRights = new RightsRepository();
                List<string> rights = repoRights.GetRoleRights(id);

                if (rights.Contains("ShowPatients")) ReadPatients();
                if (!rights.Contains("AddPatient")) this.addPatient.Visible = false;
                if (!rights.Contains("EditPatient")) this.editPatient.Visible = false;
                if (!rights.Contains("SearchPatients"))
                {
                    this.searchButton.Visible = false;
                    this.searchText.Visible = false;
                }
                if (!rights.Contains("ShowPatientData")) this.PatientDataButton.Visible = false;

            }
            else
            {
                MessageBox.Show("Nie udało się uzyskać referencji do formularza App");
            }
        }

        //Pobranie listy pacjentow i uzupelnienie tabeli
        private void ReadPatients()
        {
        }

        private void addPatient_Click(object sender, EventArgs e)
        {
            PatientAdd control = new PatientAdd();

            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control);
            }
        }

        private void editPatient_Click(object sender, EventArgs e)
        {
            if (this.PatientsList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var val = this.PatientsList.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null) return;
            int patientId = int.Parse(val);

            var repo = new PatientRepository();
            //var user = repo.GetPatient(patientId);
            //if (patient == null) return;

            PatientEdit control = new PatientEdit();
            //PatientEdit control = new PatientEdit(patient);

            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control);
            }
        }

        private void PatientDataButton_Click(object sender, EventArgs e)
        {
            if (this.PatientsList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var val = this.PatientsList.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null) return;
            int patientId = int.Parse(val);

            var repo = new PatientRepository();
            //var patient = repo.GetPatient(patientId);
            //if (patient == null) return;
            
            PatientData control = new PatientData();
            //PatientData control = new PatientData(patient);
            
            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control);
            }

        }

        //wyszukanie uzytkownikokow przy uzyciu Funkja1 i utoworzenie tabeli
        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
