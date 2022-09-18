using System;

namespace Class_1_Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму в рублях");
            string rub = Console.ReadLine();
            double rubli = double.Parse(rub);
            Console.WriteLine("Введите курс доллара");
            string dollar = Console.ReadLine();
            double dollar1 = double.Parse(dollar);
            Console.WriteLine("Введите комиссию банка");
            string komiss = Console.ReadLine();
            double commission = double.Parse(komiss);
            double procent = rubli / 100;
            double commission_1 = procent * commission;
            double amount = (rubli - commission_1) / dollar1;
            Console.WriteLine($"Общая сумма в долларах {amount}");
        }
    }
}
