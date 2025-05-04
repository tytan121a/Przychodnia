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

namespace przychodnia3.models
{
    public partial class ManageRights : Form
    {
        public ManageRights()
        {
            InitializeComponent();

            var repoRole = new RoleRespository();
            foreach (Role rola in repoRole.GetRole())
            {
                this.rola.Items.Add(rola.NazwaRoli);
            }
        }
        public void FillUserRight(int idRoli)
        {
            var repoRights = new RightsRepository();
            List<String> upr = repoRights.GetRoleRights(idRoli); 
            this.Id1.Checked = upr.Contains("Add");
            this.Id2.Checked = upr.Contains("Edit");
            this.Id3.Checked = upr.Contains("ShowUsers");
            this.Id4.Checked = upr.Contains("Search");
            this.Id5.Checked = upr.Contains("Forget");
            this.Id6.Checked = upr.Contains("SearchForgot");
            this.Id7.Checked = upr.Contains("ShowUserData");
            this.Id8.Checked = upr.Contains("GrantRight");
            this.Id9.Checked = upr.Contains("ShowRights");
            this.Id10.Checked = upr.Contains("ShowUsersWithRight");

        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void rola_SelectedIndexChanged(object sender, EventArgs e)
        {
            var repo = new RoleRespository();
            var idRoli = repo.GetRoleId(this.rola.Text);
            FillUserRight(idRoli);
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            if (this.rola.SelectedItem == null)
            {
                MessageBox.Show("Wybierz role do edycji");
                return;
            }
            List<int> uprId = new List<int>();
            if (this.Id1.Checked == true) uprId.Add(1);
            if (this.Id2.Checked == true) uprId.Add(2);
            if (this.Id3.Checked == true) uprId.Add(3);
            if (this.Id4.Checked == true) uprId.Add(4);
            if (this.Id5.Checked == true) uprId.Add(5);
            if (this.Id6.Checked == true) uprId.Add(6);
            if (this.Id7.Checked == true) uprId.Add(7);
            if (this.Id8.Checked == true) uprId.Add(8);
            if (this.Id9.Checked == true) uprId.Add(9);
            if (this.Id10.Checked == true) uprId.Add(10);

            var repoRights = new RightsRepository();
            var repoRole = new RoleRespository();

            repoRights.UpdateRoleRights(repoRole.GetRoleId(this.rola.Text), uprId);
            
            this.DialogResult = DialogResult.OK;

        }
    }
}
