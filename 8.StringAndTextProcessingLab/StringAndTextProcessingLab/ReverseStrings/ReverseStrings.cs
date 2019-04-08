using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace ReverseStrings
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var stringInput = Console.ReadLine();
                if (stringInput == "end")
                {
                    break;
                }
                var newString = stringInput.Reverse().ToArray();
                Console.WriteLine($"{stringInput} = {string.Join("", newString)}");
            }

            //var newString2 = "";
            //for (int i = 0; i < stringInput.Length; i++)
            //{
            //    newString2 += stringInput[stringInput.Length - 1 - i];
            //}

            //Console.WriteLine(newString2);

            //var newString3 = "";
            //for (int i = stringInput.Length - 1; i >= 0; i--)
            //{
            //    newString3 += stringInput[i];
            //}

            //Console.WriteLine(newString3);


        }
    }
}
