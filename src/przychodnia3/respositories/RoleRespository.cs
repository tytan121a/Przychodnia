using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia3.respositories
{
    public class RoleRespository
    {
        private readonly string connectionString = "Server=przychodnia.cnu8c8sis4iy.eu-north-1.rds.amazonaws.com,1433;Database=PrzychodniaDB;User Id=admin;Password=Przychodnia123;TrustServerCertificate=True;";




        public string GetRoleName(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Tbl_Role WHERE IdRoli=@id";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetString(1);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania nazwy roli: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public int GetRoleId(string name)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Tbl_Role WHERE NazwaRoli=@name";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@name", name);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetInt32(0);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania id roli: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1;
        }
    }
}
