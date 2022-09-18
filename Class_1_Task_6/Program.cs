using System;

namespace Class_1_Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние, пройденное Вами в километрах");
            string distance = Console.ReadLine();
            int distance_km = int.Parse(distance);
            int distance_m = distance_km * 1000;
            Console.WriteLine($"В метрах Вы прошли: {distance_m} м");
        }
    }
}
