using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите положительное число a: ");
        int a = int.Parse(Console.ReadLine());
        
        int sum = 0;
        
        while (true)
        {
            Console.Write("Введите число: ");
            int nums = int.Parse(Console.ReadLine());

            if (nums < 0)
            {
                break;
            }

            if (nums % a == 0)
            {
                sum += nums;
            }
        }
        Console.WriteLine($"Сумма чисел, делящихся на {a} нацело равно: {sum}");
    }
}