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
            var repoPass = new PasswordRepository();

            User user = repoUser.GetUserByLogin(this.logint.Text);
            if (user == null) {
                MessageBox.Show("Podany login nie istnieje w systemie. Sprawdź dane i spróbuj ponownie.");
                return;
            }
            if (user.ZablokowaneDo != null && user.ZablokowaneDo > DateTime.Now)
            {
                MessageBox.Show($"Twoje konto jest zablokowane do: " + user.ZablokowaneDo);
                return;

            }

            login = this.logint.Text;
            if (user.Haslo != this.pass.Text)
            {
                repoPass.IncreaseUncorrect(login);
                var uncorrect = repoPass.GetNumOfUncorrectPass(login);
                if (uncorrect == 3)
                {
                    repoPass.BlockLogin(login);
                    repoPass.SetUncorrectToZero(login);
                    MessageBox.Show("Twoje konto zostało tymczasowo zablokowane z powodu 3 nieudanych prób logowania. Spróbuj ponownie później");
                }
                else
                {
                    MessageBox.Show($"Niepoprawne hasło. Pozostało {3 - uncorrect} prób logowania");
                }
                return;
            }
            if(user.HasloOstatnioZmienione)
            {
                ChangePassword form = new ChangePassword(login);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            repoPass.SetUncorrectToZero(login);
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

        private void recover_Click(object sender, EventArgs e)
        {
            RecoverForm form = new RecoverForm();
            form.ShowDialog();
        }
    }
}
