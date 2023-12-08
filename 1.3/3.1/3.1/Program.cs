using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = @"C:\Users\Арина\input.txt";
        string outputFilePath = @"C:\Users\Арина\output.txt";

        if (File.Exists(inputFilePath))
        {
            try
            {
                string[] lines = File.ReadAllLines(inputFilePath);

                if (lines.Length >= 3)
                {
                    // Получение выбранных чисел
                    string[] selectedNumbersStr = lines[0].Split(' ');
                    int[] selectedNumbers = Array.ConvertAll(selectedNumbersStr, int.Parse);

                    // Получение количества лотерейных билетов
                    if (int.TryParse(lines[1], out int n))
                    {
                        // Создание потока для записи в файл
                        using (StreamWriter writer = new StreamWriter(outputFilePath))
                        {
                            // Проверка каждого лотерейного билета
                            for (int i = 2; i < Math.Min(n + 2, lines.Length); i++)
                            {
                                // Получение чисел на текущем билете
                                string[] ticketNumbersStr = lines[i].Split(' ');
                                int[] ticketNumbers = Array.ConvertAll(ticketNumbersStr, int.Parse);

                                // Подсчет количества совпадающих чисел
                                int count = 0;
                                foreach (int number in ticketNumbers)
                                {
                                    if (Array.Exists(selectedNumbers, x => x == number))
                                    {
                                        count++;
                                        if (count >= 3)
                                        {
                                            break;
                                        }
                                    }
                                }
                                // Вывод результата в файл Output.txt
                                if (count >= 3)
                                {
                                    writer.WriteLine("Lucky");
                                }
                                else
                                {
                                    writer.WriteLine("Unlucky");
                                }
                            }
                        }
                        Console.WriteLine("Готово! Результаты записаны в файл Output.txt.");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода количества лотерейных билетов.");
                    }
                }
                else
                {
                    Console.WriteLine("Файл содержит недостаточное количество строк.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Файл input.txt не найден.");
        }
    }
}
