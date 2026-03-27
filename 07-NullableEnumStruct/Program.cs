using _07_NullableEnumStruct.Enums;
using _07_NullableEnumStruct.Models;

namespace _07_NullableEnumStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrinkOrder Sifaris1 = new(101, "Ali", Enums.DrinkType_Enum.Coffee, Enums.DrinkSize_Enum.Medium);

            Sifaris1.Display();
            Console.WriteLine();

            Sifaris1.UpdateStatus(Enums.OrderStatus_Enum.Preparing);
            Console.WriteLine();

            Sifaris1.Display();
            Console.WriteLine();

            Sifaris1.UpdateStatus(Enums.OrderStatus_Enum.Ready);
            Console.WriteLine();

            Sifaris1.Display();
            Console.WriteLine();

            Sifaris1.UpdateStatus(Enums.OrderStatus_Enum.Delivered);
            Console.WriteLine();

            Sifaris1.Display();
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();


            DrinkOrder Sifaris2 = new(102, "Leyla", Enums.DrinkType_Enum.Tea, Enums.DrinkSize_Enum.Large);

            Sifaris2.Display();
            Console.WriteLine();

            Sifaris2.UpdateStatus(Enums.OrderStatus_Enum.Preparing);
            Console.WriteLine();

            Sifaris2.Display();
            Console.WriteLine();

            Sifaris2.UpdateStatus(Enums.OrderStatus_Enum.Ready);
            Console.WriteLine();

            Sifaris2.Display();
            Console.WriteLine();

            Sifaris2.UpdateStatus(Enums.OrderStatus_Enum.Delivered);
            Console.WriteLine();

            Sifaris2.Display();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();


            DrinkOrder Sifaris3 = new(103, "Vüqar", Enums.DrinkType_Enum.Juice, Enums.DrinkSize_Enum.Small);

            Sifaris3.Display();
            Console.WriteLine();

            Sifaris3.UpdateStatus(Enums.OrderStatus_Enum.Preparing);
            Console.WriteLine();

            Sifaris3.Display();
            Console.WriteLine();

            Sifaris3.UpdateStatus(Enums.OrderStatus_Enum.Ready);
            Console.WriteLine();

            Sifaris3.Display();
            Console.WriteLine();

            Sifaris3.UpdateStatus(Enums.OrderStatus_Enum.Delivered);
            Console.WriteLine();

            Sifaris3.Display();

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Bütün DrinkType deyerleri");

            Console.WriteLine();

            

            foreach (DrinkType_Enum drink in Enum.GetValues(typeof(DrinkType_Enum)))
            {
                Console.WriteLine(drink);
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();


            Console.WriteLine("Bütün DrinkSize deyerleri");

            Console.WriteLine();

            foreach(DrinkSize_Enum size in Enum.GetValues(typeof(DrinkSize_Enum)))
            {
                Console.WriteLine(size);
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Bütün OrderStatus deyerləri");

            Console.WriteLine();

            foreach(OrderStatus_Enum status in Enum.GetValues(typeof(OrderStatus_Enum)))
            {
                Console.WriteLine(status);
            }


            Console.WriteLine();

            Console.WriteLine("-------------------------------");

            Console.WriteLine();

            Console.WriteLine("enumsin deyerini stringe cevirme");
            Console.WriteLine();

            Console.WriteLine(DrinkType_Enum.Coffee.ToString());
            Console.WriteLine(DrinkSize_Enum.Large.ToString());

            Console.WriteLine();

            Console.WriteLine("string deyerini enums deyerine cevirme");
            Console.WriteLine();

            string drinkTypestr = "Tea";
            DrinkType_Enum drinkType = (DrinkType_Enum)Enum.Parse(typeof(DrinkType_Enum), drinkTypestr);
            Console.WriteLine(drinkType);
            Console.WriteLine();

            string drinkSizestr = "Medium";

            DrinkSize_Enum drinkSize = (DrinkSize_Enum)Enum.Parse(typeof(DrinkSize_Enum), drinkSizestr);

            Console.WriteLine(drinkSize);

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();



            Console.WriteLine($"umumi sifaris:{3}");

            Console.WriteLine($"brinci sifarisin qiymeti:{Sifaris1.Price}");

            Console.WriteLine($"ikinci sifarisin qiymeti:{Sifaris2.Price}");

            Console.WriteLine($"ucuncu sifarisin qiymeti:{Sifaris3.Price}");

            decimal TotalAmount = Sifaris1.Price + Sifaris2.Price + Sifaris3.Price;

            Console.WriteLine($"Umumi mebleg:{TotalAmount}");





        }
    }
}
