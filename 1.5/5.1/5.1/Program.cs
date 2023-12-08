using System;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        try
        {
            string[] lines = File.ReadAllText(@"C:\Users\Арина\numTask1.txt").Split(' ');
            int[] numbers = Array.ConvertAll(lines, int.Parse);

            int minIndex = 0;
            int minArray = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minArray)
                {
                    minArray = numbers[i];
                    minIndex = i;
                }
            }

            int prov = 1; //произведение  = 1
            for (int i = minIndex + 1; i < numbers.Length; i++)
            {
                prov *= numbers[i];
            }

            Console.WriteLine($"Произведение элементов после минимального: {prov}");
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