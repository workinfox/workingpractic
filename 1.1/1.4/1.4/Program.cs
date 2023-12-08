using System;
using System.Collections.Generic;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int a;
            Console.Write("Введите минимальное значение диапазона: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальное значение диапазона: ");
            int max = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int randn;
            for (int i = 0; i < 10; i++)
            {
                randn = rand.Next(min, max + 1);
                nums.Add(randn);
            }
            Console.WriteLine("Сгенерированный список случайных чисел: " + string.Join(" ", nums));
        }
    }
}