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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

            this.plec.Items.Add("Mezczyzna");
            this.plec.Items.Add("Kobieta");

            this.rola.Items.Add("Pacjent");
            this.rola.Items.Add("Recepcjonista");
            this.rola.Items.Add("Admin");

        }

        private void dataUrodzenia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            Adres adres = new Adres();
            adres.Miejscowosc = this.miejscowosc.Text;
            adres.KodPocztowy = this.kodPocztowy.Text;
            adres.Ulica = this.ulica.Text;
            adres.NrPosesji = this.numerPosesji.Text;
            adres.NrLokalu = this.numerLokalu.Text;
            var repoAdres = new AddressRespository();
            repoAdres.CreateAddress(adres);

            int addressID = repoAdres.GetAddressId(adres.Miejscowosc, adres.KodPocztowy, adres.Ulica, adres.NrPosesji, adres.NrLokalu);
            if(addressID != -1)
            {
                User user = new User();
                user.Login = this.login.Text;
                user.Haslo = this.haslo.Text;
                user.Imie = this.imie.Text;
                user.Nazwisko = this.nazwisko.Text;
                user.IdAdresu = addressID;
                user.Pesel = this.pesel.Text;
                user.DataUrodzenia = this.dataUrodzenia.Value;

                var repoGender = new GenderRespository();
                user.IdPlci = repoGender.GetGenderId(this.plec.Text);

                user.Email = this.email.Text;
                user.NrTelefonu = this.numerTelefonu.Text;
                
                var repoRole = new RoleRespository();
                user.IdRoli = repoRole.GetRoleId(this.rola.Text);


                var repo = new UserRespository();
                repo.CreateUser(user);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                return;
            }

            
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;

        }
    }
}
