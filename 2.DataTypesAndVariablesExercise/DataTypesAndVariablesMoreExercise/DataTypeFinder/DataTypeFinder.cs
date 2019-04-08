using System;


class DataTypeFinder
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();


        while(input != "END")
        {
            bool isType;
            if(isType = int.TryParse(input,out int num))
            {
                Console.WriteLine($"{input} is integer type");
            }
            else if (isType = double.TryParse(input, out double dnum))
            {
                Console.WriteLine($"{input} is floating point type");
            }
            else if (isType = char.TryParse(input, out char char1))
            {
                Console.WriteLine($"{input} is character type");
            }
            else if (isType = bool.TryParse(input, out bool bool1))
            {
                Console.WriteLine($"{input} is boolean type");
            }
            else 
            {
                Console.WriteLine($"{input} is string type");
            }
            input = Console.ReadLine();
        }
    }
}

