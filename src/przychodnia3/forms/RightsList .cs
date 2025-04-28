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
            dataTable.Columns.Add("Nazwa uprawnienia");
            dataTable.Columns.Add("Opis uprawnienia");


            var repo = new RightsRepository();
            var users = repo.GetRights();


            foreach (var user in users)
            {
                var row = dataTable.NewRow();

                row["Nazwa uprawnienia"] = user.Uprawnienie;
                row["Opis uprawnienia"] = user.OpisUprawnienia;


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
            UsersRights form = new UsersRights();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadRights();
            }
        }
    }
}
