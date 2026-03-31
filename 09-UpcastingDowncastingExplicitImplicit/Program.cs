using _09_UpcastingDowncastingExplicitImplicit.Exchange;
using _09_UpcastingDowncastingExplicitImplicit.Models;

namespace _09_UpcastingDowncastingExplicitImplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region upcasting-downcasting
            //Dog dog = new Dog { AvgLifeTime = 13, Breed = "Golden", Gender = "male", Name = "Hatiko" };

            //Eagle eagle = new Eagle { AvgLifeTime = 300, FlySpeed = 100, Gender = "female" };


            //////upCasting implicit casting 

            ////Animal animal = dog;
            ////Animal animal1 = eagle;

            //////downCusting explicit casting

            ////Dog dog1 = (Dog)animal;
            ////Eagle eagle1 = (Eagle)animal;

            //Animal[] animals = { eagle, dog };


            //foreach (var animal in animals)
            //{
            //    //Eagle eagle1 = (Eagle)animal;
            //    Eagle eagle1 = animal as Eagle;
            //    //eagle1.Fly();

            //    if (eagle1 != null)
            //    {
            //        eagle1.Fly();
            //    }

            //    if (animal is Eagle)
            //    {
            //        Eagle eagle2 = animal as Eagle;
            //    }

            //} 
            #endregion

            #region unBoxing-Boxing
            ////Boxing

            //int a = 5;

            //Object b = a;

            ////unBoxing

            //int c = (int)b;

            ////string c = b as string;

            ////upcasting

            //Test test = new Test();

            //ITest itest = test; 
            #endregion

            Dollar dollar = new(300);
            //Console.WriteLine(dollar.USD);

            Manat manat = new(170);
            //Console.WriteLine(manat.AZN);

            Dollar dollar1 = manat;
            Console.WriteLine(dollar1.USD);

            Manat manat1 = dollar;
            Console.WriteLine(manat1.AZN);






        }
    }

    //public struct Test : ITest
    //{
    //    public int X { get; set; }
    //    public void Y()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public interface ITest()
    //{
    //    void Y();
    //}
}
