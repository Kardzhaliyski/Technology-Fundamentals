using System;

namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            var banList = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var uncensoredText = Console.ReadLine();
            var censuredText = CensureText(uncensoredText, banList);
            Console.WriteLine(censuredText);
        }

        public static string CensureText(string text, string[] banListArr)
        {
            string censuredText = text;
            foreach (string banWord in banListArr)
            {
                if (text.Contains(banWord))
                {
                    var replacementString = new string('*',banWord.Length);
                    censuredText = censuredText
                        .Replace(banWord, replacementString);
                }
            }

            return censuredText;
        }
    }
}
