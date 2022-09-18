using System;

namespace Class_1_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите наименование продукта");
            string name = Console.ReadLine();
            Console.WriteLine("Введите количество");
            string quantity = Console.ReadLine();
            int quantity1 = int.Parse(quantity);
            Console.WriteLine("Введите цену продукта");
            string price = Console.ReadLine();
            int price1 = int.Parse(price);
            Console.WriteLine($"Название: {name} Кол-во: {quantity1} Цена: {price1}");
        }
    }
}
