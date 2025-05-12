using Przychodnia.repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Przychodnia.models;
namespace Przychodnia.forms
{
    public partial class App : Form
    {
        private String Name;
        public int RoleId;
        private String RoleName;
        public App(User user)
        {
            InitializeComponent();
            Name = user.Imie;
            RoleId = user.IdRoli;
            var repoRole = new RoleRepository();
            RoleName = repoRole.GetRoleName(RoleId);
            this.WelcomeLabel.Text = $"Witaj, {Name}!";
            this.roleLabel.Text = $"Twoja rola: {RoleName}";
        }

        public void LoadToPanel(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }

        private void PermissionButton_Click(object sender, EventArgs e)
        {
            RightsControl control = new RightsControl();
            LoadToPanel(control);
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            UsersControl control = new UsersControl();
            LoadToPanel(control);
  
        }


        private void logOutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Czy na pewno chcesz się wylogować?",
                "Potwierdzenie wylogowania",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Retry;
                this.Close(); 
            }
            else
            {
                MessageBox.Show(
                    "Anulowano wylogowanie",
                    "Wylogowanie anulowane",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
