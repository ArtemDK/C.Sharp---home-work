// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine ("Массив уникальных значений от 10 до 99:");
int[] mainarray = Mainarray();
Console.WriteLine ("Вывод индексов значений массива:");
int[,,] matrix1 = CreateArray(mainarray, 2, 2, 2);
int[] Mainarray()
{
    Random rnd = new Random();
    int[] a = new int[100];
    a[0] = rnd.Next(10, 100);
    for (int i = 1; i < 90;)
    {
        int num = rnd.Next(10, 100);
        int j;
        for (j = 0; j < i; j++)
        {
            if (num == a[j])
                break;
        }
        if (j == i)
        {
            a[i] = num;
            i++;
        }
    }
    for (int i = 0; i < 90; i++)
    {
        Console.Write("{0,2} ", a[i]);
        if (i % 10 == 9)
            Console.WriteLine();
    }
    return a;

}
int[,,] CreateArray(int[] main,int i1, int j1, int r1)
{
    // Random rnd = new Random();
    int q=0;
    int[,,] array = new int[i1, j1, r1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int r = 0; r < array.GetLength(2); r++)
            {
                array[i, j, r] = main[q];
                Console.WriteLine($"{array[i, j, r]}({i},{j},{r})");
                q++;
            }
        }
    }
    return array;
}