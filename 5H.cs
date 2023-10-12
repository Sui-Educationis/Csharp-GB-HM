/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int count = 0;
        foreach (string number in numbers)
        {
            if (Int32.Parse(number) > 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество положительных чисел: {count}");
    }
}

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

using System;

class Program
{
    static void Main()
    {
        double b1 = 2, k1 = 5, b2 = 4, k2 = 9;
        double x, y;

        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны, пересечения нет");
        }
        else
        {
            x = (b2 - b1) / (k1 - k2);
            y = k1 * x + b1;
            Console.WriteLine($"Точка пересечения: ({x}; {y})");
        }
    }
}
