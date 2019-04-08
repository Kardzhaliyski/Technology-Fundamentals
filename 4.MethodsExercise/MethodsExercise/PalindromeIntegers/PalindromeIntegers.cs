using System;

namespace PalindromeIntegers
{
    class PalindromeIntegers
    {
        static void Main(string[] args)
        {
            string input = "";
            while((input = Console.ReadLine())  != "END")
            {
                Console.WriteLine(
                    IsPalindrome(input)
                    .ToString()
                    .ToLower());
            }
        }

        

        public static bool IsPalindrome(string input)
        {
            
            for (int i = 0; i < input.Length / 2; i++)
            {
                if(input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
