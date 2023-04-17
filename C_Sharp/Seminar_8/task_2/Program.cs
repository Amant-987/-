// **Задача 55:**Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

using System;
using static System.Console;

WriteLine("Введите число rows:");
int m = Convert.ToInt32(ReadLine());
WriteLine("Введите число columns:");
int n = Convert.ToInt32(ReadLine());
int[,] array = new int[m, n];
GetArray(array);
printArray(array);

int[,] revArray = new int[n, m];

for (int i = 0; i < revArray.GetLength(0); i++)
{
    for (int j = 0; j < revArray.GetLength(1); j++)
    {
        revArray[i, j] = array[j, i];
    }
}
WriteLine();
printArray(revArray);


void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }

    }
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + "\t");
        }
        WriteLine();
    }
    WriteLine();
}
