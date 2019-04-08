using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue2
{
    class VehicleCatalogue2
    {
        static void Main(string[] args)
        {
            var vehicleTypes = new List<VehicleFamily>();
            vehicleTypes.Add(new VehicleFamily("Cars"));
            vehicleTypes.Add(new VehicleFamily("Trucks"));
            var modelList = new Dictionary<string, Vehicle>();

            while (true)
            {
                string inputModel = Console.ReadLine();
                if (inputModel == "End")
                {
                    break;
                }

                modelList = AddVehicle(vehicleTypes, modelList, inputModel);
            }

            while (true)
            {
                string inputModel = Console.ReadLine();
                if (inputModel == "Close the Catalogue")
                {
                    break;
                }

                if (modelList.ContainsKey(inputModel))
                {
                    Console.WriteLine(modelList[inputModel]);
                }
            }

            foreach (var vehicleFamily in vehicleTypes)
            {
                vehicleFamily.PrintAverageHorsepower();
            }


        }

        private static Dictionary<string, Vehicle> AddVehicle(List<VehicleFamily> vehicleTypes, Dictionary<string, Vehicle> modelList, string inputModel)
        {
            string[] tokens = inputModel
                .Split();
            string type = tokens[0];
            string model = tokens[1];
            string color = tokens[2];
            string horsepower = tokens[3];

            Vehicle vehicle = new Vehicle(type, model, color, horsepower);

            int familyIndex = vehicleTypes.FindIndex(t => t.Name.ToLower() == type.ToLower() + 's');
            vehicleTypes[familyIndex].AddVehicle(vehicle);
            modelList[model] = vehicle;

            return modelList;
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

    class VehicleFamily
    {
        public VehicleFamily(string name)
        {
            Name = name.First().ToString().ToUpper() + name.Substring(1).ToLower();
        }

        public List<Vehicle> ModelList { get; } = new List<Vehicle>();
        public string Name { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            ModelList.Add(vehicle);
        }

        public double GetAverageHorsepower()
        {
            if (ModelList.Count > 0)
            {
                double averageHorsepower = ModelList
                    .Average(v => v.Horsepower);
                return averageHorsepower;
            }

            return 0;
        }

        public void PrintAverageHorsepower()
        {
            double avarageHorsepower = GetAverageHorsepower();
            Console.WriteLine($"{Name} have average horsepower of: {avarageHorsepower:f2}.");
        }
    }
}
