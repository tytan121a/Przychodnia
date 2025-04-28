using przychodnia3.forms;
using przychodnia3.models;
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
    public partial class RightsList : Form
    {
        public RightsList()
        {
            InitializeComponent();
            ReadRights();
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
            this.listaUprawnień.DataSource = dataTable;
        }

        private void Cofnij_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Zarzadzaj_Click(object sender, EventArgs e)
        {
            ManageRights form = new ManageRights();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadRights();
            }
        }

        private void Przegląd_Click(object sender, EventArgs e)
        {
            var val = this.listaUprawnień.SelectedRows[0].Cells[0].Value.ToString();
            var name = this.listaUprawnień.SelectedRows[0].Cells[2].Value.ToString();
            if (val == null) return;
            int uprId = int.Parse(val);

            var repoRights = new RightsRepository();
            List<int> roleWithRights = repoRights.GetRoleWithRights(uprId);
            
            UsersRights form = new UsersRights(name, roleWithRights);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadRights();
            }
        }

        private void listaUprawnień_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
