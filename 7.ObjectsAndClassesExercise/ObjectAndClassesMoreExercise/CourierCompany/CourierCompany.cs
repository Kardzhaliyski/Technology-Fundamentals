using System;
using System.Collections.Generic;
using System.Linq;

namespace CourierCompany
{
    class CourierCompany
    {
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < numOfCars; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input
                    .Split();
                string carModel = tokens[0];
                string engineSpeed = tokens[1];
                string enginePower = tokens[2];
                string cargoWeight = tokens[3];
                string cargoType = tokens[4];
                cars.Add
                (
                    new Car
                    (
                    carModel,
                    engineSpeed,
                    enginePower,
                    cargoWeight,
                    cargoType
                    )
                );
            }

            string printType = Console.ReadLine();
            if (printType == "fragile")
            {
                PrintFragileCargo(cars);
            }

            else if (printType == "flamable")
            {
                PrintFlameblaCargo(cars);
            }

        }

        public static void PrintFragileCargo(List<Car> cars)
        {
             cars
                .Where(c => c.Cargo.Type == "fragile" && c.Cargo.Weight < 1000)
                .ToList()
                .ForEach(c => Console.WriteLine(c.Model));
        }

        public static void PrintFlameblaCargo(List<Car> cars)
        {
            cars
                .Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                .ToList()
                .ForEach(c => Console.WriteLine(c.Model));
        }
    }

    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
        }

        public Car(string model, string engineSpeed, string enginePower, string cargoWeight, string cargoType)
        {
            Model = model;
            Engine = new Engine(engineSpeed,enginePower);
            Cargo = new Cargo(cargoWeight,cargoType);
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }

    class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

        public Engine(string speed, string power)
        {
            Speed = int.Parse(speed);
            Power = int.Parse(power);
        }

        public int Speed { get; set; }
        public int Power { get; set; }
    }

    class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public Cargo(string weight, string type)
        {
            Weight = int.Parse(weight);
            Type = type;
        }

        public int Weight { get; set; }
        public string Type { get; set; }
    }
}
