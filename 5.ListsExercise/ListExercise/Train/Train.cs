using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());


            while(true)
            {
                string commands = Console.ReadLine();
                string[] tokens = commands.Split();

                if(commands == "end")
                {
                    break;
                }

                if(tokens[0] == "Add")
                {
                    int passangers = int.Parse(tokens[1]);
                    train.Add(passangers);
                }
                else if (int.TryParse(tokens[0],out int passangers))
                {
                    AllocatePassangers(train, wagonCapacity, passangers);
                }
            }

            Console.WriteLine(string.Join(' ', train));
        }

        private static void AllocatePassangers(List<int> train,int capacity, int passangers)
        {
            for (int i = 0; i < train.Count; i++)
            {
                if(passangers + train[i] <= capacity)
                {
                    train[i] += passangers;
                    break;
                }
            }
        }
    }
}
