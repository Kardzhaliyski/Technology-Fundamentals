using System;
using System.Linq;
using System.Collections.Generic;



class OddOccurrences
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split();
        var wordCount = new Dictionary<string, int>();

        foreach (var str in input)
        {
            if (!wordCount.ContainsKey(str.ToLower()))
            {
                wordCount[str.ToLower()] = 0;
            }
            wordCount[str.ToLower()]++;
        }


        var result = wordCount
            .Where(x => x.Value % 2 == 1)
            .ToList();

        foreach (var item in result)
        {
            Console.Write(item.Key + " ");
        }
    }
}
