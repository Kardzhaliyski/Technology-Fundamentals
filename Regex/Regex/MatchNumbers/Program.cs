using System;
using System.Text.RegularExpressions;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex numberFindeRegex = new Regex(@"(?<=\s|^)-?\d+(\.\d+)?(?=\s|$)");
            string inputString = Console.ReadLine();
            MatchCollection numbers = numberFindeRegex.Matches(inputString);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }


        }
    }
}
