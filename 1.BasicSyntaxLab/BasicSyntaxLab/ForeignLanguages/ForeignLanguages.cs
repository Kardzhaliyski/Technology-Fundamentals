using System;


class ForeignLanguages
{
    static void Main(string[] args)
    {
        string countryName = Console.ReadLine();

        switch (countryName.ToLower())
        {
            case "usa":
            case "england":
                Console.WriteLine("English");
                break;
            case "spain":
            case "argentina":
            case "mexico":
                Console.WriteLine("Spanish");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }

    }
}

