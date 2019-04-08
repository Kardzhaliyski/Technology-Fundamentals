using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<=\W|^)\+359([- ])2\1\d{3}\1\d{4}(?=\W|$)");
            string inputText = Console.ReadLine();
            var matchedPhones = regex.Matches(inputText);
            var phoneArray = from Match phone in matchedPhones select phone.Value;
            Console.WriteLine(string.Join(", ", phoneArray));

        }
    }
}
