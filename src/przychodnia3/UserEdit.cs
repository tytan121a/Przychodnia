using przychodnia3.models;
using przychodnia3.respositories;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace przychodnia3
{
    public partial class UserEdit : Form
    {
        private User user1;
        public UserEdit(User user1)
        {
            InitializeComponent();
            this.user1 = user1;

            this.plec.Items.Add("Mężczyzna");
            this.plec.Items.Add("Kobieta");

            
            this.rola.Items.Add("Recepcjonista");
            this.rola.Items.Add("Admin");

            EditUser(user1);
        }

        public void EditUser(User user)
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
            return true;
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            User user = new User();
            user.IdUzytkownika = user1.IdUzytkownika;
            user.Login = this.login.Text;
            user.Haslo = this.haslo.Text;
            user.Imie = this.imie.Text;
            user.Nazwisko = this.nazwisko.Text;

            var repoAddress = new AddressRespository();
            repoAddress.UpdateAddress(user1.IdAdresu, this.miejscowosc.Text, this.kodPocztowy.Text, this.ulica.Text, this.numerPosesji.Text, this.numerLokalu.Text);

            user.Pesel = this.pesel.Text;
            user.DataUrodzenia = this.dataUrodzenia.Value;

            var repoGender = new GenderRespository();
            user.IdPlci = repoGender.GetGenderId(this.plec.Text);

            user.Email = this.email.Text;
            user.NrTelefonu = this.numerTelefonu.Text;

            var repoRole = new RoleRespository();
            user.IdRoli = repoRole.GetRoleId(this.rola.Text);

            var repo = new UserRespository();
            repo.UpdateUser(user);

            this.DialogResult = DialogResult.OK;
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
