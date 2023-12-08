using System;
using System.Collections.Generic;

namespace Addstring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elem = new List<string>();
            string a;

            do
            {
                Console.WriteLine("Введите элементы (нажмите enter для того, чтобы закончить): ");
                a = Console.ReadLine();

                if (!string.IsNullOrEmpty(a))
                {
                    elem.Add(a);
                }
            } while (!string.IsNullOrEmpty(a));

            if (elem.Count > 0)
            {
                string shortest = elem[0];
                string longest = elem[0];

                foreach (string element in elem)
                {
                    if (element.Length < shortest.Length)
                    {
                        shortest = element;
                    }

                    if (element.Length > longest.Length)
                    {
                        longest = element;
                    }
                }
                Console.WriteLine("Самый короткий элемент: " + shortest);
                Console.WriteLine("Самый длинный элемент: " + longest);
            }
            else
            {
                Console.WriteLine("Список пуст!");
            }
        }
    }
}