using _04_AccessModifiresEncupsulationNamespace.Models;

namespace _04_AccessModifiresEncupsulationNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();

            //student.name = "Test";

            //Console.WriteLine(student.name);

            //student.GetInfo();


            //Person person = new Person();

            Car car = new Car();
            car.HorsePower = 200;
            Console.WriteLine(car.HorsePower);




            
        }
    }
}
