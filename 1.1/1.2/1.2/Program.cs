using System;
using System.Collections.Generic;

namespace Addingnumberstoalist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int a;

            do
            {
                Console.WriteLine("Введите число (введите 0 для того, чтобы закончить): ");
                a = Convert.ToInt32(Console.ReadLine());

                if (a != 0)
                {
                    nums.Add(a);
                }
            } while (a != 0);

            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            
            Console.WriteLine("Сумма всех элементов списка: " + sum);

            int comp = 1;
            foreach (int num in nums)
            {
                comp *= num;
            }
            Console.WriteLine("Произведение всех элементов списка: " + comp);
            
            double average = (double)sum / nums.Count;
            Console.WriteLine("Среднее всех элементов списка: " + average);
        }
    }
}