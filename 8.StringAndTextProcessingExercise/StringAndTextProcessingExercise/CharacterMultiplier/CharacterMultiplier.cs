using System;

namespace CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine()
                .Split();
            string str1 = strings[0];
            string str2 = strings[1];
            double sum = 0.0;
            for (int i = 0; i < Math.Max(str1.Length,str2.Length); i++)
            {
                if (str1.Length  > i && str2.Length  > i)
                {
                    sum += str1[i] * str2[i];
                }

                else
                {
                    if (str1.Length > str2.Length)
                    {
                        sum += str1[i];
                    }

                    else
                    {
                        sum += str2[i];
                    }
                }
            }

            Console.WriteLine(sum);


        }
    }
}
