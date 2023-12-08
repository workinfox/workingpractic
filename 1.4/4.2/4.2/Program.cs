using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\\Users\\Арина\\numsTask2.txt"); 

        string[] values = lines[0].Split(';'); 

        double sumOfPositives = 0; 

        foreach (var value in values)
        {
            double number = Convert.ToDouble(value); 
            if (number <= 0) 
            {
                break;
            }
            sumOfPositives += number; 
        }

        Console.WriteLine("Сумма положительных элементов: " + sumOfPositives);
    }
}