using System;
using System.Linq;
using System.Collections.Generic;


class ForceBook2
{
    static void Main(string[] args)
    {
        var forceBook = new Dictionary<string, List<string>>();

        while (true)
        {
            string input = Console.ReadLine();
            if(input == "Lumpawaroo")
            {
                break;
            }
            string user;
            string side;

            if (input.Contains(" | "))
            {
                string[] tokens = input
                    .Split(" | ");
                side = tokens[0];
                user = tokens[1];

                if(forceBook.ContainsKey(side) == false)
                {
                    forceBook[side] = new List<string>();
                }

                if (ExistInArray(forceBook, user) == false)
                {
                    forceBook[side].Add(user);
                }
            }

            else if(input.Contains(" -> "))
            {
                string[] tokens = input
                       .Split(" -> ");
                side = tokens[1];
                user = tokens[0];

                if (forceBook.ContainsKey(side) == false)
                {
                    forceBook[side] = new List<string>();
                }

                FindAndRemove(forceBook, side, user);
                AddIfDontExist(forceBook, side, user);

            }

        }

        Print(forceBook);

    }

    private static void AddIfDontExist(Dictionary<string, List<string>> forceBook, string side, string user)
    {
        if (forceBook[side].Contains(user) == false)
        {
            forceBook[side].Add(user);
            Console.WriteLine($"{user} joins the {side} side!");
        }
    }

    private static void FindAndRemove(Dictionary<string, List<string>> forceBook, string side, string user)
    {
        foreach (var kvp in forceBook)
        {
            if(kvp.Key == side)
            {
                continue;
            }

            if (kvp.Value.Contains(user))
            {
                kvp.Value.Remove(user);
            }
        }

        
    }

    public static bool ExistInArray (Dictionary<string,List<string>> dict, string user)
    {
        bool exist = false;
        foreach (var kvp in dict)
        {
            if (kvp.Value.Contains(user))
            {
                exist = true;
            }
        }
        return exist;
    }

    private static Dictionary<string, List<string>> Sort(Dictionary<string, List<string>> forceBook)
    {
        forceBook = forceBook
                    .OrderByDescending(x => x.Value.Count())
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

        foreach (var kvp in forceBook)
        {
            if (kvp.Value.Count > 0)
            {
                kvp.Value.Sort((x, y) => x.CompareTo(y));
            }
        }

        return forceBook;
    }

    private static void Print(Dictionary<string, List<string>> forceBook)
    {
        forceBook = Sort(forceBook);

        foreach (var kvp in forceBook)
        {
            if (kvp.Value.Count > 0)
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                foreach (var user in kvp.Value)
                {
                    Console.WriteLine("! " + user);
                }
            }

        }
    }
}

