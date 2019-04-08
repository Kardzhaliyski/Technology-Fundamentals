using System;
using System.ComponentModel;
using System.Linq;

namespace StringExplosion
{
    class StringExplosion
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            while (inputString.Any(char.IsDigit))
            {
                int explosionPower = inputString.FirstOrDefault();
                

            }

        }

        
    }
}
