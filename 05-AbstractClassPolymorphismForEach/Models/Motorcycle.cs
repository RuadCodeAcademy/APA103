using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    internal class Motorcycle : Vehicle
    {
        public int EngineCapacity;
        public bool HasSidecar;
        public int MaxSpeed;
        public string Type;

        public Motorcycle(string brand, string model, int year, string plateNumber,
                          int engineCapacity, bool hasSidecar, int maxSpeed, string type)
            : base(brand, model, year, plateNumber)
        {
            this.EngineCapacity = engineCapacity;
            this.HasSidecar = hasSidecar;
            this.MaxSpeed = maxSpeed;
            this.Type = type;
        }

        public void ShowMotorcycleInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Engine: {EngineCapacity}cc, Type: {Type}, Sidecar: {HasSidecar}, MaxSpeed: {MaxSpeed}");
        }

        public double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 4 * 1.50;
        }
    }

}
