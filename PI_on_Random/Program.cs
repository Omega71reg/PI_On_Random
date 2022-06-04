using System;
using System.Numerics;

namespace PI_on_Random
{
    class Program
    {
        private static readonly Random Rand = new Random();
        static void Main(string[] args)
        {
            int countInCircle = 0;
            int countAll = 0;
            Console.WriteLine("Введи точность вычесления: ");
            countAll = Int32.Parse(Console.ReadLine()?? throw new InvalidOperationException());

            for (int i = 0; i < countAll; i++)
            {
                double x = RandFrom0to1();
                double y = RandFrom0to1();

                if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1)
                countInCircle++;
            }

            double pi = 4 * (double)countInCircle / countAll;

            Console.WriteLine("PI = " + pi);
        }
        private static double RandFrom0to1()
        {
            return Rand.NextDouble();
        }
    }
}
