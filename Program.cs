﻿// Задача 34: Массив и сколько в нем четных)

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
int[] mass = new int[10];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100, 1000);
}
Print(mass);
int count = 0;
for (int i = 0; i < mass.Length; i++)
    {
      if (mass[i] % 2 == 0)
      {
        count += 1;
      }
    }
Console.WriteLine("Количество четных чисел в массиве: " + count);
 */

// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
int[] mass = new int[4];
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-100, 100);
    }
}
Print(mass);
int sum = 0;
for (int i = 1; i < mass.Length; i += 2)
{
    sum = sum + mass[i];
}
Console.WriteLine("Сумма чисел, стоящих в массиве на нечетной позиции: " + sum); */

// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

/* void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
double[] mass = new double[5];
Random rand = new Random();
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = rand.Next(-10, 10) + rand.NextDouble();;
    }
}
Print(mass);
double min = mass[0];
double max = mass[0];
double difference = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > max)
    {
        max = mass[i];
    }
    if (mass[i] < min)
    {
        min = mass[i];
    }
}
difference = max - min;
Console.WriteLine($"Разница между между максимальным ({max}) и минимальным({min}) элементами: {difference}"); */