using System;

namespace Class_1_Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ширину");
            string width = Console.ReadLine();
            double width_1 = double.Parse(width);
            Console.WriteLine("Введите высота");
            string height = Console.ReadLine();
            double height_1 = double.Parse(height);
            Console.WriteLine("Введите ширину");
            string length = Console.ReadLine();
            double length_1 = double.Parse(length);
            double volume = width_1 * height_1 * length_1;
            Console.WriteLine($"Объем параллелепипеда = {volume}");
        }
    }
}
