using System;
using System.Collections.Generic;
using System.Linq;

class ListOfProducts
{
    static void Main(string[] args)
    {
        int productCount = int.Parse(Console.ReadLine());
        List<string> shoppingList = new List<string>();

        for (int i = 0; i < productCount; i++)
        {
            shoppingList.Add(Console.ReadLine());
        }

        shoppingList.Sort();
        PrintNumberedList(shoppingList);

    }
    
    public static void PrintNumberedList(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"{i+1}.{list[i]}");
        }
    }
}

