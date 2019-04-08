using System;
using System.Linq;

namespace DigitsLettersAndOthers
{
    class DigitsLettersAndOthers
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();
            string numbers = string.Join("",inputText.Where(c => char.IsNumber(c)));
            string letters = string.Join("", inputText.Where(c => char.IsLetter(c)));
            string otherSymbols = string.Join("", inputText.Where(c => char.IsLetterOrDigit(c) == false));
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(otherSymbols);
        }
    }
}
