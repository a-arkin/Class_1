using System;

namespace Class_1_Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру в градусах Цельсия");
            string temperature = Console.ReadLine();
            int temperature_С = int.Parse(temperature);
            int temperature_K = (temperature_С *9/5) + 32;
            Console.WriteLine($"Температура в Фаренгейтах = {temperature_K}");
        }
    }
}
