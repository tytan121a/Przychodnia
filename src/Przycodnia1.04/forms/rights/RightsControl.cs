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
            if (this.RightsDataTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego uprawnienia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<int> uprIds = new List<int>();

            foreach (DataGridViewRow row in this.RightsDataTable.SelectedRows)
            {
                if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int id))
                {
                    uprIds.Add(id);
                }
            }

            var repoRights = new RightsRepository();
            List<int> roleWithRights = repoRights.GetRoleWithRights(uprIds);

            UsersWithRights control = new UsersWithRights(roleWithRights);

            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control);
            }
        }
    }
}
