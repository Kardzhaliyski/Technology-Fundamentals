using System;
using System.Text;

namespace RepeatString
{
    class RepeatString
    {
        static void Main(string[] args)
        {
            string[] stringArr = Console.ReadLine()
                .Split();
            StringBuilder newString = new StringBuilder();

            foreach (var word in stringArr)
            {
                var count = word.Length;
                for (int i = 0; i < count; i++)
                {
                    newString.Append(word);
                }
            }
            Console.WriteLine(newString);
        }
    }
}
