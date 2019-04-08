using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class ShoppingSpree
    {
        static void Main(string[] args)
        {
            string peopleData = Console.ReadLine();
            var separator = GetSeparator(peopleData);
            var pplDataArr = peopleData
                .Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var peopleList = new Dictionary<string,Person>();
            foreach (var person in pplDataArr)
            {
                string[] data = person
                    .Split('=');
                string name = data[0];
                string money = data[1];
                peopleList[name] = new Person(name,money);
            }

            string productData = Console.ReadLine();
            separator = GetSeparator(productData);
            var productDataArr = productData
                .Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var productList = new Dictionary<string, Product>();
            foreach (var product in productDataArr)
            {
                string[] data = product
                    .Split('=');
                string name = data[0];
                string price = data[1];
                productList[name] = new Product(name, price);
            }

            while (true)
            {
                string purchase = Console.ReadLine();
                if (purchase == "END")
                {
                    break;
                }

                PurchaseProduct(peopleList, productList, purchase);

            }

            foreach (var person in peopleList)
            {
                Console.Write($"{person.Key} - ");
                if (person.Value.BagOfProducts.Count > 0)
                {
                    Console.Write(string.Join(", ", person.Value.BagOfProducts));
                }

                else
                {
                    Console.Write("Nothing bought");
                }

                Console.WriteLine();
            }

        }

        public static void PurchaseProduct(Dictionary<string, Person>people, Dictionary<string, Product> products, string purchaseDataInput)
        {
            string[] purchaseData = purchaseDataInput
                .Split();
            string buyerName = purchaseData[0];
            string productName = purchaseData[1];

            if (products.ContainsKey(productName) == false)
            {
                return;
            }
            else if (people[buyerName].Balance >= products[productName].Price )
            {
                people[buyerName].Balance -= products[productName].Price;
                people[buyerName].BagOfProducts.Add(products[productName]);
                Console.WriteLine($"{buyerName} bought {productName}");
            }
            else
            {
                Console.WriteLine($"{buyerName} can't afford {productName}");
            }

        }

        public static char[] GetSeparator(string input)
        {
            char[] separator = input.Where(c => char.IsLetterOrDigit(c) == false && c != '=' && c != '.').ToArray();
            return separator;
        }

        
    }

    class Person
    {
        public Person(string name, string money)
        {
            Name = name;
            Balance = decimal.Parse(money);
        }

        public string Name { get; set; }
        public decimal Balance { get; set; }
        public List<Product> BagOfProducts { get; set; } = new List<Product>();
    }

    class Product
    {
        public Product(string name, string price)
        {
            Name = name;
            Price = decimal.Parse(price);
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
