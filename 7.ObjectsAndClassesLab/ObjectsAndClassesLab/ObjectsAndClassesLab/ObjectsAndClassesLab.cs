using System;
using System.Globalization;

namespace ObjectsAndClassesLab
{
    class ObjectsAndClassesLab
    {
        static void Main()
        {
            string inputDate = Console.ReadLine();
            DayOfWeek day = DateTime.ParseExact(inputDate,"d-MM-yyyy",CultureInfo.InvariantCulture).DayOfWeek;
            Console.WriteLine(day);

        }
    }
}
