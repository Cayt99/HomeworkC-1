// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
using System;

class Program
{
    static void Main(string[] args)
    {
        // Объявление переменных
        int number1, number2;

        // Ввод первого числа
        Console.Write("Введите первое число: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        // Ввод второго числа
        Console.Write("Введите второе число: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        // Проверка на большее число и вывод результата
        if(number1 > number2) {
            Console.WriteLine($"max = {number1}, min = {number2}");
        } else if(number2 > number1) {
            Console.WriteLine($"max = {number2}, min = {number1}");
        } else {
            Console.WriteLine($"Первое число = {number1}");
            Console.WriteLine($"Второе число = {number1}");

        }
    }
}
