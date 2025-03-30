using Azure.Identity;
using Microsoft.Data.SqlClient;
using przychodnia3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia3.respositories
{
    public class UserRespository
    {
        private readonly string connectionString = "Server=przychodnia.cnu8c8sis4iy.eu-north-1.rds.amazonaws.com,1433;Database=PrzychodniaDB;User Id=admin;Password=Przychodnia123;TrustServerCertificate=True;";


        public List<User> GetUsers()
        {
            var users = new List<User>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Tbl_Uzytkownicy";
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
                    string sql = "UPDATE Tbl_Uzytkownicy SET Login=@Login, Haslo=@Haslo, Imie=@Imie, Nazwisko=@Nazwisko, Pesel=@Pesel, DataUrodzenia=@DataUrodzenia, IdPlci=@IdPlci, Email=@Email, NrTelefonu=@NrTelefonu WHERE IdUzytkownika = @id";


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
                    string sql = "SELECT * FROM Tbl_Uzytkownicy WHERE Imie LIKE @search OR Nazwisko LIKE @search";

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

      /*  public void ForgetUser(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Tbl_Uzytkownicy SET Imie=@Imie, Nazwisko=@Nazwisko, Pesel=@Pesel, DataUrodzenia=@DataUrodzenia, Plec=@Plec";


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

                        command.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd tworzenia adresu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } */

    }

}
