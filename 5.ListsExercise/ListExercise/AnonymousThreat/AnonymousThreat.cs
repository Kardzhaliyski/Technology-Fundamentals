using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> stringList = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "3:1")
                {
                    break;
                }

                string[] tokens = command
                    .Split();
                string action = tokens[0];

                if(action == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    Merge(stringList, startIndex, endIndex);
                }

                else if(action == "divide")
                {
                    int index = int.Parse(tokens[1]);
                    int partitions = int.Parse(tokens[2]);
                    Divide(stringList, index, partitions);

                }
            }

            Console.WriteLine(string.Join(' ', stringList));

        }

        private static void Divide(List<string> stringList, int index, int partitions)
        {
            string stringToDivide = stringList[index];
            stringList.RemoveAt(index);
            List<string> tempList = new List<string>();
            int substringLength = stringToDivide.Length / partitions;

            for (int i = 0; i < partitions -1; i++)
            {
                int currentIndex = i * substringLength;
                string tempSubstring = stringToDivide.Substring(currentIndex, substringLength);
                tempList.Add(tempSubstring);
            }

            int lastSubstringIndex = (partitions - 1) * substringLength;
            string lastSubstring = stringToDivide.Substring(lastSubstringIndex);
            tempList.Add(lastSubstring);
            tempList = tempList
                .Where(x => !string.IsNullOrEmpty(x))
                .ToList();
            stringList.InsertRange(index,tempList);
        }

        private static void Merge(List<string> stringList, int startIndex, int endIndex)
        {
            if(startIndex >= stringList.Count -1|| endIndex < 1)
            {
                return;
            }
            
            if(startIndex < 0)
            {
                startIndex = 0;
            }

            if(endIndex >= stringList.Count)
            {
                endIndex = stringList.Count - 1;
            }

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                stringList[startIndex] += stringList[i];
            }

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                stringList.RemoveAt(startIndex + 1);
            }
            

        }
    }
}
