using System;

namespace CalculateRectangleArea
{
    class CalculateRectangleArea
    {
        static void Main(string[] args)
        {
            int firstSide = int.Parse(Console.ReadLine());
            int secoundSide = int.Parse(Console.ReadLine());

            Console.WriteLine(GetRectangleArea(firstSide,secoundSide));

        }

        public static int GetRectangleArea(int side1 , int side2)
        {
            return side1 * side2;
        }
    }
}
