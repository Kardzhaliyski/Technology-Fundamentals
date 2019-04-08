using System;


class VendingMachine
{
    static void Main(string[] args)
    {
        decimal currMoney = 0.0m;
        string currInsert = "";


        currInsert = Console.ReadLine();

        while (currInsert != "Start")
        {
            
            if(currInsert == "0.1" || currInsert == "0.2" || currInsert == "0.5" || currInsert == "1" || currInsert == "2")
            {
                currMoney += decimal.Parse(currInsert);
            }
            else
            {
                Console.WriteLine($"Cannot accept {currInsert}");
            }
            currInsert = Console.ReadLine();
        }


        currInsert = Console.ReadLine();

        while (currInsert != "End")
        {
            
            
            if(currInsert.ToLower() == "nuts")
            {
                if(currMoney >= 2.0m)
                {
                    currMoney -= 2.0m;
                    Console.WriteLine($"Purchased {currInsert.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if (currInsert.ToLower() == "water")
            {
                if (currMoney >= 0.7m)
                {
                    currMoney -= 0.7m;
                    Console.WriteLine($"Purchased {currInsert.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if (currInsert.ToLower() == "crisps")
            {
                if (currMoney >= 1.5m)
                {
                    currMoney -= 1.5m;
                    Console.WriteLine($"Purchased {currInsert.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if (currInsert.ToLower() == "soda")
            {
                if (currMoney >= 0.8m)
                {
                    currMoney -= 0.8m;
                    Console.WriteLine($"Purchased {currInsert.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if (currInsert.ToLower() == "coke")
            {
                if (currMoney >= 1.0m)
                {
                    currMoney -= 1.0m;
                    Console.WriteLine($"Purchased {currInsert.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else
            {
                Console.WriteLine("Invalid product");
            }
            currInsert = Console.ReadLine();
        }

        Console.WriteLine($"Change: {currMoney:f2}");
    }
}

