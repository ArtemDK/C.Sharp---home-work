﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 1 || num > 7)
            Console.Write($"для числа {num} нет дня недели");
            else if (num > 0 && num < 6) Console.Write($"{num} день недели - не выходной");
            else Console.Write($"{num} день недели - выходной");