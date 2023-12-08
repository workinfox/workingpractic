using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            
            string[] lines = File.ReadAllText(@"C:\Users\Арина\numTask2.txt").Split(';');
            float[] numbers = new float[lines.Length];

            // Преобразование строк в массив вещественных чисел
            for (int i = 0; i < lines.Length; i++)
            {
                numbers[i] = float.Parse(lines[i]);
            }

            // Сортировка чисел по возрастанию
            Array.Sort(numbers);

            // Преобразование массива обратно в строку с разделителем ;
            string sortedData = string.Join(";", numbers);

            
            File.WriteAllText(@"C:\Users\Арина\numTask2.txt", sortedData);

            Console.WriteLine("Числа были успешно отсортированы и записаны обратно в файл.");
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