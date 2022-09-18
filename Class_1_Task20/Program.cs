using System;

namespace Class_1_Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");
            string symbol = Console.ReadLine();
            char symbol_1 = char.Parse(symbol);
            int symbol_2 = symbol_1 + 1;
            char symbol_3 = (char)symbol_2;
            Console.WriteLine("Следующий символ = " + symbol_3);
        }
    }
}
