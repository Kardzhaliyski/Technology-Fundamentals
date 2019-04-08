using System;


class PadawanEquipment
{
    static void Main(string[] args)
    {
        decimal money = decimal.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
        decimal robePrice = decimal.Parse(Console.ReadLine());
        decimal beltPrice = decimal.Parse(Console.ReadLine());

        decimal totalRobesPrice = robePrice * students;
        decimal totalLightsabersPrice = lightsaberPrice * (Math.Ceiling(students * 1.1m));
        decimal totalBeltsPrice = beltPrice * (students - (students / 6));

        decimal total = totalBeltsPrice + totalLightsabersPrice + totalRobesPrice;

        if (total <= money)
        {
            Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivan Cho will need {(total - money):f2}lv more.");
        }

    }
}

