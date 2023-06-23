// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

using System;

class Program
{
    static void Main(string[] args)
    {
        // Объявление переменной
        int number;

        // Ввод  числа
        Console.Write("Введите  число: ");
        number = Convert.ToInt32(Console.ReadLine());
        
        if (number % 2 == 0)
        {
            Console.WriteLine($"Является четным числом = {number}");
        }
        else
        {
            Console.WriteLine($"Является нечетным числом = {number}");
        }
    
    }
}
