// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int seconddigit = num / 10;
int seconddigit1 = seconddigit % 10;
Console.WriteLine($"Второй цифрой числа {num} является {seconddigit1} ");