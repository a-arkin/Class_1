using System;

namespace Class_1_Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату верхней левой точки по оси Х");
            string x_2 = Console.ReadLine();
            int X_2 = int.Parse(x_2);
            Console.WriteLine("Введите координату верхней левой точки по оси Y");
            string y_2 = Console.ReadLine();
            int Y_2 = int.Parse(y_2);
            Console.WriteLine("Введите координату нижней правой точки по оси Х");
            string x_4 = Console.ReadLine();
            int X_4 = int.Parse(x_4);
            Console.WriteLine("Введите координату нижней правой точки по оси Y");
            string y_4 = Console.ReadLine();
            int Y_4 = int.Parse(y_4);
            int x1 = X_2;
            int y1 = Y_4;
            int x3 = X_4;
            int y3 = Y_2;
            Console.WriteLine($"Координаты нижней левой точки x={x1}; y={y1}");
            Console.WriteLine($"Координаты верхней правой точки x={x3}; y={y3}");
        }
    }
}
