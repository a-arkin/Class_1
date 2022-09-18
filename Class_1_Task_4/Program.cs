using System;

namespace Class_1_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Вашу фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите Ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Ваше отчество");
            string Middle_name = Console.ReadLine();
            Console.WriteLine("Привет, " + surname + " " + name + " " + Middle_name + "!");
        }
    }
}
