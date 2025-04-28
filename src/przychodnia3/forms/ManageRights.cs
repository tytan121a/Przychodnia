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

        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void rola_SelectedIndexChanged(object sender, EventArgs e)
        {
            var repo = new RightsRepository();
            var role = repo.GetRoleRights();

            if (rola.Text == "Admin")
            {
                
            }
            if (rola.Text == "Pacjent")
            {

            }
            if(rola.Text == "Recepcjonista")
            {

            }
        }
    }
}
