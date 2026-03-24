using _06_InterfaceAbstraction.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfaceAbstraction.Models
{
    public class Calculation : ICalculation
    {
        public void Calculate(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;

                case "-":
                    Console.WriteLine(num1 - num2);
                    break;

                case "*":
                    Console.WriteLine(num1 * num2);
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine(" 0 a bolmek olmaz");
                    }

                    Console.WriteLine(num1 / num2);
                    break;

                default: Console.WriteLine("Yanlış əməliyyat seçildi!");
                    break;

            }
        }
    }
}
