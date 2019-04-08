using System;


class CenterPoint
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        string centralPointString = GetCentralPoint(x1, y1, x2, y2);
        Console.WriteLine(centralPointString);


    }

    public static string GetCentralPoint(double x1, double y1, double x2, double y2)
    {
        double firstPtDistToCenter = Math.Abs(x1) + Math.Abs(y1);
        double secoundPtDistToCenter = Math.Abs(x2) + Math.Abs(y2);

        if (firstPtDistToCenter <= secoundPtDistToCenter)
        {
            return "(" + x1 + ", " + y1 + ')';
        }

        return "(" + x2 + ", " + y2 + ')';

    }
}

