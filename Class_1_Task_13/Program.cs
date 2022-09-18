using System;

namespace Class_1_Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число");
            string x = Console.ReadLine();
            int number = int.Parse(x);
            int last_number = number % 10;
            int number1 = number / 10;
            int first_number = number1 % 10;
            Console.WriteLine($"Первая цифра числа - {first_number}, вторая цифра числа - {last_number}");

        }
    }
}
