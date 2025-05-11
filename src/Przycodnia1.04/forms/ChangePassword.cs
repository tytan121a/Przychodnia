using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Przychodnia.repositories;
using Przychodnia.functions;

namespace Przychodnia.forms
{
    public partial class ChangePassword : Form
    {
        private string login;
        public ChangePassword(string login)
        {
            InitializeComponent();
            this.login = login;
        }


        private void NewPassword_Click(object sender, EventArgs e)
        {
            if (!validateLogin())
            {
                return;
            }
            if(NewPass.Text != RepeatPass.Text)
            {
                MessageBox.Show("Podane hasła różnią się od siebie.");
                return;
            }
            var validPass = new Password();
            if (!validPass.ValidatePassword(NewPass.Text))
            {
                return;
            }
            var repoPass = new PasswordRepository();

            repoPass.ChangePassword(this.login, NewPass.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool validateLogin()
        {
            if (string.IsNullOrWhiteSpace(this.NewPass.Text))
            {
                MessageBox.Show("Pole Nowe hasło jest wymagane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(this.RepeatPass.Text))
            {
                MessageBox.Show("Pole Powtórz hasło jest wymagane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
