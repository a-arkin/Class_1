using System;

namespace Class_1_Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");
            string symbol = Console.ReadLine();
            char symbol_0 = char.Parse (symbol);
            int symbol_1 = (int)symbol_0;
            Console.WriteLine($"Значение юникода введенного символа = {symbol_1}");
        }
    }
}
