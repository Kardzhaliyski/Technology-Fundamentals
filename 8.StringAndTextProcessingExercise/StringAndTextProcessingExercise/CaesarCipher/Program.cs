using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            PrintEncryptedText(inputText);

        }

        public static void PrintEncryptedText(string text)
        {
            string encryptedText = "";
            for (int i = 0; i < text.Length; i++)
            {
                encryptedText += (char)(text[i] + 3);
            }

            Console.WriteLine(encryptedText);
        }
    }
}
