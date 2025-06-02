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

namespace Przychodnia.forms
{
    public partial class UserData : UserControl
    {
        private User user1;

        public UserData(User user1)
        {
            InitializeComponent();
            this.user1 = user1;
            DataUser(user1);
            this.Load += UsersData_Load;
        }

        private void UsersData_Load(object sender, EventArgs e)
        {
            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                var id = appForm.RoleId;

                var repoRights = new RightsRepository();
                List<string> rights = repoRights.GetRoleRights(id);

                if (!rights.Contains("Forget")) this.forget.Visible = false;
            }
            else
            {
                MessageBox.Show("Nie udało się uzyskać referencji do formularza App");
            }
        }

        public void DataUser(User user)
        {
            var repoAddress = new AddressRepository();
            Address userAdres = repoAddress.GetAddress(user.IdAdresu);

            this.login.Text = user.Login;
            this.haslo.Text = user.Haslo;
            this.imie.Text = user.Imie;
            this.nazwisko.Text = user.Nazwisko;
            this.pesel.Text = user.Pesel;
            this.dataUrodzenia.Value = user.DataUrodzenia;
            this.email.Text = user.Email;
            this.numerTelefonu.Text = user.NrTelefonu;

            this.miejscowosc.Text = userAdres.Miejscowosc;
            this.kodPocztowy.Text = userAdres.KodPocztowy;
            this.ulica.Text = userAdres.Ulica;
            this.numerPosesji.Text = userAdres.NrPosesji;
            this.numerLokalu.Text = userAdres.NrLokalu;

            var repoGender = new GenderRepository();
            this.plec.Text = repoGender.GetGenderName(user.IdPlci);

            var repoRole = new RoleRepository();
            this.rola.Text = repoRole.GetRoleName(user.IdRoli);
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            UsersControl control = new UsersControl();

            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control);
            }
        }

        private void zapomnij_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Czy na pewno chcesz zapomnieć tego użytkownika?", "Zapomnienie Użytkownika", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                User user = new User();
                user.IdUzytkownika = user1.IdUzytkownika;
                user.Login = this.login.Text;
                user.Haslo = this.haslo.Text;
                user.Imie = this.imie.Text;
                user.Nazwisko = this.nazwisko.Text;

                var repoAddress = new AddressRepository();
                repoAddress.ForgetAddress(user1.IdAdresu, this.miejscowosc.Text, this.kodPocztowy.Text, this.ulica.Text, this.numerPosesji.Text, this.numerLokalu.Text);

                user.Pesel = this.pesel.Text;
                user.DataUrodzenia = this.dataUrodzenia.Value;

                var repoGender = new GenderRepository();
                user.IdPlci = repoGender.GetGenderId(this.plec.Text);

                user.Email = this.email.Text;
                user.NrTelefonu = this.numerTelefonu.Text;

                var repoRole = new RoleRepository();
                user.IdRoli = repoRole.GetRoleId(this.rola.Text);

                var repo = new UserRepository();
                repo.ForgetUser(user);

            }
        }
    }
}
