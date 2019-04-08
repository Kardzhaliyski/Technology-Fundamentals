using System;

namespace ArraysLab
{
    class WeekDays
    {
        static void Main(string[] args)
        {
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int inputNum = int.Parse(Console.ReadLine());
            
            if(inputNum > 0 && inputNum <= weekDays.Length)
            {
                Console.WriteLine(weekDays[inputNum -1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
