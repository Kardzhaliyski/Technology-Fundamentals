using System;


class DataTypes
{
    static void Main(string[] args)
    {
        string dataType = Console.ReadLine();
        string data = Console.ReadLine();
        ProcessAndPrint(dataType, data);
    }

    public static void ProcessAndPrint(string dataType,string data)
    {
        if (dataType.ToLower() == "int")
        {
            int processedNumber = ProcessInt(data);
            Console.WriteLine(processedNumber);
        }
        else if (dataType.ToLower() == "real")
        {
            double processedNumber = ProcessReal(data);
            Console.WriteLine($"{processedNumber:f2}");
        }
        else if(dataType.ToLower() == "string")
        {
            string processedText = ProcessString(data);
            Console.WriteLine(processedText);
        }
    }

    public static int ProcessInt(string data)
    {
        int number = int.Parse(data);
        return number * 2;
    }

    public static double ProcessReal(string data)
    {
        double number = double.Parse(data);
        return number * 1.5;
    }

    public static string ProcessString(string data)
    {
        data = '$' + data + '$';
        return data;
    }
}

