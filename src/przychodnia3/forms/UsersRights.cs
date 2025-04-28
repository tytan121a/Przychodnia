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

namespace przychodnia3.forms
{
    public partial class UsersRights : Form
    {
        public UsersRights(String uprName, List<int> roleId)
        {
            InitializeComponent();
            this.title2.Text = uprName;
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


            var repo = new UserRespository();

            var users = repo.GetUsersByRoles(roleid);


            foreach (var user in users)
            {
                var row = dataTable.NewRow();

                row["Numer uzytkownika"] = user.IdUzytkownika;
                row["Użytkownik"] = user.Imie + " " + user.Nazwisko;
                row["Email"] = user.Email;
                row["Numer Telefonu"] = user.NrTelefonu;

                var repoRole = new RoleRespository();
                row["Rola"] = repoRole.GetRoleName(user.IdRoli);

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
