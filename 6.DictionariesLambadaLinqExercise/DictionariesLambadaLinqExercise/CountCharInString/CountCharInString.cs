using System;
using System.Linq;
using System.Collections.Generic;


class CountCharInString
{
    static void Main(string[] args)
    {
        string inputText = Console.ReadLine();
        var charCount = new Dictionary<char, int>();

        for (int i = 0; i < inputText.Length; i++)
        {
            char currChar = inputText[i];

            if(currChar == ' ')
            {
                continue;
            }

            if (charCount.ContainsKey(currChar) == false)
            {
                charCount[currChar] = 0;
            }

            charCount[currChar]++;
        }

        foreach (var symbol in charCount)
        {
            Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
        }
    }
}

