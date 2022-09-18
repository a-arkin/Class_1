using System;

namespace Class_1_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние, пройденное Вами в метрах");
            string distance = Console.ReadLine();
            int distance_m = int.Parse(distance);
            int distance_km = distance_m / 1000;
            Console.WriteLine($"В километрах Вы прошли: {distance_km} км");
        }
    }
}
