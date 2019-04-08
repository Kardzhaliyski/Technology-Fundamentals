using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class SpeedRacing
    {
        static void Main(string[] args)
        {
            var cars = new Dictionary<string, Car>();
            int numOfCars = int.Parse(Console.ReadLine());

            for (int currentCar = 0; currentCar < numOfCars; currentCar++)
            {
                string inputCar = Console.ReadLine();
                AddCar(cars, inputCar);
            }

            while (true)
            {
                string inputDriveDetails = Console.ReadLine();

                if (inputDriveDetails == "End")
                {
                    break;
                }

                string[] tokens = inputDriveDetails
                    .Split();
                string carModel = tokens[1];
                string distanceToDestination = tokens[2];

                cars[carModel].Travel(distanceToDestination);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Value);
            }

        }

        private static void AddCar(Dictionary<string, Car> cars, string inputCar)
        {
            string[] tokens = inputCar
                .Split();
            string modelName = tokens[0];
            string fuelAmount = tokens[1];
            string fuelPerKm = tokens[2];

            cars[modelName] = new Car(modelName,fuelAmount,fuelPerKm);
        }
    }

    class Car
    {
        public Car(string model, string fuelAmount, string fuelPerKm)
        {
            Model = model;
            Fuel = double.Parse(fuelAmount);
            FuelPerKM = double.Parse(fuelPerKm);
        }

        public string Model { get; set; } 
        public double Fuel { get; set; }
        public double FuelPerKM { get; set; }
        public int TraveledDistance { get; set; } = 0;

        public void Travel(string distanceString)
        {
            int distanceToTravel = int.Parse(distanceString);
            double fuelNeeded = distanceToTravel * FuelPerKM;

            if (fuelNeeded <= Fuel)
            {
                Fuel -= fuelNeeded;
                TraveledDistance += distanceToTravel;
            }

            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{Model} {Fuel:f2} {TraveledDistance}";
        }
    }
}
