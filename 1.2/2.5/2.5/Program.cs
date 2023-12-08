using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        int[,] temperature = new int[12, 30];

        
        Random random = new Random();
        for (int month = 0; month < 12; month++)
        {
            for (int day = 0; day < 30; day++)
            {
                temperature[month, day] = random.Next(-10, 30); // Генерируем значения от -10 до 30
            }
        }

        // Вычисляем и выводим среднюю температуру для каждого месяца
        Dictionary<string, List<int>> averageTemperatures = CalculateAverageTemperatures(temperature);

        // Сортируем словарь по возрастанию средних температур
        List<KeyValuePair<string, List<int>>> sortedTemperatures = new List<KeyValuePair<string, List<int>>>(averageTemperatures);
        sortedTemperatures.Sort((x, y) => GetAverageTemperature(x.Value).CompareTo(GetAverageTemperature(y.Value)));

        
        foreach (var month in sortedTemperatures)
        {
            Console.WriteLine($"{month.Key}: {GetAverageTemperature(month.Value)} °C");
        }
    }

    static Dictionary<string, List<int>> CalculateAverageTemperatures(int[,] temperature)
    {
        Dictionary<string, List<int>> averageTemperatures = new Dictionary<string, List<int>>();

        for (int month = 0; month < 12; month++)
        {
            List<int> monthTemperatures = new List<int>();

            for (int day = 0; day < 30; day++)
            {
                monthTemperatures.Add(temperature[month, day]);
            }

            averageTemperatures.Add(GetMonthName(month), monthTemperatures);
        }

        return averageTemperatures;
    }

    static int GetAverageTemperature(List<int> temperatures)
    {
        int sum = 0;
        foreach (var temperature in temperatures)
        {
            sum += temperature;
        }

        return (int)sum / temperatures.Count;
    }

    static string GetMonthName(int month)
    {
        return new DateTime(2022, month + 1, 1).ToString("MMMM");
    }
}
