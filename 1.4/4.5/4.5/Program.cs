using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число x: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите число y: ");
        int b = int.Parse(Console.ReadLine());
        
        double x1 = -1;
        double x2 = 3;
        double y1 = -2;
        double y2 = 4;

        if (a >= x1 && a <= x2 && b >= y1 && b <= y2) //проверка принадлежат ли точки заданному диапазону;
        {
            Console.WriteLine($"Точка с координатами ({a}, {b}) принадлежит заштрихованной области.", a, b);
        }
        else
        {
            Console.WriteLine($"Точка с координатами ({a}, {b}) не принадлежит заштрихованной области.", a, b);
        }
    }
}