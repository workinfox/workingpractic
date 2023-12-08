using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int x1 = -2;
        int x2 = 2;
        int y1 = -3;
        int y2 = -3;
        int x3 = 0;
        int y3 = 2;
        Console.Write("Введите число x: ");
        int x0 = int.Parse(Console.ReadLine());
        Console.Write("Введите число y: ");
        int y0 = int.Parse(Console.ReadLine());
       
        
        int a = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
        int b = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
        int c = (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0);
 
        if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
        {
            Console.WriteLine("Принадлежит треугольнику");
        }
        else
        {
            Console.WriteLine("Не принадлежит треугольнике");
        }
        
    }
}