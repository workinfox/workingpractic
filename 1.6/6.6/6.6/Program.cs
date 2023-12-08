using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        
        
        int arrayLength = random.Next(1, 20);
        
        // Создаем исходный массив случайных дробных чисел
        float[] originalArray = new float[arrayLength];
        
        for (int i = 0; i < arrayLength; i++)
        {
            // Генерируем случайное дробное число от -10 до 10
            originalArray[i] = (float)(random.NextDouble() * 20 - 10);
        }
        
        // Создаем два новых массива для положительных и отрицательных элементов
        float[] positiveArray = Array.FindAll(originalArray, element => element > 0);
        float[] negativeArray = Array.FindAll(originalArray, element => element < 0);
        
        // Выводим исходный и новые массивы на экран
        Console.WriteLine("Исходный массив дробных чисел: ");
        PrintArray(originalArray);
        
        Console.WriteLine("\nМассив положительных чисел: ");
        PrintArray(positiveArray);
        
        Console.WriteLine("\nМассив отрицательных чисел: ");
        PrintArray(negativeArray);
    }
    
    // Метод для вывода массива на экран
    static void PrintArray(float[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
    }
}