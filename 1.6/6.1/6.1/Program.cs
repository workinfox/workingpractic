using System;
using System.IO;

class Program
{
    static void Main()
    {
        
        string filePath = @"C:\Users\Арина\nuTask1.txt";

        
        string fileContent = File.ReadAllText(filePath);
        string[] words = fileContent.Split();

        Console.WriteLine("Слова нечетной длины:");

        
        foreach (string word in words)
        {
            if (word.Length % 2 != 0)
            {
                Console.WriteLine(word);
            }
        }
    }
}