﻿// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
Console.WriteLine("Введите количество эементов Массива: ");
int qty = Convert.ToInt32(Console.ReadLine());
if (qty <= 0)
{
    Console.WriteLine("Количество элементов должно быть больше нуля");
    return;
}
double[] create = CreateArray(qty, 0, 100);
Print(create);
Console.Write(" -> ");
double rez = MinMax(create);
Console.WriteLine(rez);

double[] CreateArray(int size, int min, int max)
{
    if (size == 0)
        return new double[] { };

    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
    }
    return array;
}
void Print(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}
double MinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double rezult = max - min;
    return rezult;
}
