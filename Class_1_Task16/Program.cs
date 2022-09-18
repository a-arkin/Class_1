using System;

namespace Class_1_Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string x_0 = Console.ReadLine();
            int first_number = int.Parse(x_0);
            Console.WriteLine("Введите второе число");
            string x_1 = Console.ReadLine();
            int last_number = int.Parse(x_1);
            int intermediate = first_number;
            first_number = last_number;
            last_number = intermediate;
            Console.WriteLine($"Теперь первое число = {first_number}, а второе число = {last_number}");
        }
    }
}
