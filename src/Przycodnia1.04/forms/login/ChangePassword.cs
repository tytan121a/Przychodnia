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
using Przychodnia.models;

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
            if (!validateTB()) return;
            
            if(NewPass.Text != RepeatPass.Text)
            {
                MessageBox.Show("Hasła nie są identyczne. Wprowadź ponownie.");
                return;
            }

            var pass = new Password();
            if (!pass.ValidatePassword(NewPass.Text)) return;
       
            var repoPass = new PasswordRepository();

            //Sprawdzenie czy haslo rozni sie od 3 poprzednich
            var repoUser = new UserRepository();
            User user = repoUser.GetUserByLogin(login);

            List<string> passwords = repoPass.LastThreePasswords(user.IdUzytkownika);
            if (passwords.Contains(NewPass.Text))
            {
                MessageBox.Show("Nowe hasło nie może być jednym z trzech ostatnich używanych haseł");
                return;
            }
            
            repoPass.ChangePassword(this.login, NewPass.Text);
            repoPass.PutPasswordToHistory(user.IdUzytkownika, NewPass.Text);
            MessageBox.Show("Hasło zostało pomyślnie zmienione. Możesz teraz zalogować się przy jego użyciu.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool validateTB()
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
