using _05_AbstractClassPolymorphismForEach.Models;

namespace _05_AbstractClassPolymorphismForEach
{
    internal class Program
    {
        static void Main()
        {
           
            Car car1 = new Car("Mercedes", "E200", 2023, "10-AA-001", 4, 500, true, 220);
            Car car2 = new Car("BMW", "320i", 2022, "10-AA-002", 4, 480, true, 235);
            Car car3 = new Car("Toyota", "Camry", 2021, "10-AA-003", 4, 524, true, 210);

            
            Motorcycle moto1 = new Motorcycle("Yamaha", "R1", 2023, "10-M-001", 998, false, 299, "Sport");
            Motorcycle moto2 = new Motorcycle("Harley-Davidson", "Cruiser", 2022, "10-M-002", 1868, true, 180, "Cruiser");

            
            Truck truck1 = new Truck("MAN", "TGX", 2020, "10-T-001", 18, 3, 12, 120);
            Truck truck2 = new Truck("Volvo", "FH16", 2021, "10-T-002", 25, 4, 18, 110);

            Console.WriteLine("---- Cars ----");
            car1.ShowCarInfo();
            Console.WriteLine("Fuel cost (500km): " + car1.CalculateFuelCost(500));

            car2.ShowCarInfo();
            Console.WriteLine("Fuel cost (500km): " + car2.CalculateFuelCost(500));

            car3.ShowCarInfo();
            Console.WriteLine("Fuel cost (500km): " + car3.CalculateFuelCost(500));

            Console.WriteLine("\n---- Motorcycles ----");
            moto1.ShowMotorcycleInfo();
            Console.WriteLine("Fuel cost (300km): " + moto1.CalculateFuelCost(300));

            moto2.ShowMotorcycleInfo();
            Console.WriteLine("Fuel cost (300km): " + moto2.CalculateFuelCost(300));

            Console.WriteLine("\n---- Trucks ----");
            truck1.ShowTruckInfo();
            Console.WriteLine("Fuel cost (800km): " + truck1.CalculateFuelCost(800));

            truck2.ShowTruckInfo();
            Console.WriteLine("Fuel cost (800km): " + truck2.CalculateFuelCost(800));

            
            Console.WriteLine("\n-- Loading Truck --");
            truck1.LoadCargo(5);
            Console.WriteLine("New fuel cost (800km): " + truck1.CalculateFuelCost(800));

            
            int totalVehicles = 7;

            double avgSpeed = (
                car1.MaxSpeed + car2.MaxSpeed + car3.MaxSpeed +
                moto1.MaxSpeed + moto2.MaxSpeed +
                truck1.MaxSpeed + truck2.MaxSpeed
            );

            double maxFuelCost = Math.Max(
                Math.Max(car1.CalculateFuelCost(500), car2.CalculateFuelCost(500)),
                Math.Max(car3.CalculateFuelCost(500),
                Math.Max(moto1.CalculateFuelCost(300),
                Math.Max(moto2.CalculateFuelCost(300),
                Math.Max(truck1.CalculateFuelCost(800), truck2.CalculateFuelCost(800)))))
            );

            Console.WriteLine("\n---- Statistics ----");
            Console.WriteLine("Total vehicles: " + totalVehicles);
            Console.WriteLine("Average max speed: " + avgSpeed);
            Console.WriteLine("Most expensive fuel cost: " + maxFuelCost);
        }
    }
}
