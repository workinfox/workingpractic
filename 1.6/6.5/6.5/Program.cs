using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console.ReadLine()); 
        Console.Write("Введите количество столбцов: ");
        int m = int.Parse(Console.ReadLine()); 
        
        int[,] a = new int[n, m];
        
        
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = random.Next(0, 2);
            }
        }
        
        int[,] updatedMatrix = new int[n, m + 1]; 

        // копирование исходной матрицы в новую матрицу
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                updatedMatrix[i, j] = a[i, j];
            }
        }

        // вычисление количества единиц в каждой строке и обновление новой матрицы
        for (int i = 0; i < n; i++)
        {
            int onesCount = 0;
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] == 1)
                {
                    onesCount++;
                }
            }
            // проверка на четность количества единиц
            if (onesCount % 2 != 0)
            {
                updatedMatrix[i, m] = 1; // если количество единиц нечетное, то добавляем единицу в новый столбец
            }
        }
        
        // вывод результирующей матрицы
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write(updatedMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}