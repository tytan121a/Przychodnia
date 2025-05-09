using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Przychodnia.functions;
using Przychodnia.models;
namespace Przychodnia.repositories
{
    public class AddressRepository
    {
        private readonly string connectionString = "Server=tcp:przychodnia3.database.windows.net,1433;Initial Catalog=przychodnia3;Persist Security Info=False;User ID=przychodnia3;Password=Testowanie3!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public int GetAddressId(string Miejscowosc, string KodPocztowy, string Ulica, string NrPosesji, string NrLokalu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Tbl_Adresy WHERE Miejscowosc=@Miejscowosc AND KodPocztowy=@KodPocztowy AND Ulica=@Ulica AND NrPosesji=@NrPosesji AND NrLokalu=@NrLokalu";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@Miejscowosc", Miejscowosc);
                        command.Parameters.AddWithValue("@KodPocztowy", KodPocztowy);
                        command.Parameters.AddWithValue("@Ulica", Ulica);
                        command.Parameters.AddWithValue("@NrPosesji", NrPosesji);
                        command.Parameters.AddWithValue("@NrLokalu", NrLokalu);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                return reader.GetInt32(0); ;
                            }

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania id adresu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1;
        }


        public Address GetAddress(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Tbl_Adresy WHERE IdAdresu=@id";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Address adres = new Address();
                                adres.IdAdresu = reader.GetInt32(0);
                                adres.Miejscowosc = reader.GetString(1);
                                adres.KodPocztowy = reader.GetString(2);
                                adres.Ulica = reader.GetString(3);
                                adres.NrPosesji = reader.GetString(4);
                                adres.NrLokalu = reader.GetString(5);


                                return adres;
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania adresu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }



        public void CreateAddress(Address adres)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO Tbl_Adresy  (Miejscowosc, KodPocztowy, Ulica, NrPosesji, NrLokalu) VALUES (@Miejscowosc, @KodPocztowy, @Ulica, @NrPosesji, @NrLokalu)";




                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@Miejscowosc", adres.Miejscowosc);
                        command.Parameters.AddWithValue("@KodPocztowy", adres.KodPocztowy);
                        command.Parameters.AddWithValue("@Ulica", adres.Ulica);
                        command.Parameters.AddWithValue("@NrPosesji", adres.NrPosesji);
                        command.Parameters.AddWithValue("@NrLokalu", adres.NrLokalu);

                        command.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd tworzenia adresu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void UpdateAddress(int id, string Miejscowosc, string KodPocztowy, string Ulica, string NrPosesji, string NrLokalu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Tbl_Adresy SET Miejscowosc=@Miejscowosc, KodPocztowy=@KodPocztowy, Ulica=@Ulica, NrPosesji=@NrPosesji, NrLokalu=@NrLokalu WHERE IdAdresu = @id";




                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        command.Parameters.AddWithValue("@Miejscowosc", Miejscowosc);
                        command.Parameters.AddWithValue("@KodPocztowy", KodPocztowy);
                        command.Parameters.AddWithValue("@Ulica", Ulica);
                        command.Parameters.AddWithValue("@NrPosesji", NrPosesji);
                        command.Parameters.AddWithValue("@NrLokalu", NrLokalu);

                        command.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd aktualizacji adresu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ForgetAddress(int id, string Miejscowosc, string KodPocztowy, string Ulica, string NrPosesji, string NrLokalu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Tbl_Adresy SET Miejscowosc=@Miejscowosc, KodPocztowy=@KodPocztowy, Ulica=@Ulica, NrPosesji=@NrPosesji, NrLokalu=@NrLokalu WHERE IdAdresu = @id";
                    var hash = new Hash();

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        command.Parameters.AddWithValue("@Miejscowosc", hash.generateStringHash(30));
                        command.Parameters.AddWithValue("@KodPocztowy", hash.generateIntHash(2) + "-" + hash.generateIntHash(3));
                        command.Parameters.AddWithValue("@Ulica", hash.generateStringHash(50));
                        command.Parameters.AddWithValue("@NrPosesji", hash.generateStringHash(10));
                        command.Parameters.AddWithValue("@NrLokalu", hash.generateStringHash(10));

                        command.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd aktualizacji adresu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
