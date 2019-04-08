using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 5, 4, 3, 2, 1 };
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
            int[] testArray = new int[5];
            testArray = array;

            Console.WriteLine();
            Console.Write("TestArray = ");

            foreach (var num in testArray)
            {
                Console.Write(num + " ");
            }

            testArray = array2;

            Console.WriteLine();
            Console.Write("Array = ");

            foreach (var num in array)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.Write("TestArray = ");

            foreach (var num in testArray)
            {
                Console.Write(num + " ");
            }
        }
    }
}
