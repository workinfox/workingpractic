using System;


namespace Listwithrandomnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фразу: ");
            string a = Console.ReadLine();

            string[] words = a.Split(new char[] {' ', ','});
            Console.WriteLine("Количество слов в строке: " + words.Length);
            string n = "Start " + a + " End";
            Console.WriteLine(n);
        }
    }
}