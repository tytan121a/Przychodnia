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
                    string sql = "SELECT * FROM Tbl_Uprawnienia AND Tbl_Role_Uprawnienia";
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

        public Uprawnienia GetRoleRights()
        {

        }
    }
}