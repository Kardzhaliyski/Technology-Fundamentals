using System;
using System.Collections.Generic;
using System.Linq;


class PokemonDontGo
{
    static void Main(string[] args)
    {
        List<int> pokemons = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        int walkedDistance = 0;

        while (pokemons.Count > 0)
        {
            int targetIndex = int.Parse(Console.ReadLine());
            int lastPokemonIndex = pokemons.Count - 1;
            if (targetIndex < 0)
            {
                int target = pokemons[0];
                walkedDistance += target;
                pokemons[0] = pokemons[lastPokemonIndex];
                CalculateAndRefresh(pokemons, target);
                continue;
            }

            else if (targetIndex > pokemons.Count - 1)
            {
                int target = pokemons[pokemons.Count - 1];
                walkedDistance += target;
                pokemons[lastPokemonIndex] = pokemons[0];
                CalculateAndRefresh(pokemons, target);
                continue;
            }

            else
            {
                int target = pokemons[targetIndex];
                walkedDistance += target;
                pokemons.RemoveAt(targetIndex);
                CalculateAndRefresh(pokemons, target);
            }
        }

        Console.WriteLine(walkedDistance);
    }

    private static void CalculateAndRefresh(List<int> pokemons, int target)
    {
        for (int i = 0; i < pokemons.Count; i++)
        {
            if (pokemons[i] <= target)
            {
                pokemons[i] += target;
            }

            else if (pokemons[i] > target)
            {
                pokemons[i] -= target;
            }
        }
    }
}

