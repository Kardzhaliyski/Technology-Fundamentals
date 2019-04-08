using System;


class BackInThirtyMins
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        minutes += 30;
        if(minutes > 59)
        {
            minutes = minutes % 60;
            hours++;
        }
        hours = hours % 24;
        Console.WriteLine($"{hours}:{minutes:D2}");


    }
}

