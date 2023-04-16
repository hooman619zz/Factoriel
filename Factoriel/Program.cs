using System;
using System.Numerics;

namespace Factoriel
{
    internal class Program
    {
        public static void Main(string[] args)
        {
// Hooman GhorbanKhanloo
            int count;
            count = Convert.ToInt32(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 2; i <= count; i++)
            {
                result *= i;
            }

            Console.WriteLine($"{count}! = " + result);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}