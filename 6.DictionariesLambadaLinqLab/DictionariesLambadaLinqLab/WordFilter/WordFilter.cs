using System;
using System.Linq;
using System.Collections.Generic;


class WordFilter
{
    static void Main(string[] args)
    {
        Console.ReadLine()
            .Split()
            .Where(x => x.Length % 2 == 0)
            .ToList()
            .ForEach(x => Console.WriteLine(x));
    }
}

