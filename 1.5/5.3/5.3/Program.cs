using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            
            string[] lines = File.ReadAllText(@"C:\Users\Арина\numTask3.txt").Split(' ');

            
            int[] numbers = Array.ConvertAll(lines, int.Parse);

            // Поиск минимального числа и его индекса
            int minIndex = Array.IndexOf(numbers, numbers.Min());

            // Если минимальное число находится в начале массива, среднее не вычисляется
            if (minIndex == 0)
            {
                Console.WriteLine("Перед минимальным числом нет элементов");
            }
            else
            {
                // Вычисление среднего арифметического элементов до минимального числа
                double average = numbers.Take(minIndex).Average();
                Console.WriteLine($"Среднее арифметическое элементов до минимального: {average}");
            }
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