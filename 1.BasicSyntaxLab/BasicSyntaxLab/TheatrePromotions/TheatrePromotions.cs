using System;


class TheatrePromotions
{
    static void Main(string[] args)
    {
        string day = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        if (day.ToLower() == "weekday")
        {
            if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                Console.WriteLine("12$");
            else if (age > 18 && age <= 64)
                Console.WriteLine("18$");
            else
                Console.WriteLine("Error!");
        }
        else if(day.ToLower() == "weekend")
        {
            if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                Console.WriteLine("15$");
            else if (age > 18 && age <= 64)
                Console.WriteLine("20$");
            else
                Console.WriteLine("Error!");
        }
        else if(day.ToLower() == "holiday")
        {
            if (age >= 0 && age <= 18 )
                Console.WriteLine("5$");
            else if (age > 18 && age <= 64)
                Console.WriteLine("12$");
            else if (age > 64 && age <= 122)
                Console.WriteLine("10$");
            else
                Console.WriteLine("Error!");
        }

    }
}

