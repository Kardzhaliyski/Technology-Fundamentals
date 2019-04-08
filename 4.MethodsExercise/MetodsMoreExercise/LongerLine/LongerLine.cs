using System;


class LongerLine
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        PrintTheLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        
    }

    public static void PrintTheLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        double firstLineLength = GetLineLength(x1, y1, x2, y2);
        double secoundLineLength = GetLineLength(x3, y3, x4, y4);

        if(firstLineLength >= secoundLineLength)
        {
            string formatedLine = FormatForPrintByClosestToCenter(x1, y1, x2, y2);
            Console.WriteLine(formatedLine);
        }
        else
        {
            string formatedLine = FormatForPrintByClosestToCenter(x3, y3, x4, y4);
            Console.WriteLine(formatedLine);
        }
    }

    public static double GetLineLength(double x1, double y1, double x2, double y2)
    {
        double lineLength = Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        return lineLength;
    }

    public static string FormatForPrintByClosestToCenter(double x1, double y1, double x2, double y2)
    {
        double firstPtDistToCenter = Math.Abs(x1) + Math.Abs(y1);
        double secoundPtDistToCenter = Math.Abs(x2) + Math.Abs(y2);
        if (firstPtDistToCenter <= secoundPtDistToCenter)
        {
            return string.Format($"({x1}, {y1})({x2}, {y2})");
        }
        return string.Format($"({x2}, {y2})({x1}, {y1})");

    }
}

