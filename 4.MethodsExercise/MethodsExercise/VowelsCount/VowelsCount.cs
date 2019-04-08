using System;

namespace VowelsCount
{
    class VowelsCount
    {
        

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] vowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
            PrintNumOfVowels(text,vowels);
            
        }

        public static void PrintNumOfVowels(string text,char[] array)
        {
            int vowelsCounter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Array.Exists(array,element => element == text[i]))
                {
                    vowelsCounter++;
                }
            }
            Console.WriteLine(vowelsCounter);
        }
    }
}
