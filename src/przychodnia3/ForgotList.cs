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
    public partial class ForgotList : Form
    {
        public ForgotList()
        {
            InitializeComponent();
            ReadUsers();
        }

        private void ReadUsers()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Numer uzytkownika");
            dataTable.Columns.Add("Użytkownik");
            dataTable.Columns.Add("Data Zapomnienia");
            dataTable.Columns.Add("Id Zapominającego");

            var repo = new UserRespository();
            var users = repo.SearchForgotUsers();


            foreach (var user in users)
            {
                var row = dataTable.NewRow();

                row["Numer uzytkownika"] = user.IdUzytkownika;
                row["Użytkownik"] = user.Imie + " " + user.Nazwisko;
                row["Data Zapomnienia"] = user.DataZapomnienia.Value.ToString("dd-MM-yyyy");
                row["Id Zapominającego"] = user.KtoZapomnial;
                

                dataTable.Rows.Add(row);
            }
            this.listaUzytkownikow.DataSource = dataTable;
        }

        private void Cofnij_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
