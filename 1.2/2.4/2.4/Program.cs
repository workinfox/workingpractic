using System;

class Program
{
    static void Main()
    {
        int[,] temperatures = CreateRandomTemperatures();
        int[] averageTemperatures = CalculateAverageTemperatures(temperatures);

        string[] monthNames = {
            "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", 
            "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
        };

        Array.Sort(averageTemperatures, monthNames);

        Console.WriteLine("Средние температуры для каждого месяца (отсортированные по возрастанию с комментариями о сезонности):");
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"{monthNames[i]}: {averageTemperatures[i]} °C");
        }
    }

    static int[,] CreateRandomTemperatures()
    {
        Random random = new Random();
        int[,] temperatures = new int[12, 30];

        for (int month = 0; month < 12; month++)
        {
            for (int day = 0; day < 30; day++)
            {
                temperatures[month, day] = random.Next(-20, 35);
            }
        }

        return temperatures;
    }

    static int[] CalculateAverageTemperatures(int[,] temps)
    {
        int[] averageTemps = new int[12];

        for (int month = 0; month < 12; month++)
        {
            int totalTemperature = 0;
            for (int day = 0; day < 30; day++)
            {
                totalTemperature += temps[month, day];
            }
            averageTemps[month] = totalTemperature / 30;
        }

        return averageTemps;
    }
}