using System;


class SortNumbers
{
    static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        int highestNum = 0;
        int secoundNum = 0;
        int lastNumber = 0;

        if (firstNum >= secNum)
        {
            if(firstNum >= thirdNum)
            {
                highestNum = firstNum;
                if(thirdNum >= secNum)
                {
                    secoundNum = thirdNum;
                    lastNumber = secNum;
                }
                else if(secNum >= thirdNum)
                {
                    secoundNum = secNum;
                    lastNumber = thirdNum;
                }
            }
            else if(thirdNum >= firstNum)
            {
                highestNum = thirdNum;
                secoundNum = firstNum;
                lastNumber = secNum;
            }
        }
        else if(secNum > firstNum)
        {
            if(secNum >= thirdNum)
            {
                highestNum = secNum;
                if(firstNum >= thirdNum)
                {
                    secoundNum = firstNum;
                    lastNumber = thirdNum;
                }
                else
                {
                    secoundNum = thirdNum;
                    lastNumber = firstNum;
                }
            }
            else if(thirdNum >= secNum)
            {
                highestNum = thirdNum;
                secoundNum = secNum;
                lastNumber = firstNum;
            }
        }
        Console.WriteLine(highestNum);
        Console.WriteLine(secoundNum);
        Console.WriteLine(lastNumber);


    }
}

