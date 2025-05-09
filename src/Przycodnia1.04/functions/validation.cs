using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia.functions
{
    internal class validation
    {
        public bool validatePESEL(string pesel, DateTime dataUrodzenia, int plecId)
        {


            if (string.IsNullOrWhiteSpace(pesel) || pesel.Length != 11 || !pesel.All(char.IsDigit))
                return false;

            if (dataUrodzenia > DateTime.Now || dataUrodzenia < DateTime.Now.AddYears(-120))
                return false;

            DateTime peselDate;
            if (!TryParsePeselDate(pesel.Substring(0, 6), out peselDate) || peselDate.Date != dataUrodzenia.Date)
                return false;

            int genderDigit = pesel[9] - '0';
            bool isMale = genderDigit % 2 == 1;

            if ((isMale && plecId != 1) || (!isMale && plecId != 2))
                return false;

            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sum = pesel.Take(10).Select((c, i) => (c - '0') * weights[i]).Sum();
            int controlDigit = (10 - (sum % 10)) % 10;


            bool res = (controlDigit == int.Parse(pesel[10].ToString()));

            return res;

        }



        private bool TryParsePeselDate(string peselDatePart, out DateTime date)
        {

            date = DateTime.MinValue;

            int year = int.Parse(peselDatePart.Substring(0, 2));
            int month = int.Parse(peselDatePart.Substring(2, 2));
            int day = int.Parse(peselDatePart.Substring(4, 2));

            int centuryOffset = (month / 20) * 100;
            month %= 20;

            int fullYear = 1900 + centuryOffset + year;

            return DateTime.TryParse($"{fullYear}-{month:00}-{day:00}", out date);
        }


    }
}
