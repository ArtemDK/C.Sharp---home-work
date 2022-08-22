// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// ------------------------ с 1 Методом -------------------
Console.Clear();
int[] Array(int n, int min, int max) 
{
    Console.Write("[");
    int[] a = new int[n];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(min, max);
        if (i < a.Length - 1) Console.Write(a[i] + ",");
        else Console.Write(a[i]);
    }
    Console.Write("]");
    return a;
}
Array(8,0,100);

// ------------------------ с 2 Методами -------------------

// int[] Arraycreate(int n, int min, int max)
// {
//     int[] array = new int[n];
//     {
//         for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max);
//     }
//     return array;
// }
// void ArrayPrint(int[] array)
// {
//     Console.Write("[");
//     {
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (i != array.Length- 1) Console.Write(array[i] + ",");
//             else Console.Write(array[i]);
//         }
//     }
//     Console.Write("]");
// }
// int[] rez = Arraycreate(8, 0, 100);
// ArrayPrint(rez);