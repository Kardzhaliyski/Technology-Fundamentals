using System;
using System.Linq;
using System.Collections.Generic;


class ForceBook
{
    static void Main()
    {
        var forceBook = new Dictionary<string, List<string>>();
        string side1 = null;
        string side2 = null;

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Lumpawaroo")
            {
                break;
            }

            string user;
            string side;

            if (input.Contains('|'))
            {
                var tokens = input
                    .Split(" | ");
                side = tokens[0];
                user = tokens[1];
            }

            else
            {
                var tokens = input
                    .Split(" -> ");

                side = tokens[1];
                user = tokens[0];
            }


            if (forceBook.ContainsKey(side) == false)
            {

                forceBook[side] = new List<string>();

                if (side1 == null)
                {
                    side1 = side;
                }
                else if (side1 != side && side2 == null)
                {
                    side2 = side;
                }
            }

            if (input.Contains('|'))
            {
                if (forceBook[side].Contains(user) == false)
                {
                    forceBook[side].Add(user);
                }
            }
            else
            {
                if (side == side1 && forceBook[side2].Contains(user))
                {
                    forceBook[side2].Remove(user);
                    forceBook[side1].Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }
                else if (side == side2 && forceBook[side1].Contains(user))
                {
                    forceBook[side1].Remove(user);
                    forceBook[side2].Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }
                else if (forceBook[side1].Contains(user) == false && forceBook[side2].Contains(user) == false)
                {
                    forceBook[side].Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }

            }
        }

        Print(forceBook, side1, side2);
    }

    private static void Print(Dictionary<string, List<string>> forceBook, string side1, string side2)
    {
        forceBook = Sort(forceBook);

        if (forceBook[side1].Count >= forceBook[side2].Count && forceBook[side1].Count > 0)
        {
            Console.WriteLine($"Side: {side1}, Members: {forceBook[side1].Count}");
            foreach (var user in forceBook[side1])
            {
                Console.WriteLine("! " + user);
            }

            if (forceBook[side2].Count > 0)
            {
                Console.WriteLine($"Side: {side2}, Members: {forceBook[side2].Count}");
                foreach (var user in forceBook[side2])
                {
                    Console.WriteLine("! " + user);
                }
            }

        }
        else if (forceBook[side2].Count > 0)
        {
            Console.WriteLine($"Side: {side2}, Members: {forceBook[side2].Count}");
            foreach (var user in forceBook[side2])
            {
                Console.WriteLine("! " + user);
            }

            if (forceBook[side1].Count > 0)
            {
                Console.WriteLine($"Side: {side1}, Members: {forceBook[side1].Count}");
                foreach (var user in forceBook[side1])
                {
                    Console.WriteLine("! " + user);
                }
            }

        }
    }

    

    private static Dictionary<string, List<string>> Sort(Dictionary<string, List<string>> forceBook)
    {
        forceBook = forceBook
                    .OrderBy(x => x.Value.Count())
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
}
