using System;

class Program
{
    static void Main(string[] args)
    {
        // Объявление переменных
        int a, b;

        // Ввод первого числа
        Console.Write("Введите первое число (a): ");
        a = Convert.ToInt32(Console.ReadLine());

        // Ввод второго числа
        Console.Write("Введите второе число (b): ");
        b = Convert.ToInt32(Console.ReadLine());

        // Проверка на большее число и вывод результата
        if(a > b) {
            Console.WriteLine($"max = {a}, min = {b}");
        } else if(b > a) {
            Console.WriteLine($"max = {b}, min = {a}");
        } else {
            Console.WriteLine($"a = b = {a}");
        }
    }
}
