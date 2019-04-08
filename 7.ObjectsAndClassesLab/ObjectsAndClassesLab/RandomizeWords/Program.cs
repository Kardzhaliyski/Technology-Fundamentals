using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            List<string> firstString = Console.ReadLine().Split().ToList(); ;

            Randomize(firstString);
            
        }

        private static void Randomize(List<string> firstString)
        {
            var curList = new List<string>();

            while (firstString.Count > 0)
            {
                int randomNum = random.Next(0, firstString.Count - 1);
                curList.Add(firstString[randomNum]);
                firstString.RemoveAt(randomNum);
            }

            firstString = curList;

            foreach (var word in firstString)
            {
                Console.WriteLine(word);
            }

        }
    }
}
