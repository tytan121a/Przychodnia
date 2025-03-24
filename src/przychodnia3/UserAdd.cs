using przychodnia3.models;
using przychodnia3.respositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            this.plec.Items.Add("Mężczyzna");
            this.plec.Items.Add("Kobieta");

            this.rola.Items.Add("Pacjent");
            this.rola.Items.Add("Recepcjonista");
            this.rola.Items.Add("Admin");

        }

        private void dataUrodzenia_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(this.login.Text) || this.login.Text.Length < 3)
            {
                MessageBox.Show("Login musi mieć co najmniej 3 znaki.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(this.login.Text, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Login może zawierać tylko litery i cyfry!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(this.haslo.Text, "^(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,15}$"))
            {
                MessageBox.Show("Hasło musi mieć 8-15 znaków, min. 1 dużą literę, cyfrę i znak specjalny!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(this.imie.Text) || this.imie.Text.Length < 2)
            {
                MessageBox.Show("Imię musi mieć co najmniej 2 znaki.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(this.nazwisko.Text) || this.nazwisko.Text.Length < 2)
            {
                MessageBox.Show("Nazwisko musi mieć co najmniej 2 znaki.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(this.pesel.Text, "^\\d{11}$"))
            {
                MessageBox.Show("PESEL musi składać się z 11 cyfr!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(this.email.Text, "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$"))
            {
                MessageBox.Show("Podaj poprawny adres email!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(this.numerTelefonu.Text, "^\\d{9}$"))
            {
                MessageBox.Show("Numer telefonu musi składać się z 9 cyfr!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(this.kodPocztowy.Text, "^\\d{2}-\\d{3}$"))
            {
                MessageBox.Show("Kod pocztowy musi mieć format XX-XXX!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(this.miejscowosc.Text) || this.miejscowosc.Text.Length < 2)
            {
                MessageBox.Show("Miejscowość musi mieć co najmniej 2 znaki.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(this.numerPosesji.Text))
            {
                MessageBox.Show("Numer posesji nie może być pusty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.plec.SelectedIndex==-1)
            {
                MessageBox.Show("Wybierz płeć", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.rola.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz role", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void Zapisz_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
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

        private void numerTelefonu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
