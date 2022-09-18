using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Вашу фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите Ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Ваше пол");
            string gender = Console.ReadLine();
            Console.WriteLine($"Имя: {surname} {name}, Пол: {gender}");
        }
    }
}
