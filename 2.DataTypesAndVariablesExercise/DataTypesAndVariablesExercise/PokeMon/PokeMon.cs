using System;


class PokeMon
{
    static void Main(string[] args)
    {
        int pokePower = int.Parse(Console.ReadLine());
        int targetDistance = int.Parse(Console.ReadLine());
        int exhaustion = int.Parse(Console.ReadLine());

        PrintPokesAndRemeiningPower2(pokePower, targetDistance, exhaustion);
    }

    private static void PrintPokesAndRemeiningPower(int pokePower, int targetDistance, int exhaustion)
    {
        int currPower = pokePower;
        int pokeCounter = 0;
        while (currPower >= targetDistance)
        {
            if (currPower * 2 == pokePower)
            {
                if (currPower > exhaustion && exhaustion != 0)
                {
                    currPower /= exhaustion;
                    continue;
                }
            }
            pokeCounter++;
            currPower -= targetDistance;

        }

        Console.WriteLine(currPower);
        Console.WriteLine(pokeCounter);
    }

    private static void PrintPokesAndRemeiningPower2(int pokePower, int targetDistance, int exhaustion)
    {
        int currPower = pokePower % targetDistance;
        int pokeCounter = pokePower / targetDistance;

        if (exhaustion != 0)
        {

            if (pokePower % 2 == 0 && (pokePower / 2) % targetDistance == 0 && (pokePower / 2) >= exhaustion)
            {
                currPower = pokePower / 2;
                pokeCounter /= 2;
                currPower /= exhaustion;
                pokeCounter += currPower / targetDistance;
                currPower = currPower % targetDistance;
            }
        }

        Console.WriteLine(currPower);
        Console.WriteLine(pokeCounter);

    }

}

