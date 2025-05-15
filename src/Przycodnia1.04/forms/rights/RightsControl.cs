using Przychodnia.forms;
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
    public partial class RightsControl : UserControl
    {
        public RightsControl()
        {
            InitializeComponent();
            this.Load += RightsControl_Load;
        }

        private void RightsControl_Load(object sender, EventArgs e)
        {
            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                var id = appForm.RoleId;

                var repoRights = new RightsRepository();
                List<string> rights = repoRights.GetRoleRights(id);

                if (rights.Contains("ShowRights")) ReadRights();
                if (!rights.Contains("ShowUsersWithRight")) this.UsersWithRightsButton.Visible = false;
                if (!rights.Contains("ShowRoleRights")) this.manageRightsButton.Visible = false;

            }
            else
            {
                MessageBox.Show("Nie udało się uzyskać referencji do formularza App");
            }
        }
        private void ReadRights()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Numer uprawnienia");
            dataTable.Columns.Add("Nazwa uprawnienia");
            dataTable.Columns.Add("Opis uprawnienia");


            var repo = new RightsRepository();
            var uprawnienia = repo.GetRights();


            foreach (var upr in uprawnienia)
            {
                var row = dataTable.NewRow();

                row["Numer uprawnienia"] = upr.IdUprawnienia;
                row["Nazwa uprawnienia"] = upr.Uprawnienie;
                row["Opis uprawnienia"] = upr.OpisUprawnienia;


                dataTable.Rows.Add(row);
            }
            this.RightsDataTable.DataSource = dataTable;
        }

        private void UprawnieniaButton_Click(object sender, EventArgs e)
        {
            ManageRights control = new ManageRights();

            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control); 
            }
        }

        private void UsersWithRightsButton_Click(object sender, EventArgs e)
        {
            var val = this.RightsDataTable.SelectedRows[0].Cells[0].Value.ToString();
            var name = this.RightsDataTable.SelectedRows[0].Cells[2].Value.ToString();
            if (val == null) return;
            int uprId = int.Parse(val);

            var repoRights = new RightsRepository();
            List<int> roleWithRights = repoRights.GetRoleWithRights(uprId);

            UsersWithRights control = new UsersWithRights(name,roleWithRights);

            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control);
            }
        }
    }
}
