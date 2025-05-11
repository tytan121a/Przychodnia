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
    public partial class UserEdit : UserControl
    {
        private User user1;

        public UserEdit(User user1)
        {

            InitializeComponent();
            this.user1 = user1;

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


            EditUser(user1);
        }
        public void EditUser(User user)
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

        private void Zapisz_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            Password pass = new Password();
            if (!pass.ValidatePassword(this.haslo.Text)) return;
            User user = new User();
            user.IdUzytkownika = user1.IdUzytkownika;
            user.Login = this.login.Text;
            user.Haslo = this.haslo.Text;
            user.Imie = this.imie.Text;
            user.Nazwisko = this.nazwisko.Text;

            var repoAddress = new AddressRepository();
            repoAddress.UpdateAddress(user1.IdAdresu, this.miejscowosc.Text, this.kodPocztowy.Text, this.ulica.Text, this.numerPosesji.Text, this.numerLokalu.Text);

            user.Pesel = this.pesel.Text;
            user.DataUrodzenia = this.dataUrodzenia.Value;

            var repoGender = new GenderRepository();
            user.IdPlci = repoGender.GetGenderId(this.plec.Text);

            user.Email = this.email.Text;
            user.NrTelefonu = this.numerTelefonu.Text;

            var repoRole = new RoleRepository();
            user.IdRoli = repoRole.GetRoleId(this.rola.SelectedItem.ToString());

            var repo = new UserRepository();
            repo.UpdateUser(user);
            MessageBox.Show("Dane zostały pomyślnie zaktualizowane");

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
