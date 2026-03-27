using _07_NullableEnumStruct.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_NullableEnumStruct.Models
{
    internal class DrinkOrder
    {
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }

        public DrinkType_Enum Drink { get; set; }
        public DrinkSize_Enum Size { get; set; }

        public OrderStatus_Enum Status { get; set; }
        public decimal Price { get; set; }


        public DrinkOrder(int orderNumber, string customerName, DrinkType_Enum drink, DrinkSize_Enum size)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            Drink = drink;
            Size = size;
            Status = OrderStatus_Enum.New;
            Price = CalculatePrice();
        }

        public decimal CalculatePrice()
        {
            switch (Drink)
            {
                case DrinkType_Enum.Coffee:
                    switch (Size)
                    {
                        case DrinkSize_Enum.Small: Price = 3; break;
                        case DrinkSize_Enum.Medium: Price = 4; break;
                        case DrinkSize_Enum.Large: Price = 5; break;
                    }


                    break;

                case DrinkType_Enum.Tea:
                    switch (Size)
                    {
                        case DrinkSize_Enum.Small: Price = 2; break;
                        case DrinkSize_Enum.Medium: Price = 3; break;
                        case DrinkSize_Enum.Large: Price = 4; break;
                    }


                    break;

                case DrinkType_Enum.Juice:
                    switch (Size)
                    {
                        case DrinkSize_Enum.Small: Price = 4; break;
                        case DrinkSize_Enum.Medium: Price = 5; break;
                        case DrinkSize_Enum.Large: Price = 6; break;
                    }


                    break;

                case DrinkType_Enum.Water:
                    switch (Size)
                    {
                        case DrinkSize_Enum.Small: Price = 1; break;
                        case DrinkSize_Enum.Medium: Price = 1.5m; break;
                        case DrinkSize_Enum.Large: Price = 2; break;
                    }


                    break;





            }

            return Price;
        }

        public void UpdateStatus(OrderStatus_Enum newStatus)
        {
            Status = newStatus;

            Console.WriteLine($" sifaris {OrderNumber} status :{newStatus}");

        }

        public void Display()
        {
            Console.WriteLine("sifaris melumatlari");

            Console.WriteLine($"Sifaris nomresi: {OrderNumber}");
            Console.WriteLine($"Musteri Adi:{CustomerName}");
            Console.WriteLine($"Icki: {Drink}");
            Console.WriteLine($"Olcu:{Size}");
            Console.WriteLine($"Satus: {Status}");
            Console.WriteLine($"Qiymet:{Price}");
        }
    }
}

       



















