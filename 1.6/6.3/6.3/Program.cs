using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0 && n % 10 == 0)
        {
            Console.WriteLine($"Число {n} является чётным и кратным 10");
        }
        else
        {
            Console.WriteLine($"Число {n} не является чётным и кратным 10");
        }
    }
}