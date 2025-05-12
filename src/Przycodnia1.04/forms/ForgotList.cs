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
    public partial class ForgotList : UserControl
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

            var repo = new UserRepository();
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
            this.ForgotUsersList.DataSource = dataTable;
        }

        private void Cofnij_Click(object sender, EventArgs e)
        {
            UsersControl control = new UsersControl();

            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control);
            }
        }
    }
}
