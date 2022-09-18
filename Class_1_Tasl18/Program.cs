using System;

namespace Class_1_Tasl18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма покупки");
            string price = Console.ReadLine();
            double price_1 = double.Parse(price);
            Console.WriteLine("Введите курс доллара");
            string dollar = Console.ReadLine();
            double dollar1 = double.Parse(dollar);
            Console.WriteLine("Введите комиссию банка");
            string komiss = Console.ReadLine();
            double commission = double.Parse(komiss);
            double sumdovicheta = price_1 * dollar1;
            double percent = sumdovicheta / 100;
            double percent_1 = percent * commission;
            double amount = sumdovicheta + percent_1;
            Console.WriteLine($"Общая сумма, еобходимая для совершения покупки = {amount}");
        }
    }
}
