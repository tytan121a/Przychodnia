using przychodnia3.models;
using przychodnia3.respositories;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia3
{
    public partial class UserList : Form
    {
        public UserList()
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

            var repo = new UserRespository();
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


        private void button1_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadUsers();
            }
        }



        

        private void edytujUzytkownikow_Click(object sender, EventArgs e)
        {
            var val = this.listaUzytkownikow.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null) return;
            int clientId = int.Parse(val);

            var repo = new UserRespository();
            var user = repo.GetUser(clientId);
            if (user == null) return;

            UserEdit form = new UserEdit(user);
            if (form.ShowDialog() == DialogResult.OK)
            {

                ReadUsers();
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
                var repo = new UserRespository();
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
        private void wyszukajText_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaUzytkownikow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Podglad_Click(object sender, EventArgs e)
        {
            var val = this.listaUzytkownikow.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null) return;
            int clientId = int.Parse(val);

            var repo = new UserRespository();
            var user = repo.GetUser(clientId);
            if (user == null) return;

            UserData form = new UserData(user);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadUsers();
            }
        }

        private void ZapomnianiUzytkownicy_Click(object sender, EventArgs e)
        {
            ForgotList form = new ForgotList();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadUsers();
            }
        }
    }
}
