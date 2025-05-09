using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia.functions
{
    public class Password
    {
        private static readonly string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string lowerChars = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string digits = "0123456789";
        private static readonly string specialChars = "-_!*#$&";
        private static readonly string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly Random random = new Random();

        public String GeneratePassword() {
            int length = 10;
            string pass = "";

            pass += upperChars[random.Next(upperChars.Length)];
            pass += upperChars[random.Next(upperChars.Length)];
            pass += upperChars[random.Next(upperChars.Length)];

            pass += lowerChars[random.Next(lowerChars.Length)];
            pass += lowerChars[random.Next(lowerChars.Length)];
            pass += lowerChars[random.Next(lowerChars.Length)];

            pass += digits[random.Next(digits.Length)];
            pass += digits[random.Next(digits.Length)];

            pass += specialChars[random.Next(specialChars.Length)];
            pass += specialChars[random.Next(specialChars.Length)];
            return pass;
        }

        public bool ValidatePassword(string pass)
        {
            string password = pass;
            string allowedSpecialChars = "-_!*#$&";


            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Hasło nie zostało uzupełnione", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Hasło powinno zawierać co najmniej 8 znaków", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (password.Length > 15)
            {
                MessageBox.Show("Hasło powinno zawierać maksymalnie 15 znaków", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Hasło nie zawiera co najmniej jednej wielkiej litery. Wprowadź inne hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Hasło nie zawiera co najmniej jednej małej litery. Wprowadź inne hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Hasło nie zawiera co najmniej jednej cyfry. Wprowadź inne hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!password.Any(ch => allowedSpecialChars.Contains(ch)))
            {
                MessageBox.Show("Hasło nie zawiera co najmniej jednego znaku specjalnego: : -, _, !, *, #, $, &. Wprowadź inne hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (password.Any(ch => !char.IsLetterOrDigit(ch) && !allowedSpecialChars.Contains(ch)))
            {
                MessageBox.Show("Hasło zawiera niedozwolone znaki specjalne", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
