// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
using System;

class Program
{
    static void Main(string[] args)
    {
        // Объявление переменных
        int number1, number2, number3;

        // Ввод первого числа
        Console.Write("Введите первое число: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        // Ввод второго числа
        Console.Write("Введите второе число: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        // ВВод третьего числа
        Console.Write("Введите третье число: ");
        number3 = Convert.ToInt32(Console.ReadLine());

        // Проверка на большее число и вывод результата

        if (number1 >= number2 && number1 >= number3)
        {
            Console.WriteLine($"Первое число max = {number1}");
        }
        else if (number2 >= number1 && number2 >= number3)
        {
            Console.WriteLine($"Второе число max = {number2}");
        }
        else if (number3 >= number1 && number3 >= number2)
        {
            Console.WriteLine($" Третье число max = {number3}");
        }
       else if (number1 == number2 && number2 == number3)
       {
            Console.WriteLine($"Все числа равны:");
            Console.WriteLine($"Первое число: {number1}");
            Console.WriteLine($"Второе число: {number1}");
            Console.WriteLine($"Третье число: {number1}");
            
       }
    }
}
