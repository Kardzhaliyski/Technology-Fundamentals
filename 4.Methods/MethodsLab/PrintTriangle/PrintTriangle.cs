using System;

namespace PrintTriangle
{
    class PrintTriangle
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintATriangle(num);
        }

        public static void PrintATriangle(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write((j ) + " ");
                }
                Console.WriteLine();
                
            }
            for (int i = 1; i < height; i++)
            {
                for (int j = height - i - 1, curNum = 1; j >= 0; j--, curNum++)
                {
                    Console.Write((curNum) + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
