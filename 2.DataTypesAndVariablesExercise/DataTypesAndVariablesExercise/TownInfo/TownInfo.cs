﻿using System;


class TownInfo
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int population = int.Parse(Console.ReadLine());
        double area = double.Parse(Console.ReadLine());
        Console.WriteLine($"Town {name} has population of {population} and area {area} square km.");

    }
}

