using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia.repositories
{
    public class PatientRepository
    {
        private readonly string connectionString = "Server=tcp:przychodnia3.database.windows.net,1433;Initial Catalog=przychodnia3;Persist Security Info=False;User ID=przychodnia3;Password=Testowanie3!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //Funkcja1 - pobieranie listy pacjentow - return List<Patient> 

        //Funkcja2 - pobieranie pojedynczego pacjenta - return Patient - przyjmuje int id

        //Funkcja3 - pobieranie pacjentów wedle filtra - return List<Patient> - przyjmuje string 

        //Funkcja4 - dodanie pacjenta do bazy - return void - przyjmuje Patient

        //Funkcja5 - edycja pacjenta w bazie - return void - przyjmuje Patient 

    }
}
