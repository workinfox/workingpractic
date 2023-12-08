using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            string[] lines = File.ReadAllText(@"C:\Users\Арина\numTask5.txt").Split(' ');

            int[] nums = Array.ConvertAll(lines, int.Parse);
            int minNum = nums.Min();
            int maxNum = nums.Max();
            double result = nums.Where(x => x > minNum && x < maxNum).Average();
            Console.WriteLine($"Среднее арифметическое элементов между минимальным и максимальным: {result}");
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