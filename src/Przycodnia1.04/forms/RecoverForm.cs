using Przychodnia.functions;
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
    public partial class RecoverForm : Form
    {
        public RecoverForm()
        {
            InitializeComponent();
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            string email = this.emailTB.Text;
            string login = this.loginTB.Text;

            var repoUser = new UserRepository();
            User user = repoUser.GetUserByLogin(login);
            if (user == null)
            {
                MessageBox.Show("Użytkownik o podanym loginie nie istnieje");
                return;
            }
            if(user.Email != email)
            {
                MessageBox.Show("Podany email nie pasuje do użytkownika");
                return;
            }

            Password passGen = new Password();
            string pass = passGen.GeneratePassword();
            //Wysłanie na maila
            //Aktualizacja hasła
            var repoPassword = new PasswordRepository();
            repoPassword.ChangePasswordAndFlagChange(login, pass);
            MessageBox.Show("Nowe hasło zostało wysłane na Twój adres e-mail. " + pass);
        }
    }
}
