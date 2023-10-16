/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        PrintNumbers(N);
    }

    static void PrintNumbers(int N)
    {
        if (N > 1)
        {
            Console.Write(N + ", ");
            PrintNumbers(N - 1);
        }
        else if (N == 1)
        {
            Console.Write(N);
        }
    }
}


/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        PrintNumbers(M, N);
    }

    static void PrintNumbers(int M, int N)
    {
        if (M < N)
        {
            Console.Write(M + ", ");
            PrintNumbers(M + 1, N);
        }
        else if (M == N)
        {
            Console.Write(M);
        }
    }
}

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("A(m,n) = " + Ackermann(m, n));
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
        else
        {
            return 0; // необходимость для компиляции кода.
        }
    }
}

