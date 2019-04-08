using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex regex = new Regex("(?<=\\W|^)[A-Z][a-z]+ [A-Z][a-z]+(?=\\W|$)");
            Regex regex = new Regex("\\b[A-Z][a-z]+ [A-Z][a-z]+\\b");

            string namesInput = Console.ReadLine();
            var names = regex.Matches(namesInput)
                .ToArray();
            var namesArray = from Match match in names select match.Value;
            Console.WriteLine(string.Join(' ', namesArray));
            
        }
    }
}
