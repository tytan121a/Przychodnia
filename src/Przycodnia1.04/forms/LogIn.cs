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
using Przychodnia.models;
using Przychodnia.functions;

namespace Przychodnia.forms
{
    public partial class LogIn : Form
    {
        public string login;
        public LogIn()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validateLogin()) {
                return;
            }
            
            var repoUser = new UserRepository();
            User user = repoUser.GetUserByLogin(this.logint.Text);
            if (user == null) {
                MessageBox.Show("Podany login nie istnieje w systemie. Sprawdź dane i spróbuj ponownie.");
                return;
            }
            if (user.Haslo != this.pass.Text)
            {
                MessageBox.Show($"Niepoprawne hasło. Pozostały 2 próby logowania");
                return;
            }
            login = this.logint.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private bool validateLogin()
        {
            if (string.IsNullOrWhiteSpace(this.logint.Text))
            {
                MessageBox.Show("Pole login jest wymagane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(this.pass.Text))
            {
                MessageBox.Show("Pole haslo jest wymagane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }



    }
}
