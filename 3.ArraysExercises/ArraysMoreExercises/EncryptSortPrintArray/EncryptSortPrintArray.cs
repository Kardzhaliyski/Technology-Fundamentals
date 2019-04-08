using System;

namespace EncryptSortPrintArray
{
    class EncryptSortPrintArray
    {
        static void Main(string[] args)
        {
            int numOfNames = int.Parse(Console.ReadLine());
            int[] arrayOfInts = new int[numOfNames];

            for (int i = 0; i < numOfNames; i++)
            {
                string name = Console.ReadLine();
                EncryptAndSaveString(name,arrayOfInts,i);
            }
            SortAndPrint(arrayOfInts);
        }

        private static void EncryptAndSaveString(string name,int[] array,int saveIndex)
        {
            int sum = 0;
            const string consonant = "aeiouAEIOU";
            for (int i = 0; i < name.Length; i++)
            {
                if (consonant.Contains("" + name[i]))
                {
                    sum += name[i] * name.Length;
                }
                else
                {
                    sum += name[i] / name.Length;
                }
            }
            array[saveIndex] = sum;
        }
        private static void SortAndPrint(int[] array)
        {
            Array.Sort(array);
            foreach (var num in array)
            {
                Console.WriteLine(num);
            }
        }
       
    }
}
