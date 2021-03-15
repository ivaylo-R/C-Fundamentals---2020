using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main()
        {
            string line = string.Empty;
            List<Catalogue> list = new List<Catalogue>();
            while ((line = Console.ReadLine()) != "End")
            {

                string[] input = line.Split().ToArray();
                string typeOfVehicle = input[0];
                string modelz = input[1];
                string color = input[2];    
                double horsePower = double.Parse(input[3]);
                Catalogue myCatalogue = new Catalogue(typeOfVehicle, modelz, color, horsePower);
                list.Add(myCatalogue);
            }

            string model = string.Empty;
            while ((model = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(list.FirstOrDefault(x => x.Model == model).ToString());

            }

            var cars = list.FindAll(x => x.Type == "car");
            var carHorsePower = cars.Sum(x => x.HorsePower);
            var carAverage = carHorsePower / cars.Count;

            var trucks = list.FindAll(x => x.Type == "truck");
            var truckHorsePower = trucks.Sum(x => x.HorsePower);
            var truckAverage = truckHorsePower / trucks.Count;
            Console.WriteLine($"Cars have average horsepower of: {carAverage:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAverage:f2}.");
        }
    }
    class Catalogue
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
        public Catalogue(string typeOfVehicle,string model,string color,double horsePower)
        {
            this.Type = typeOfVehicle;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (this.Type == "car")
            {
                stringBuilder.AppendLine($"Type: Car");
            }
            else
            {
                stringBuilder.AppendLine($"Type: Truck");
            }
            
            stringBuilder.AppendLine($"Model: {this.Model}");
            stringBuilder.AppendLine($"Color: {this.Color}");
            stringBuilder.AppendLine($"Horsepower: {this.HorsePower}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
