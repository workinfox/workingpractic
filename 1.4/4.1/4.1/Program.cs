using System;

namespace Prnatnums
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число n: ");
            int a = int.Parse(Console.ReadLine());

            int product = 1;
            for (int i = 1; i <= a; i++)
            {
                if (i % 3 == 0)
                {
                    product *= i;
                }
            }
            Console.WriteLine("Произведение натуральных чисел, кратных трём и не превышающих число n: " + product);
        }
    }
}