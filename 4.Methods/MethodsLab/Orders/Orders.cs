using System;

namespace Orders
{
    class Orders
    {
        static void Main(string[] args)
        {
            string productType = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PrintOrderValue(productType, quantity);
        }

        public static void PrintOrderValue(string product , int quantity)
        {
            if (product.ToLower() == "coffee")
            {
                Console.WriteLine($"{(1.5m * quantity):f2}");
            }
            else if (product.ToLower() == "water")
            {
                Console.WriteLine($"{(1 * quantity):f2}");

            }
            else if( product.ToLower() == "coke")
            {
                Console.WriteLine($"{(1.4m * quantity):f2}");
            }
            else if(product.ToLower() == "snacks")
            {
                Console.WriteLine($"{(2 * quantity):f2}");
            }
        }


    }
}
