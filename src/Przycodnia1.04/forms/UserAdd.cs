using Przychodnia.models;
using Przychodnia.functions;
using Przychodnia.repositories;
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

namespace Przychodnia.forms
{
    public partial class UserAdd : UserControl
    {
        public UserAdd()
        {
            InitializeComponent();
            var repoGender = new GenderRepository();
            foreach (Gender plec in repoGender.GetGenders())
            {
                this.plec.Items.Add(plec.Plec);
            }

            var repoRole = new RoleRepository();
            foreach (Role rola in repoRole.GetRole())
            {
                this.rola.Items.Add(rola.NazwaRoli);
            }
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

        private void Zapisz_Click(object sender, EventArgs e)
        {
            var pass = new Password();
            var repoAddress = new AddressRepository();
            var repoGender = new GenderRepository();
            var repoRole = new RoleRepository();
            var repoUser = new UserRepository();
            var repoPass = new PasswordRepository();

            if (!ValidateInput()) return;
            
            if (!pass.ValidatePassword(this.haslo.Text)) return;
            Address adres = new Address();
            adres.Miejscowosc = this.miejscowosc.Text;
            adres.KodPocztowy = this.kodPocztowy.Text;
            adres.Ulica = this.ulica.Text;
            adres.NrPosesji = this.numerPosesji.Text;
            adres.NrLokalu = this.numerLokalu.Text;
            repoAddress.CreateAddress(adres);

            int addressID = repoAddress.GetAddressId(adres.Miejscowosc, adres.KodPocztowy, adres.Ulica, adres.NrPosesji, adres.NrLokalu);
            if (addressID == -1) return;

            User user = new User();
            user.Login = this.login.Text;
            user.Haslo = this.haslo.Text;
            user.Imie = this.imie.Text;
            user.Nazwisko = this.nazwisko.Text;
            user.IdAdresu = addressID;
            user.Pesel = this.pesel.Text;
            user.DataUrodzenia = this.dataUrodzenia.Value;
            user.IdPlci = repoGender.GetGenderId(this.plec.Text);
            user.Email = this.email.Text;
            user.NrTelefonu = this.numerTelefonu.Text;
            user.IdRoli = repoRole.GetRoleId(this.rola.Text);

            repoUser.CreateUser(user);


            User user1 = repoUser.GetUserByLogin(this.login.Text);
            repoPass.PutPasswordToHistory(user1.IdUzytkownika, this.haslo.Text);

        }


        private bool ValidateInput()
        {
            var repo = new UserRepository();
            if (repo.LoginExist(this.login.Text))
            {
                MessageBox.Show("Login jest już zajęty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (repo.PeselExist(this.pesel.Text))
            {
                MessageBox.Show("Użytkownik o zadanym peselu już istnieje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (repo.EmailExist(this.email.Text))
            {
                MessageBox.Show("Użytkownik o zadanym emailu już istnieje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
            if (this.plec.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz płeć", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.rola.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz role", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var valid = new validation();
            var repoGender = new GenderRepository();
            if (!valid.validatePESEL(this.pesel.Text, this.dataUrodzenia.Value, repoGender.GetGenderId(this.plec.Text)))
            {
                MessageBox.Show("Numer pesel jest niepoprawny", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
