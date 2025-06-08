using Przychodnia.models;
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
    public partial class UsersWithRights : UserControl
    {
        public UsersWithRights(List<int> roleId)
        {
            InitializeComponent();
            ReadUsers(roleId);
        }


        private void ReadUsers(List<int> roleid)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Numer uzytkownika");
            dataTable.Columns.Add("Użytkownik");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Numer Telefonu");
            dataTable.Columns.Add("Rola");


            var repo = new UserRepository();

            var users = repo.GetUsersByRoles(roleid);


            foreach (var user in users)
            {
                var row = dataTable.NewRow();

                row["Numer uzytkownika"] = user.IdUzytkownika;
                row["Użytkownik"] = user.Imie + " " + user.Nazwisko;
                row["Email"] = user.Email;
                row["Numer Telefonu"] = user.NrTelefonu;

                var repoRole = new RoleRepository();
                row["Rola"] = repoRole.GetRoleName(user.IdRoli);

                dataTable.Rows.Add(row);
            }
            this.listaUzytkownikow.DataSource = dataTable;
        }

        private void Cofnij_Click(object sender, EventArgs e)
        {
            RightsControl control = new RightsControl();

            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control);
            }
        }

        private void UsersWithRights_Load(object sender, EventArgs e)
        {

        }
    }
}
