using System;

namespace TwoDimensionalMassiveByRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите m: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Заполнение массива:");
            int[,] mas = new int[n, m];

            Random r = new Random(); // объявление переменной для генерации случайных чисел

            for (int i = 0; i < n; ++i) // массив заполняется случайными числами 
            {       for (int j = 0; j < m; j++)
                {            mas[i, j] = r.Next(10); // от 0 до 9       
                }
            }

            Console.WriteLine("Полученный массив:");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
