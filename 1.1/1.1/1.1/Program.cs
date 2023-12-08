using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random rand = new Random();

        
        int[] num = new int[10];
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = rand.Next();
        }

        
        int min = num[0];
        int minIndex = 0;
        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                minIndex = i;
            }
        }

        
        Console.WriteLine("Номер минимального элемента: " + minIndex);

        Console.ReadLine();
    }
}