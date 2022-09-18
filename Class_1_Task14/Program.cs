using System;

namespace Class_1_Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ширину прямоугольника");
            string x_0 = Console.ReadLine();
            double width = double.Parse(x_0);
            Console.WriteLine("Введите ширину прямоугольника");
            string x_1 = Console.ReadLine();
            double length = double.Parse(x_1);
            double perimeter = (width + length) * 2;
            double square = width * length;
            Console.WriteLine($"Р = {perimeter}, S = {square}");
        }
    }
}
