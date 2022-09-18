using System;

namespace Class_1_Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество потраченного времени в днях");
            string time0 = Console.ReadLine();
            int day = int.Parse(time0);
            Console.WriteLine("Введите количество потраченного времени в часах");
            string time1 = Console.ReadLine();
            int hour = int.Parse(time1);
            Console.WriteLine("Введите количество потраченного времени в минутах");
            string time2 = Console.ReadLine();
            int minute = int.Parse(time2);
            int sum_minutes = (day * 1440) + (hour * 60) + minute;
            Console.WriteLine(sum_minutes);
        }
    }
}
