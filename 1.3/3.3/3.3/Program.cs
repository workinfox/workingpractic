using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\Арина\numbers.txt");

        string[] heightsStr = lines[0].Split(' ');
        int[] heights = new int[heightsStr.Length];

        for (int i = 0; i < heightsStr.Length; i++)
        {
            heights[i] = int.Parse(heightsStr[i]);
        }

        int maxArea = 0;
        int left = 0;
        int right = heights.Length - 1;

        while (left < right)
        {
            int currentArea = (right - left) * Math.Min(heights[left], heights[right]); // поменял знак умножения
            maxArea = Math.Max(maxArea, currentArea);

            if (heights[left] < heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        Console.WriteLine("Наибольшее количество воды, которое может вместить контейнер: " + maxArea);
    }
}