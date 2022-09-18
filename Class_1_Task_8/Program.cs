using System;

namespace Class_1_Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество потраченного времени в часах");
            string time = Console.ReadLine();
            int hour = int.Parse(time);
            int day = hour / 24;
            Console.WriteLine($"Всего потраченного времени в днях: {day} дня/дней");
        }
    }
}
