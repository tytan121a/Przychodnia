using przychodnia3.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia3.respositories
{
    public class AddressRespository
    {
        private readonly string connectionString = "Server=przychodnia.cnu8c8sis4iy.eu-north-1.rds.amazonaws.com,1433;Database=PrzychodniaDB;User Id=admin;Password=Przychodnia123;TrustServerCertificate=True;";


        

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


        public Adres GetAddress(int id)
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
                                Adres adres = new Adres();
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



        public void CreateAddress(Adres adres)
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




    }
}
