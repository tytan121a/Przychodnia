using System;
using System.Windows.Forms;
using Przychodnia.forms;
using Przychodnia.repositories;

namespace Przychodnia
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                using (var loginForm = new LogIn())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        string loggedUser = loginForm.login;
                        var repoUser = new UserRepository();

                        using (var appForm = new App(repoUser.GetUserByLogin(loggedUser)))
                        {
                            var result = appForm.ShowDialog();

                            if (result == DialogResult.Retry)
                            {
                                continue; 
                            }
                            else
                            {
                                break; 
                            }
                        }
                    }
                    else
                    {
                        break; 
                    }
                }
            }
        }
    }
}
