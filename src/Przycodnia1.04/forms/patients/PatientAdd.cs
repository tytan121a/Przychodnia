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
    public partial class PatientAdd : UserControl
    {
        public PatientAdd()
        {
            InitializeComponent();
            var repoGender = new GenderRepository();
            foreach (Gender plec in repoGender.GetGenders())
            {
                this.Gender.Items.Add(plec.Plec);
            }
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
