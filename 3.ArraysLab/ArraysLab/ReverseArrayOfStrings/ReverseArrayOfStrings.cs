using System;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] arrStrings = Console.ReadLine().Split();
            ReverseStringArray(arrStrings);
            foreach (var str in arrStrings)
            {
                Console.Write(str + " ");
            }

        }

        public static void ReverseStringArray(string[] arrStrings)
        {
            for (int i = 0; i < (arrStrings.Length /2); i++)
            {
                string temp = arrStrings[i];
                int rightIndex = arrStrings.Length - 1 - i;
                arrStrings[i] = arrStrings[rightIndex];
                arrStrings[rightIndex] = temp;
            }
        }
    }
}
