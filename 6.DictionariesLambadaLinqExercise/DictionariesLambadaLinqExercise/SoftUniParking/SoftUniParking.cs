using System;
using System.Linq;
using System.Collections.Generic;


class SoftUniParking
{
    static void Main(string[] args)
    {
        int commandsCount = int.Parse(Console.ReadLine());
        var parking = new Dictionary<string, string>();

        for (int i = 0; i < commandsCount; i++)
        {
            string[] tokens = Console.ReadLine()
                .Split();
            string command = tokens[0].ToLower();

            if (command == "register")
            {
                string username = tokens[1];
                string licensePlateNumber = tokens[2];
                if (parking.ContainsKey(username) == false)
                {
                    parking[username] = licensePlateNumber;
                    Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    continue;
                }
                else
                {
                    Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    continue;
                }
            }

            else if (command == "unregister")
            {
                string username = tokens[1];
                if (parking.ContainsKey(username))
                {
                    parking.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                    continue;
                }
                else
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                    continue;
                }
            }
        }

        PrintParkedCars(parking);
    }

    private static void PrintParkedCars(Dictionary<string, string> parking)
    {
        foreach (var car in parking)
        {
            string username = car.Key;
            string licensePlate = car.Value;
            Console.WriteLine($"{username} => {licensePlate}");
        }
    }
}

