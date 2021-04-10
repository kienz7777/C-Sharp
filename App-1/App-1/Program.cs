using System;

namespace App_1
{
    class Program
    {
        public static int SumOfArray(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[] cars = { 1, 2, 3, 4, 5 };

            int kq = SumOfArray(cars);

            Console.WriteLine(kq);

        }
    }
}
