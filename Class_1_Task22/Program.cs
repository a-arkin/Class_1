using System;

namespace Class_1_Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите код символа");
            string symbol = Console.ReadLine();
            int symbol_0 = int.Parse(symbol);
            char symbol_1 = (char)symbol_0;
            Console.WriteLine($"Символ введенного юникода = {symbol_1}");
        }
    }
}
