/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
using System;

class MainClass {
  public static void Main (string[] args) {
    int[] arr = new int[8];
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++) {
      arr[i] = rand.Next(100, 1000);
    }

    int count = 0;
    foreach (int num in arr) {
      if (num % 2 == 0) {
        count++;
      }
    }

    Console.WriteLine("Массив: [" + string.Join(", ", arr) + "]");
    Console.WriteLine("Количество четных чисел: " + count);
  }
}


/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
using System;

class MainClass {
  public static void Main (string[] args) {
    int[] arr = new int[8];
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++) {
      arr[i] = rand.Next(100);
    }

    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2) {
      sum += arr[i];
    }

    Console.WriteLine("Массив: [" + string.Join(", ", arr) + "]");
    Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
  }
}

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */
using System;

class MainClass {
  public static void Main (string[] args) {
    double[] arr = {3.22, 4.2, 1.15, 77.15, 65.2};

    double max = arr[0];
    double min = arr[0];

    for (int i = 1; i < arr.Length; i++) {
      if (arr[i] > max) {
        max = arr[i];
      }
      if (arr[i] < min) {
        min = arr[i];
      }
    }

    double diff = max - min;

    Console.WriteLine("Массив: [" + string.Join(", ", arr) + "]");
    Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);
  }
}

