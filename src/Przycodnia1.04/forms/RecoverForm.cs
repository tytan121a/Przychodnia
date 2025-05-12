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
using System.Net;
using System.Net.Mail;

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
            Mail5 mail5 = new Mail5();
            string emailBody = $"Witaj {user.Imie},\n\nTwoje nowe hasło to: {pass}";
            mail5.SendEmail(user.Email, "Odzyskiwanie hasła", emailBody);
            //Aktualizacja hasła
            var repoPass = new PasswordRepository();

            repoPass.ChangePasswordAndFlagChange(login, pass);
            repoPass.PutPasswordToHistory(user.IdUzytkownika, pass);

            MessageBox.Show("Nowe hasło zostało wysłane na Twój adres e-mail. " + pass);
        }
    }
}
