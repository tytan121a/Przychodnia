using Azure.Identity;
using Microsoft.Data.SqlClient;
using przychodnia3.models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia3.respositories
{
    public class RightsRepository
    {
        private readonly string connectionString = "Server=tcp:przychodnia3.database.windows.net,1433;Initial Catalog=przychodnia3;Persist Security Info=False;User ID=przychodnia3;Password=Testowanie3!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        public List<Uprawnienia> GetRights()
        {
            List<Uprawnienia> RightsList = new List<Uprawnienia>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Tbl_Uprawnienia";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {   



                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                Uprawnienia uprawnienie = new Uprawnienia();
                                uprawnienie.IdUprawnienia = reader.GetInt32(0);
                                uprawnienie.Uprawnienie = reader.GetString(1);
                                uprawnienie.OpisUprawnienia = reader.GetString(2);
                                RightsList.Add(uprawnienie);
                            }

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania listy uprawnień: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return RightsList;
        }

        public List<String> GetRoleRights(int idRoli)
        {
            List<String> RightsList = new List<String>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT RU.IdRoli, U.* FROM Tbl_Uprawnienia U LEFT JOIN Tbl_Role_Uprawnienia RU ON U.IdUprawnienia = RU.IdUprawnienia WHERE RU.IdRoli = @IdRoli";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {

                        command.Parameters.AddWithValue("@IdRoli", idRoli);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                RightsList.Add(reader.GetString(2));
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania listy uprawnień roli: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return RightsList;
        }
        public void UpdateRoleRights(int idRoli, List<int> newRightsIds)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Usuwanie starych uprawnien
                            string deleteSql = "DELETE FROM Tbl_Role_Uprawnienia WHERE IdRoli = @IdRoli";
                            using (SqlCommand deleteCommand = new SqlCommand(deleteSql, conn, transaction))
                            {
                                deleteCommand.Parameters.AddWithValue("@IdRoli", idRoli);
                                deleteCommand.ExecuteNonQuery();
                            }

                            // Dodanie nowych uprawnien
                            foreach (int rightId in newRightsIds)
                            {
                                string insertSql = "INSERT INTO Tbl_Role_Uprawnienia (IdRoli, IdUprawnienia) VALUES (@IdRoli, @IdUprawnienia)";
                                using (SqlCommand insertCommand = new SqlCommand(insertSql, conn, transaction))
                                {
                                    insertCommand.Parameters.AddWithValue("@IdRoli", idRoli);
                                    insertCommand.Parameters.AddWithValue("@IdUprawnienia", rightId);
                                    insertCommand.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {                            
                            transaction.Rollback();
                            MessageBox.Show("Błąd podczas aktualizacji uprawnień roli: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas łączenia z bazą danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<int> GetRoleWithRights(int idUprawnienia)
        {
            List<int> rolesList = new List<int>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"
                SELECT DISTINCT IdRoli
                FROM Tbl_Role_Uprawnienia
                WHERE IdUprawnienia = @IdUprawnienia
            ";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@IdUprawnienia", idUprawnienia);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                rolesList.Add(reader.GetInt32(reader.GetOrdinal("IdRoli")));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania ról dla uprawnienia: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return rolesList;
        }





    }


}