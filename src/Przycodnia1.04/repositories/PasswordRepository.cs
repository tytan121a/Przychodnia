using Przychodnia.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia.repositories
{
    public class PasswordRepository
    {
        private readonly string connectionString = "Server=tcp:przychodnia3.database.windows.net,1433;Initial Catalog=przychodnia3;Persist Security Info=False;User ID=przychodnia3;Password=Testowanie3!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public int GetNumOfUncorrectPass(string login)
        {
            var repoUser = new UserRepository();
            User user = repoUser.GetUserByLogin(login);
            return user.BledneLogowania;
        }

        public void SetUncorrectToZero(string login)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Tbl_Uzytkownicy SET  BledneLogowania=0  WHERE Login = @Login";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd blokowania logowania" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void IncreaseUncorrect(string login)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Tbl_Uzytkownicy SET BledneLogowania = BledneLogowania + 1 WHERE Login = @Login";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zwiększania liczby błędnych logowań: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BlockLogin(string login)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Tbl_Uzytkownicy SET  ZablokowaneDo=@ZablokowaneDo  WHERE Login = @Login";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {

                        command.Parameters.AddWithValue("@ZablokowaneDo", DateTime.Now.AddHours(1));
                        command.Parameters.AddWithValue("@Login", login);
                        command.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd blokowania logowania" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ChangePasswordAndFlagChange(string login, string Haslo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Tbl_Uzytkownicy SET Haslo = @Haslo, HasloOstatnioZmienione = 1 WHERE Login = @Login";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@Haslo", Haslo);
                        command.Parameters.AddWithValue("@Login", login);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zmiany hasła: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UnflagPasswordChanged(string login)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Tbl_Uzytkownicy SET HasloOstatnioZmienione = 0 WHERE Login = @Login";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zmiany flagi zmiany hasła: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
