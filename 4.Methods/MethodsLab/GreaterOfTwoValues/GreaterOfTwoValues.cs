using System;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string firstInput = Console.ReadLine();
            string secInput = Console.ReadLine();

            if(int.TryParse(firstInput,out int num1) && int.TryParse(secInput, out int num2))
            {
                Console.WriteLine(GetMax(num1,num2));
            }
            else if (char.TryParse(firstInput, out char char1) && char.TryParse(secInput, out char char2))
            {
                Console.WriteLine(GetMax(char1, char2));
            }

            else
            {
                Console.WriteLine(GetMax(firstInput, secInput));
            }

        }

        public static int GetMax(int num1,int num2)
        {
            if(num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        public static char GetMax(char char1, char char2)
        {
            if (char1 >= char2)
            {
                return char1;
            }
            else
            {
                return char2;
            }
        }
        

        public static string GetMax(string str1, string str2)
        {
            int compare = str1.CompareTo(str2);
            if (compare > 0)
            {
                return str1;
            }
            else
                return str2;
        }

    }
}
