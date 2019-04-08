using System;
using System.Linq;
using System.Collections.Generic;


class MinerTask
{
    static void Main(string[] args)
    {
        var resources = new Dictionary<string, int>();

        while(true)
        {
            string resourceType = Console.ReadLine();

            if(resourceType == "stop")
            {
                break;
            }

            int quantity = int.Parse(Console.ReadLine());


            if(resources.ContainsKey(resourceType) == false)
            {
                resources[resourceType] = 0;
            }

            resources[resourceType] += quantity;
        }

        foreach (var resourceType in resources)
        {
            Console.WriteLine($"{resourceType.Key} -> {resourceType.Value}");
        }
        
    }
}
