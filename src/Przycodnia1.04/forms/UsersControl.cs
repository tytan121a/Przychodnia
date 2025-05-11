using Przychodnia.repositories;
using Przychodnia.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Przychodnia.functions;
using Przychodnia.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Przychodnia.forms
{
    public partial class UsersControl : UserControl
    {
        public UsersControl()
        {
            InitializeComponent();
            ReadUsers();
        }
        private void ReadUsers()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Numer uzytkownika");
            dataTable.Columns.Add("Użytkownik");
            dataTable.Columns.Add("Data Urodzenia");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Numer Telefonu");

            var repo = new UserRepository();
            var users = repo.GetUsers();


            foreach (var user in users)
            {
                var row = dataTable.NewRow();

                row["Numer uzytkownika"] = user.IdUzytkownika;
                row["Użytkownik"] = user.Imie + " " + user.Nazwisko;
                row["Data Urodzenia"] = user.DataUrodzenia.ToString("dd-MM-yyyy");
                row["Email"] = user.Email;
                row["Numer Telefonu"] = user.NrTelefonu;

                dataTable.Rows.Add(row);
            }
            this.listaUzytkownikow.DataSource = dataTable;
        }

        private void ZapomnianiUzytkownicy_Click(object sender, EventArgs e)
        {
            ForgotList control = new ForgotList();

            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control);
            }
        }


        private void Podglad_Click(object sender, EventArgs e)
        {
            var val = this.listaUzytkownikow.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null) return;
            int clientId = int.Parse(val);

            var repo = new UserRepository();
            var user = repo.GetUser(clientId);
            if (user == null) return;
            UserData control = new UserData(user);

            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control);
            }
        }

        private void dodajUzytkownikow_Click(object sender, EventArgs e)
        {
            UserAdd control = new UserAdd();

            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control);
            }
        }

        private void edytujUzytkownikow_Click(object sender, EventArgs e)
        {
            var val = this.listaUzytkownikow.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null) return;
            int clientId = int.Parse(val);

            var repo = new UserRepository();
            var user = repo.GetUser(clientId);
            if (user == null) return;

            UserEdit control = new UserEdit(user);

            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control);
            }
        }

        private void wyszukajButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Numer uzytkownika");
            dataTable.Columns.Add("Użytkownik");
            dataTable.Columns.Add("Data Urodzenia");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Numer Telefonu");

            string searchText = wyszukajText.Text.Trim();
            var repo = new UserRepository();
            var users = repo.SearchUsers(searchText);

            foreach (var user in users)
            {
                var row = dataTable.NewRow();

                row["Numer uzytkownika"] = user.IdUzytkownika;
                row["Użytkownik"] = user.Imie + " " + user.Nazwisko;
                row["Data Urodzenia"] = user.DataUrodzenia.ToString("dd-MM-yyyy");
                row["Email"] = user.Email;
                row["Numer Telefonu"] = user.NrTelefonu;

                dataTable.Rows.Add(row);
            }
            listaUzytkownikow.DataSource = dataTable;
        }

        private void ForceRecoverPass_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Czy na pewno chcesz wymusić zmianę hasła tego użytkownika?", "Wymuszenie Zmiany Hasła", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var val = this.listaUzytkownikow.SelectedRows[0].Cells[0].Value.ToString();
                if (val == null) return;
                int clientId = int.Parse(val);

                var repoUser = new UserRepository();
                User user = repoUser.GetUser(clientId);
                if (user == null)
                {
                    MessageBox.Show("Użytkownik o podanym loginie nie istnieje");
                    return;
                }

                Password passGen = new Password();
                string pass = passGen.GeneratePassword();
                //Wysłanie na maila
                //Aktualizacja hasła
                var repoPassword = new PasswordRepository();
                repoPassword.ChangePasswordAndFlagChange(user.Login, pass);
                MessageBox.Show("Nowe hasło zostało wysłane na adres e-mail użytkownika." + pass);
            }
        }
    }
}
