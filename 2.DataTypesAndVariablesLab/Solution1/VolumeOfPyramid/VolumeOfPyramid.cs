using System;

namespace VolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double volume = ((length * width) / 3) * height;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
