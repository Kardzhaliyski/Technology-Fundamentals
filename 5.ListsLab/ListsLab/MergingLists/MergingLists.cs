using System;
using System.Collections.Generic;
using System.Linq;

class MergingLists
{
    static void Main(string[] args)
    {
        List<int> numbers1 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> numbers2 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        MergeLists2(numbers1, numbers2);
        PrintLargerList(numbers1, numbers2);

        //List<int> testList = "3 76 5 5 2 34 43 2 12 4 3 12 54 10 23".Split().Select(int.Parse).ToList();
        //IsEqual(numbers1, testList);

    }

    private static void IsEqual(List<int> numbers2, List<int> testList)
    {
        bool isEqual = true;
        for (int i = 0; i < numbers2.Count; i++)
        {
            if (numbers2[i] != testList[i])
            {
                Console.WriteLine("Not Equal");
                isEqual = false;
            }
        }
        if (isEqual)
        {
            Console.WriteLine("Equal");
        }
    }

    private static void MergeLists(List<int> numbers1, List<int> numbers2)
    {
        bool firstIsBigger = numbers1.Count >= numbers2.Count;
        int smallerList = Math.Min(numbers1.Count, numbers2.Count);
        if (firstIsBigger)
        {
            for (int i = 0, insertIndex = 1; insertIndex < smallerList * 2; i++, insertIndex += 2)
            {
                numbers1.Insert(insertIndex, numbers2[i]);
            }
        }

        else
        {
            for (int i = 0, insertIndex = 0; insertIndex < smallerList * 2; i++, insertIndex += 2)
            {
                numbers2.Insert(insertIndex, numbers1[i]);
            }
        }


    }

    private static void MergeLists2(List<int> numbers1, List<int> numbers2)
    {
        bool firstIsBigger = numbers1.Count >= numbers2.Count;
        int smallerList = Math.Min(numbers1.Count, numbers2.Count);
        if (firstIsBigger)
        {
            for (int i = 0, insertIndex = 1; insertIndex < smallerList * 2; i++, insertIndex += 2)
            {
                numbers1.Insert(insertIndex, numbers2[i]);
            }
        }

        else
        {
            int i = 0;
            for (int insertIndex = 1; insertIndex < smallerList * 2; i++, insertIndex += 2)
            {
                numbers1.Insert(insertIndex, numbers2[i]);
            }
            for (; i < numbers2.Count; i++)
            {
                numbers1.Add(numbers2[i]);
            }
        }
        



    }




    public static void PrintLargerList(List<int> numbers1, List<int> numbers2)
    {
        if (numbers1.Count >= numbers2.Count)
        {
            foreach (var num in numbers1)
            {
                Console.Write(num + " ");
            }
        }

        else
        {
            foreach (var num in numbers2)
            {
                Console.Write(num + " ");
            }
        }
    }
}

