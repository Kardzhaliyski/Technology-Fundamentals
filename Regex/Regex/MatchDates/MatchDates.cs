using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            Regex dateExtractorRegex = new Regex
                (@"\b(?<day>\d{2})([-\/.])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");
            string inputString = Console.ReadLine();
            var extractedDates = dateExtractorRegex.Matches(inputString);
            foreach (Match date in extractedDates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }



        }
    }
}
