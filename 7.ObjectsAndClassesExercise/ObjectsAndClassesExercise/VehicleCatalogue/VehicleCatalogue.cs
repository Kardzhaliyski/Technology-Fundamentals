using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace VehicleCatalogue
{
    class VehicleCatalogue
    {
        static void Main(string[] args)
        {
            var catalogue = new Dictionary<string, Dictionary<string, Vehicle>>();
            catalogue["Cars"] = new Dictionary<string, Vehicle>();
            catalogue["Trucks"] = new Dictionary<string, Vehicle>();

            while (true)
            {
                string inputVehicleData = Console.ReadLine();
                if (inputVehicleData == "End")
                {
                    break;
                }

                AddingVehicle(catalogue, inputVehicleData);
            }

            while (true)
            {
                string inputModel = Console.ReadLine();
                if (inputModel == "Close the Catalogue")
                {
                    break;
                }

                if (catalogue.Any(c => c.Value.ContainsKey(inputModel)))
                {
                    Vehicle currVehicle = GetVehicle(catalogue, inputModel);
                    Console.WriteLine(currVehicle);
                }
            }

            PrintAverageHorsepower(catalogue);

        }

        private static void PrintAverageHorsepower(Dictionary<string, Dictionary<string, Vehicle>> catalogue)
        {
            var avrgHorsepowerDict = GetAvrgHorsepowerDict(catalogue);
            foreach (var type in avrgHorsepowerDict)
            {
                Console.WriteLine($"{type.Key} have average horsepower of: {type.Value:f2}.");
            }
        }

        private static Dictionary<string, double> GetAvrgHorsepowerDict(Dictionary<string, Dictionary<string, Vehicle>> catalogue)
        {
            var avarageHorsepowerDict = new Dictionary<string, double>();
            foreach (var type in catalogue)
            {
                if (type.Value.Count == 0)
                {
                    avarageHorsepowerDict[type.Key] = 0;
                }

                else
                {
                    avarageHorsepowerDict[type.Key] = type.Value.Average(t => t.Value.Horsepower);
                }
            }

            return avarageHorsepowerDict;

        }

        private static Vehicle GetVehicle(Dictionary<string, Dictionary<string, Vehicle>> catalogue, string inputModel)
        {

            foreach (var vehicleType in catalogue)
            {
                if (vehicleType.Value.ContainsKey(inputModel))
                {
                    var currVehicle = vehicleType.Value.FirstOrDefault(v => v.Key == inputModel).Value;
                    return currVehicle;
                }
            }

            return null;
        }

        private static void AddingVehicle(Dictionary<string, Dictionary<string, Vehicle>> catalogue, string input)
        {
            var tokens = input.Split();
            var type = tokens[0];
            var model = tokens[1];
            var color = tokens[2];
            var horsepower = tokens[3];

            if (type.ToLower() == "car")
            {
                catalogue["Cars"][model] = new Vehicle(type, model, color, horsepower);
            }
            else
            {
                catalogue["Trucks"][model] = new Vehicle(type, model, color, horsepower);

            }
        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, string horsepower)
        {
            Type = type;
            Type = Type.First().ToString().ToUpper() + Type.Substring(1);
            Model = model;
            Color = color;
            Horsepower = int.Parse(horsepower);
        }

        public Vehicle()
        {

        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }

        public override string ToString()
        {
            return
            (
                $"Type: {Type}" +
                Environment.NewLine +
                $"Model: {Model}" +
                Environment.NewLine +
                $"Color: {Color}" +
                Environment.NewLine +
                $"Horsepower: {Horsepower}"
            );
        }
    }
}
