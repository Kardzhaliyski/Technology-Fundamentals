using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> arrayStrings = input
                .Split('|')
                .ToList();

            List<int> numbers = arrayStrings[0]
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 1; i < arrayStrings.Count; i++)
            {
                List<int> tempList = arrayStrings[i]
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

                for (int j = tempList.Count - 1; j >= 0; j--)
                {
                    numbers.Insert(0, tempList[j]);
                }

            }

            Console.WriteLine(string.Join(' ',numbers));
            

            
        }
    }
}
