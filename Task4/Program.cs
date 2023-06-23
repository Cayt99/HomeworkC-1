// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using System;

class Program
{
    static void Main(string[] args)
    {
        // Объявление переменной
        int number;

        // Ввод числа
        Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Вывод всех чётных чисел от 1 до N
        if (number >= 0)
        {
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            for (int i = number; i <= -number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
