using System;
using System.Linq;
using System.Collections.Generic;


class LegendaryFarming
{
    static void Main(string[] args)
    {
        var totalMaterials = new Dictionary<string, int>
        {
            ["shards"] = 0,
            ["fragments"] = 0,
            ["motes"] = 0
        };
        var junks = new Dictionary<string, int>();
        bool legendaryObtained = false;

        while (legendaryObtained == false)
        {
            string[] currInput = Console.ReadLine()
                .Split();


            for (int i = 0; i < currInput.Length - 1; i += 2)
            {
                string materialType = currInput[i + 1].ToLower();
                int quantity = int.Parse(currInput[i]);

                if (totalMaterials.ContainsKey(materialType) == true)
                {
                    totalMaterials[materialType] += quantity;

                    if (LegendaryObtained(totalMaterials) == true)
                    {
                        legendaryObtained = true;
                        break;
                    }
                }

                else if (junks.ContainsKey(materialType) == false)
                {
                    junks[materialType] = quantity;
                }

                else
                {
                    junks[materialType] += quantity;
                }
            }
        }

        totalMaterials
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .ToList()
            .ForEach(x => Console.WriteLine($"{x.Key}: {x.Value}"));

        junks
            .OrderBy(x => x.Key)
            .ToList()
            .ForEach(x => Console.WriteLine($"{x.Key}: {x.Value}"));
        
    }

    public static bool LegendaryObtained(Dictionary<string, int> materials)
    {
        if (materials["shards"] >= 250)
        {
            Console.WriteLine("Shadowmourne obtained!");
            materials["shards"] -= 250;
            return true;
        }

        else if (materials["fragments"] >= 250)
        {
            Console.WriteLine("Valanyr obtained!");
            materials["fragments"] -= 250;
            return true;
        }

        else if (materials["motes"] >= 250)
        {
            Console.WriteLine("Dragonwrath obtained!");
            materials["motes"] -= 250;
            return true;
        }

        return false;
    }
}

