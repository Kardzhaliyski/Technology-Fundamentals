using System;

namespace PasswordValidator
{
    class PasswordValidator
    {
        static void Main(string[] args)
        {
            string passwordInput = Console.ReadLine();
            ValidateAndPrintPasswordErrors(passwordInput);

        }

        public static void ValidateAndPrintPasswordErrors(string password)
        {
            bool IsValid = true;
            if (IsPasswordLengthValid(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                IsValid = false;
            }
            if (PasswordContaionsOnlyNumbersAndCharacters(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                IsValid = false;
            }
            if(PasswordContainNDigits(2, password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
                IsValid = false;
            }
            if(IsValid == true)
            {
                Console.WriteLine("Password is valid");
            }

        }

        public static bool IsPasswordLengthValid (string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }
            return true;
        }

        public static bool PasswordContaionsOnlyNumbersAndCharacters (string password)
        {

            foreach (var character in password)
            {
                if(character > 47 && character < 58)
                {
                    continue;
                }
                else if(character > 64 && character < 91)
                {
                    continue;
                }
                else if(character > 96 && character < 123)
                {
                    continue;
                }
                return false;

            }

            return true;
        }

        public static bool PasswordContainNDigits(int n, string password)
        {
            int digitCounter = 0;
            foreach (var character in password)
            {
                if(digitCounter >= 2)
                {
                    return true;
                }
                string currChar =  character.ToString();
                if(int.TryParse(currChar, out int tempNum))
                {
                    digitCounter++;
                }
            }

            if(digitCounter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
