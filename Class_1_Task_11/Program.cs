using System;

namespace Class_1_Task_11
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
            Console.WriteLine("Введите третье число");
            string x0_2 = Console.ReadLine();
            int x3 = int.Parse(x0_2);
            int addition = x1 + x2 + x3;
            Console.WriteLine(addition);
        }
    }
}
