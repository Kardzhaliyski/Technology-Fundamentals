using System;


class Train
{
    static void Main(string[] args)
    {
        int nWagons = int.Parse(Console.ReadLine());
        int[] train = new int[nWagons];
        int passangers = 0;

        for (int i = 0; i < nWagons; i++)
        {
            train[i] = int.Parse(Console.ReadLine());
            passangers += train[i];
            Console.Write(train[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(passangers);
        
    }
}

