// // Напишите программу, которая принимает 
// 1.на вход пятизначное число 
// 2.и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да
Console.Clear();
Console.Write("Введите пятизначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
int num2 = num;
int a = num / 10000;
for (int i = 0; i < 4; i++)
{
    num1 = num1 / 10;
}
for (int i = 0; i < 3; i++)
{
    num2 = num2 / 10;
}
num2 = num2 % 10;
int num5 = num % 10;
int num4 = num % 100;
num4 = num4 / 10;
if (num1 == num5 && num2 == num4) Console.WriteLine("Число полиандром");
else if (a == 0 || a > 10) Console.WriteLine("Число не пятизначное");
else Console.WriteLine("Число не полиандром");