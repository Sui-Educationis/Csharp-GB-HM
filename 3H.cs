/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
using System;

class MainClass {
  public static void Main (string[] args) {
    int A = 3;
    int B = 5;
    int result = 1;

    for (int i = 0; i < B; i++) {
      result *= A;
    }

    Console.WriteLine(result);
  }
}

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
using System;

class MainClass {
  public static void Main (string[] args) {
    int num = 452;
    int sum = 0;

    foreach (char c in num.ToString()) {
      sum += int.Parse(c.ToString());
    }

    Console.WriteLine(sum);
  }
}

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
using System;

class MainClass {
  public static void Main (string[] args) {
    int[] arr = {1, 2, 5, 7, 19, 6, 1, 33};

    Console.Write("[");
    for (int i = 0; i < arr.Length; i++) {
      Console.Write(arr[i]);
      if (i != arr.Length - 1) {
        Console.Write(", ");
      }
    }
    Console.WriteLine("]");
  }
}
