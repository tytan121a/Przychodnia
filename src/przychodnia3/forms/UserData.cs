using przychodnia3.models;
using przychodnia3.respositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia3
{
    public partial class UserData : Form
    {
        private User user1;
        public UserData(User user1)
        {
            InitializeComponent();
            this.user1 = user1;
            DataUser(user1);
        }
        public void DataUser(User user)
        {
            var repoAddress = new AddressRespository();
            Adres userAdres = repoAddress.GetAddress(user.IdAdresu);

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

            var repoGender = new GenderRespository();
            this.plec.Text = repoGender.GetGenderName(user.IdPlci);

            var repoRole = new RoleRespository();
            this.rola.Text = repoRole.GetRoleName(user.IdRoli);
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void zapomnij_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Czy na pewno chcesz zapomnieć tego użytkownika?", "Zapomnienie Użytkownika", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                User user = new User();
                user.IdUzytkownika = user1.IdUzytkownika;
                user.Login = this.login.Text;
                user.Haslo = this.haslo.Text;
                user.Imie = this.imie.Text;
                user.Nazwisko = this.nazwisko.Text;

                var repoAddress = new AddressRespository();
                repoAddress.ForgetAddress(user1.IdAdresu, this.miejscowosc.Text, this.kodPocztowy.Text, this.ulica.Text, this.numerPosesji.Text, this.numerLokalu.Text);

                user.Pesel = this.pesel.Text;
                user.DataUrodzenia = this.dataUrodzenia.Value;

                var repoGender = new GenderRespository();
                user.IdPlci = repoGender.GetGenderId(this.plec.Text);

                user.Email = this.email.Text;
                user.NrTelefonu = this.numerTelefonu.Text;

                var repoRole = new RoleRespository();
                user.IdRoli = repoRole.GetRoleId(this.rola.Text);

                var repo = new UserRespository();
                repo.ForgetUser(user);

                this.DialogResult = DialogResult.OK;
            }
        }
    }
    
}
