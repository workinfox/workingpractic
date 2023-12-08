using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        try
        {
            
            string[] words = File.ReadAllLines(@"C:\Users\Арина\nuTask2.txt");

            // Составление одной длинной строки (разделение каждого слова пробелом)
            StringBuilder result = new StringBuilder();
            foreach (string word in words)
            {
                result.Append(word);
                result.Append(" ");
            }

            string concatenatedWords = result.ToString().Trim();

            Console.WriteLine("Результат: " + concatenatedWords);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не найден");
        }
        catch (Exception e)
        {
            Console.WriteLine("Произошла ошибка: " + e.Message);
        }
    }
}