using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\\Users\\Арина\\numsTask4.txt"); // Чтение всех строк из файла
        if (lines.Length > 0)
        {
            string[] nums = lines[0].Split(' '); // Разделение первой строки по символу ''
            int cout = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    cout++;
                }
            }
            Console.WriteLine($"Количество рядом стоящих чисел: {cout}");
        }
        else
        {
            Console.WriteLine("Файл пуст(");
        }
    }
}