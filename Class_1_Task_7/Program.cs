using System;

namespace Class_1_Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество потраченного времени в минутах");
            string time_m = Console.ReadLine();
            int minutes = int.Parse(time_m);
            int hour = minutes / 60;
            Console.WriteLine($"В часах вы потратили {hour} час(ов)");
        }
    }
}
