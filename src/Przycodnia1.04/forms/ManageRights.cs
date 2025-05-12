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
    public partial class ManageRights : UserControl
    {
        public ManageRights()
        {
            InitializeComponent();
            var repoRole = new RoleRepository();
            foreach (Role rola in repoRole.GetRole())
            {
                this.role.Items.Add(rola.NazwaRoli);
            }
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

                if (!rights.Contains("GrantRight")) this.Save.Visible = false;
            }
            else
            {
                MessageBox.Show("Nie udało się uzyskać referencji do formularza App");
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
            RightsControl control = new RightsControl();

            var appForm = this.FindForm() as App;
            if (appForm != null)
            {
                appForm.LoadToPanel(control);
            }
        }

        private void rola_SelectedIndexChanged(object sender, EventArgs e)
        {
            var repo = new RoleRepository();
            var idRoli = repo.GetRoleId(this.role.Text);
            FillUserRight(idRoli);

        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            if (this.role.SelectedItem == null)
            {
                MessageBox.Show("Wybierz role do edycji");
                return;
            }
            if (Id1.Checked == false && Id2.Checked == false && Id3.Checked == false && Id4.Checked == false && Id5.Checked == false && Id6.Checked == false && Id7.Checked == false && Id8.Checked == false && Id9.Checked == false && Id10.Checked == false)
            {
                MessageBox.Show("Użytkownik musi posiadać przynajmniej jedno uprawnienie");
                return;

            }
            List<int> uprIds = new List<int>();
            if (this.Id1.Checked == true) uprIds.Add(1);
            if (this.Id2.Checked == true) uprIds.Add(2);
            if (this.Id3.Checked == true) uprIds.Add(3);
            if (this.Id4.Checked == true) uprIds.Add(4);
            if (this.Id5.Checked == true) uprIds.Add(5);
            if (this.Id6.Checked == true) uprIds.Add(6);
            if (this.Id7.Checked == true) uprIds.Add(7);
            if (this.Id8.Checked == true) uprIds.Add(8);
            if (this.Id9.Checked == true) uprIds.Add(9);
            if (this.Id10.Checked == true) uprIds.Add(10);

            var repoRights = new RightsRepository();
            var repoRole = new RoleRepository();
            MessageBox.Show("Zapisano zmiany");
            repoRights.UpdateRoleRights(repoRole.GetRoleId(this.role.Text), uprIds);
        }
    }
}
