namespace _02_HeapStackRefOutArrayResize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, };

            

           
            CustomArrResize(ref numbers,   9, 10, 11, 23, 32, 34, 54,45,39);


        }


        public static void CustomArrResize(ref int[] arr, params int [] numbers2)
        {
            int[] newArr = new int[arr.Length + numbers2.Length];

           

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];

            }


            for (int i = 0; i < numbers2.Length; i++)
            {
                newArr[arr.Length + i] = numbers2[i];
            }



            arr = newArr;


            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }




        }

    }

}
