using System;

namespace Class_1_Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            string R = Console.ReadLine();
            double radius = double.Parse(R);
            double square = Math.PI * radius * radius;
            Console.WriteLine($"S = {square}");
        }
    }
}
