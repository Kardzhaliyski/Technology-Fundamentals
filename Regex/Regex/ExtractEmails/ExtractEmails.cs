using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            var emailFinderRegex = @"(?<=\s|^)[a-zA-Z0-9][a-zA-Z\-\._]+@[A-Za-z]+[A-Za-z-]*[A-Za-z]+(\.[a-zA-Z]+)+\b";
            MatchCollection emails = Regex.Matches(inputString, emailFinderRegex);
            foreach (Match email in emails)
            {
                Console.WriteLine(email.Value);
            }

        }
    }
}
