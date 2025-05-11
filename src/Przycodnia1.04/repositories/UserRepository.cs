using Przychodnia.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Przychodnia.functions;

namespace Przychodnia.repositories
{
    public class UserRepository
    {
        private readonly string connectionString = "Server=tcp:przychodnia3.database.windows.net,1433;Initial Catalog=przychodnia3;Persist Security Info=False;User ID=przychodnia3;Password=Testowanie3!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public List<User> GetUsers()
        {
            var users = new List<User>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Tbl_Uzytkownicy WHERE CzyZapomniany=0";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User user = new User();
                                user.IdUzytkownika = reader.GetInt32(0);
                                user.Login = reader.GetString(1);
                                user.Haslo = reader.GetString(2);
                                user.Imie = reader.GetString(3);
                                user.Nazwisko = reader.GetString(4);
                                user.IdAdresu = reader.GetInt32(5);
                                user.Pesel = reader.GetString(6);
                                user.DataUrodzenia = reader.GetDateTime(7);
                                user.IdPlci = reader.GetInt32(8);
                                user.Email = reader.GetString(9);
                                user.NrTelefonu = reader.GetString(10);
                                user.CzyZapomniany = reader.GetBoolean(11);
                                user.IdRoli = reader.GetInt32(14);

                                users.Add(user);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania uzytkownikow: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return users;
        }

        public User GetUser(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Tbl_Uzytkownicy WHERE IdUzytkownika=@id";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User user = new User();
                                user.IdUzytkownika = reader.GetInt32(0);
                                user.Login = reader.GetString(1);
                                user.Haslo = reader.GetString(2);
                                user.Imie = reader.GetString(3);
                                user.Nazwisko = reader.GetString(4);
                                user.IdAdresu = reader.GetInt32(5);
                                user.Pesel = reader.GetString(6);
                                user.DataUrodzenia = reader.GetDateTime(7);
                                user.IdPlci = reader.GetInt32(8);
                                user.Email = reader.GetString(9);
                                user.NrTelefonu = reader.GetString(10);
                                user.CzyZapomniany = reader.GetBoolean(11);
                                user.IdRoli = reader.GetInt32(14);

                                return user;
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania uzytkownika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public bool LoginExist(string login)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Tbl_Uzytkownicy WHERE Login=@login";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            return reader.Read();

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania uzytkownika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public bool PeselExist(string pesel)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Tbl_Uzytkownicy WHERE Pesel=@pesel";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@pesel", pesel);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            return reader.Read();

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania uzytkownika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        public bool EmailExist(string email)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Tbl_Uzytkownicy WHERE Email=@email";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            return reader.Read();

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania uzytkownika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public void CreateUser(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO Tbl_Uzytkownicy (Login, Haslo, Imie, Nazwisko, IdAdresu, Pesel, DataUrodzenia, IdPlci, Email, NrTelefonu, CzyZapomniany, DataZapomnienia, KtoZapomnial, IdRoli) VALUES (@Login, @Haslo, @Imie, @Nazwisko, @IdAdresu, @Pesel, @DataUrodzenia, @IdPlci, @Email, @NrTelefonu, 0, null, null, @IdRoli)";


                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@Login", user.Login);
                        command.Parameters.AddWithValue("@Haslo", user.Haslo);
                        command.Parameters.AddWithValue("@Imie", user.Imie);
                        command.Parameters.AddWithValue("@Nazwisko", user.Nazwisko);
                        command.Parameters.AddWithValue("@IdAdresu", user.IdAdresu);
                        command.Parameters.AddWithValue("@Pesel", user.Pesel);
                        command.Parameters.AddWithValue("@DataUrodzenia", user.DataUrodzenia);
                        command.Parameters.AddWithValue("@IdPlci", user.IdPlci);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@NrTelefonu", user.NrTelefonu);
                        command.Parameters.AddWithValue("@IdRoli", user.IdRoli);


                        command.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd tworzenia uzytkownika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void UpdateUser(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Tbl_Uzytkownicy SET Login=@Login, Haslo=@Haslo, Imie=@Imie, Nazwisko=@Nazwisko, Pesel=@Pesel, DataUrodzenia=@DataUrodzenia, IdPlci=@IdPlci, Email=@Email, NrTelefonu=@NrTelefonu, IdRoli=@IdRoli WHERE IdUzytkownika = @id AND CzyZapomniany=0";


                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {

                        command.Parameters.AddWithValue("@id", user.IdUzytkownika);

                        command.Parameters.AddWithValue("@Login", user.Login);
                        command.Parameters.AddWithValue("@Haslo", user.Haslo);
                        command.Parameters.AddWithValue("@Imie", user.Imie);
                        command.Parameters.AddWithValue("@Nazwisko", user.Nazwisko);
                        command.Parameters.AddWithValue("@IdAdresu", user.IdAdresu);
                        command.Parameters.AddWithValue("@Pesel", user.Pesel);
                        command.Parameters.AddWithValue("@DataUrodzenia", user.DataUrodzenia);
                        command.Parameters.AddWithValue("@IdPlci", user.IdPlci);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@NrTelefonu", user.NrTelefonu);
                        command.Parameters.AddWithValue("@IdRoli", user.IdRoli);


                        command.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd tworzenia adresu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public List<User> SearchUsers(string searchText)
        {
            var users = new List<User>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Tbl_Uzytkownicy WHERE (Imie LIKE @search OR Nazwisko LIKE @search) AND CzyZapomniany=0";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@search", "%" + searchText + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User user = new User();
                                user.IdUzytkownika = reader.GetInt32(0);
                                user.Login = reader.GetString(1);
                                user.Haslo = reader.GetString(2);
                                user.Imie = reader.GetString(3);
                                user.Nazwisko = reader.GetString(4);
                                user.IdAdresu = reader.GetInt32(5);
                                user.Pesel = reader.GetString(6);
                                user.DataUrodzenia = reader.GetDateTime(7);
                                user.IdPlci = reader.GetInt32(8);
                                user.Email = reader.GetString(9);
                                user.NrTelefonu = reader.GetString(10);
                                user.CzyZapomniany = reader.GetBoolean(11);
                                user.IdRoli = reader.GetInt32(14);

                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd wyszukiwania użytkowników: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return users;
        }

        public List<User> SearchForgotUsers()
        {
            var users = new List<User>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Tbl_Uzytkownicy WHERE CzyZapomniany=1";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User user = new User();
                                user.IdUzytkownika = reader.GetInt32(0);
                                user.Imie = reader.GetString(3);
                                user.Nazwisko = reader.GetString(4);
                                user.DataZapomnienia = reader.GetDateTime(12);
                                user.KtoZapomnial = reader.GetInt32(13);

                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd wyszukiwania użytkowników: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return users;
        }





        public void ForgetUser(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Tbl_Uzytkownicy SET Imie=@Imie, Nazwisko=@Nazwisko, Pesel=@Pesel, DataUrodzenia=@DataUrodzenia, IdPlci=@IdPlci, Email=@Email, NrTelefonu=@NrTelefonu, CzyZapomniany = 1, DataZapomnienia = @DataZapomnienia, KtoZapomnial=@KtoZapomnial  WHERE IdUzytkownika = @id";
                    var hash = new Hash();

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@id", user.IdUzytkownika);

                        command.Parameters.AddWithValue("@Imie", hash.generateStringHash(20));
                        command.Parameters.AddWithValue("@Nazwisko", hash.generateStringHash(30));
                        command.Parameters.AddWithValue("@Pesel", hash.generateIntHash(11));
                        command.Parameters.AddWithValue("@DataUrodzenia", hash.generateDateHash());
                        command.Parameters.AddWithValue("@IdPlci", 1);
                        command.Parameters.AddWithValue("@Email", hash.generateEmailHash());
                        command.Parameters.AddWithValue("@NrTelefonu", hash.generateIntHash(9));
                        command.Parameters.AddWithValue("@DataZapomnienia", DateTime.Today);
                        command.Parameters.AddWithValue("@KtoZapomnial", 1);


                        command.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapominania użytkownika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public List<User> GetUsersByRoles(List<int> rolesIds)
        {
            List<User> users = new List<User>();

            if (rolesIds == null || rolesIds.Count == 0)
            {
                return users;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Dynamiczne parametry  IN (@p0, @p1, @p2, ...)
                    var parameters = new List<string>();
                    for (int i = 0; i < rolesIds.Count; i++)
                    {
                        parameters.Add("@p" + i);
                    }
                    string param = string.Join(", ", parameters);

                    string sql = $@"
                        SELECT *
                        FROM Tbl_Uzytkownicy
                        WHERE IdRoli IN ({param}) AND CzyZapomniany = 0";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        for (int i = 0; i < rolesIds.Count; i++)
                        {
                            command.Parameters.AddWithValue("@p" + i, rolesIds[i]);
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User user = new User();
                                user.IdUzytkownika = reader.GetInt32(0);
                                user.Imie = reader.GetString(3);
                                user.Nazwisko = reader.GetString(4);
                                user.Email = reader.GetString(9);
                                user.NrTelefonu = reader.GetString(10);
                                user.IdRoli = reader.GetInt32(14);

                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania użytkowników dla ról: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return users;
        }

        public User GetUserByLogin(String login)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Tbl_Uzytkownicy WHERE Login=@Login AND CzyZapomniany=0";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User user = new User();
                                user.IdUzytkownika = reader.GetInt32(0);
                                user.Login = reader.GetString(1);
                                user.Haslo = reader.GetString(2);
                                user.Imie = reader.GetString(3);
                                user.Nazwisko = reader.GetString(4);
                                user.IdAdresu = reader.GetInt32(5);
                                user.Pesel = reader.GetString(6);
                                user.DataUrodzenia = reader.GetDateTime(7);
                                user.IdPlci = reader.GetInt32(8);
                                user.Email = reader.GetString(9);
                                user.NrTelefonu = reader.GetString(10);
                                user.CzyZapomniany = reader.GetBoolean(11);
                                user.IdRoli = reader.GetInt32(14);
                                user.BledneLogowania = reader.GetInt32(15);
                                user.ZablokowaneDo = reader.IsDBNull(16) ? (DateTime?)null : reader.GetDateTime(16);
                                user.HasloOstatnioZmienione = reader.GetBoolean(17);

                                return user;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania uzytkownika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
    }
}
