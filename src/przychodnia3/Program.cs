using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia3
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            string connectionString = "Server=przychodnia.cnu8c8sis4iy.eu-north-1.rds.amazonaws.com,1433;Database=PrzychodniaDB;User Id=admin;Password=Przychodnia123;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Połączenie udane!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Błąd: " + ex.Message);
                }
                {
                }
            }
        }
    }
}
