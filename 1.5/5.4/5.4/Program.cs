using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            string[] lines = File.ReadAllText(@"C:\Users\Арина\numTask4.txt").Split(' ');

            int[] nums = Array.ConvertAll(lines, int.Parse);
            int maxNum = nums.Max();
            int sum = nums.Where(x => Math.Abs(x - maxNum) == 1).Sum();
            Console.WriteLine($"Сумма элементов, отличающихся от максимального на 1: {sum}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не найден");
        }
        catch (FormatException)
        {
            Console.WriteLine("Файл содержит некорректные данные");
        }
        catch (Exception e)
        {
            Console.WriteLine("Произошла ошибка: " + e.Message);
        }
        
    }
}