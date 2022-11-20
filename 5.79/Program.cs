using System;

namespace _5._79
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите значение y: ");
            int b = Int32.Parse(Console.ReadLine());
            int c = 0;
            for (int i = 0; i < b; i++)
            {
                c += a;
            }
            Console.WriteLine($"Результат умножения через функцию: {c}");

            int v = u(a, b);
            Console.WriteLine($"Результат умножения через рекурсию: {v}");
        }

        static int u(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }
            else
            {
                return x + u(x, y - 1);
            }
        }
    }
}
