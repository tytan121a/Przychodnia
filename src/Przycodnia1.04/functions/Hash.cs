using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia.functions
{
    public class Hash
    {
        public string generateStringHash(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            char[] result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = chars[random.Next(chars.Length)];
            }

            return new string(result);
        }

        public string generateIntHash(int length)
        {
            const string chars = "0123456789";
            Random random = new Random();
            char[] result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = chars[random.Next(chars.Length)];
            }

            return new string(result);
        }
        public string generateEmailHash()
        {
            return generateStringHash(10) + '@' + generateStringHash(5) + '.' + generateStringHash(2);
        }
        public DateTime generateDateHash()
        {
            Random random = new Random();
            int year = random.Next(1900, 2100); // Zakres lat (możesz zmienić)
            int month = random.Next(1, 13); // Miesiące od 1 do 12
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1); // Losowy dzień z uwzględnieniem ilości dni w miesiącu

            return new DateTime(year, month, day);
        }
    }
}
