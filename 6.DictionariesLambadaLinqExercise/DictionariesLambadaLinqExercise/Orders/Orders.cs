using System;
using System.Linq;
using System.Collections.Generic;


class Orders
{
    static void Main(string[] args)
    {
        var products = new Dictionary<string,double[]>();

        while (true)
        {
            string[] data = Console.ReadLine()
                .Split();
            if(data[0] == "buy")
            {
                break;
            }

            string product = data[0];
            double price = double.Parse(data[1]);
            double quantity = double.Parse(data[2]);

            if(products.ContainsKey(product) == false)
            {
                products[product] = new double[2];
            }

                products[product][0] = price;
                products[product][1] += quantity;
        }

        foreach (var kvp in products)
        {
            string name = kvp.Key;
            double value = kvp.Value[0] * kvp.Value[1];
            Console.WriteLine($"{name} -> {value:f2}");
        }
    }
}
