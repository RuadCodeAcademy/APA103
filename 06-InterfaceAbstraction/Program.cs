using _06_InterfaceAbstraction.Models;

namespace _06_InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();

            Console.WriteLine("1 ci ededi daxil et :");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2 ci ededi daxil et :");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("emeliyyati   ededi daxil et :");
            string op= Console.ReadLine();

            Console.WriteLine("Netice");
            calc.Calculate(num1, num2, op);




        }
    }
}
