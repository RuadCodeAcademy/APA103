using System.Data;

namespace _01_C_IntroMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ci tapsiriq 
            //double result1 = Toplama(2, 4);
            //double result2 = Ferq(6, 2);
            //double result3 = Hasil(3, 5);
            //double result4 = Bolme(9, 2);

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //Console.WriteLine(result4);


            //2 ci tapsiriq
            //int[] numbers = { 14, 20, 35, 40, 57, 60, 100 };
            //Tekvecutededlertapma(numbers);

            //3 cu tapsiriq

            //int[] numbers1 = { 14, 20, 35, 40, 57, 60, 100 };
            //Hem4Hemde5Ebolunenlerincemi(numbers1);

            //4 cu tapsiriq


            //Console.WriteLine("Cümleni daxil et:");
            //string cumle = Console.ReadLine();

            
            //Console.WriteLine("Simvolu daxil et:");
            //char simvol = Console.ReadKey().KeyChar;  
            //Console.WriteLine(); 

            
            //Simvolsayi(cumle, simvol);







        }

        #region tapsiriq 1.Hər biri 2 parametr qəbul edib və riyazi əməlləri yerinə yetiren method yazin.



        //static double Toplama(double number1, double number2)
        //{
        //    double number = number1 + number2;
        //    return number;
        //}

        //static double Ferq(double number1, double number2)
        //{
        //    double number = number1 - number2;
        //    return number;
        //}

        //static double Hasil(double number1, double number2)
        //{
        //    double number = number1 * number2;
        //    return number;
        //}

        //static double Bolme(double number1, double number2)
        //{
        //    double number = number1 / number2;
        //    return number;
        //}

        #endregion

        #region tapsiriq  2.Verilen arqumentlere uygun tek ve cut edeleri tapan method yazin.(14, 20, 35, 40, 57, 60, 100)

        //static void Tekvecutededlertapma(int[] numbers)
        //{

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] % 2 == 0)
        //        {
        //            Console.WriteLine("cut ededler: " + numbers[i]);
        //        }
        //        else
        //        {
        //            Console.WriteLine("tek ededler: " + numbers[i]);
        //        }
        //    }

        #endregion


        #region tapsiriq 3.Verilmis arreyde elementlerin həm 4-ə, həm də 5-ə bölününen elementlerin cemini tapin.[14, 20, 35, 40, 57, 60, 100]

        //static void Hem4Hemde5Ebolunenlerincemi(int[] numbers1)
        //{
        //    int cem = 0;

        //    for (int i = 0; i < numbers1.Length; i++)
        //    {

        //        if (numbers1[i] % 4 == 0 && numbers1[i] % 5 == 0)
        //        {
        //            cem += numbers1[i];
        //        }
        //    }

        //    Console.WriteLine("4-e ve 5-e bölünən ededlerin cemi: " + cem);

        #endregion


        #region tapsiriq 4.Daxil edilmiş cümlədə daxil edilmis simvoldan nece eded olduğunu tapan Proqramın alqoritmini yazin.(Cumle serbestdir).


        //static void Simvolsayi(string cumle, char simvol)
        //{

        //    cumle  = cumle.ToLower();
        //    simvol = Char.ToLower(simvol);



        //    int say = 0;
        //    foreach (char c in cumle)
        //    {
        //        if (c == simvol)
        //        {
        //            say++;
        //        }
        //    }
        //    Console.WriteLine($"cumlede {simvol} simvolunun sayi : {say}");
        //}

        #endregion














    }
}

