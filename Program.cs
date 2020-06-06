using System;

namespace Csharpcourse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три длинны трёх сторон треугольника: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вычисляем площадь по формуле Герона...");
            int S;
            float p = a + b + c;
            double P = p / 2;
            Console.WriteLine("Полупериметр равен: " + P);
            Console.ReadKey();
            S = Convert.ToInt32(P * (P - a) * (P - b) * (P - c));
            Console.WriteLine(S);
            Console.WriteLine("Площать треугольника примерно равна: " + Math.Sqrt(S)); 
        }
    }
}
