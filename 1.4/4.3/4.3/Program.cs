using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\\Users\\Арина\\numsTask3.txt"); // Чтение всех строк из файла

        string[] nums = lines[0].Split(new char[] {',', ' ', ';'}, StringSplitOptions.RemoveEmptyEntries); // Разделение первой строки по символам: ',', ' ', ';'
        int min, max;

        if (nums.Length > 0 && int.TryParse(nums[0], out int firstNumber))
        {
            min = firstNumber;
            max = firstNumber;

            foreach (var num in nums)
            {
                if (int.TryParse(num, out int currentNumber))
                {
                    if (currentNumber == 0)
                    {
                        break;
                    }

                    if (currentNumber < min)
                    {
                        min = currentNumber;
                    }
                    if (currentNumber > max)
                    {
                        max = currentNumber;
                    }
                }
                else
                {
                    Console.WriteLine($"Ошибка преобразования: {num}");
                }
            }

            double result = (double)min / max;
            Console.WriteLine($"Отношение минимального и максимального элементов: {result}");
        }
        else
        {
            Console.WriteLine("Файл пуст или не содержит корректных данных.");
        }
    }
}