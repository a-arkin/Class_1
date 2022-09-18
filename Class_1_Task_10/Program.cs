using System;

namespace Class_1_Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string x0 = Console.ReadLine();
            int x1 = int.Parse(x0);
            Console.WriteLine("Введите второе число");
            string x0_1 = Console.ReadLine();
            int x2 = int.Parse(x0_1);
            int addition = x1 + x2;
            int difference = x1 - x2;
            int multiplication = x1 * x2;
            int division = x1 / x2;
            Console.WriteLine($"{addition}, {difference}, {multiplication}, {division}.");
        }
    }
}
