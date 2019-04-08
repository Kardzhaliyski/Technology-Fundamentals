using System;


class CommonElements
{
    static void Main(string[] args)
    {
        string[] arrFirst = Console.ReadLine().Split();
        string[] arrSecound = Console.ReadLine().Split();

        for (int i = 0; i < arrSecound.Length; i++)
        {
            for (int j = 0; j < arrFirst.Length; j++)
            {
                if(arrSecound[i] == arrFirst[j])
                {
                    Console.Write(arrFirst[j] + " ");
                }
            }
        }
    }
}
