using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSpent = 0;
            var regex = @"^>>(?<product>[A-Za-z ]+)<<(?<price>\d+(\.\d+)*)!(?<quantity>\d+(\.\d+)?)$";
            Console.WriteLine("Bought furniture:");
            while (true)
            {
                string inputString = Console.ReadLine();
                if (inputString == "Purchase")
                {
                    break;
                }

                Match purchase = Regex
                    .Match(inputString, regex);
                if (purchase.Success == false)
                {
                    continue;
                }

                string product = purchase.Groups["product"].Value;
                double price = double.Parse(purchase.Groups["price"].Value);
                double quantity = double.Parse(purchase.Groups["quantity"].Value);
                totalSpent += price * quantity;
                Console.WriteLine(product);
            }

            Console.WriteLine($"Total money spend: {totalSpent:f2}");

        }
    }
}
