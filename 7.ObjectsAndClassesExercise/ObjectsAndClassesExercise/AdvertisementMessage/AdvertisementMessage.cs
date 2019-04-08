using System;

namespace AdvertisementMessage
{
    class AdvertisementMessage
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            var advGenerator = new Advartisment();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
            Console.WriteLine(advGenerator.GenerateMessage());
            }


        }

        


        public class Advartisment
        {
            public string[] PhraseStrings { get;} = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            public string[] EventStrings { get;} = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            public string[] Authors { get;} = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            public string[] Cities { get;} = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            public string GenerateMessage()
            {
                string message = "";

                int randomNum = random.Next(0, PhraseStrings.Length - 1);
                message += PhraseStrings[randomNum];
                randomNum = random.Next(0, EventStrings.Length - 1);
                message += " " + EventStrings[randomNum];
                randomNum = random.Next(0, Authors.Length - 1);
                message += " " + Authors[randomNum];
                randomNum = random.Next(0, Cities.Length - 1);
                message += " " + Cities[randomNum];
                return message;
            }
        }
    }
}
