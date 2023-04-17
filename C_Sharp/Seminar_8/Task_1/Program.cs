/**Задача 53:**Задайте двумерный массив.
Напишите программу, которая поменяет местами 
первую и последнюю строку массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2*/

using System;
using static System.Console;

int a = new Random().Next(3, 7); //rows
int b = new Random().Next(4, 8); //columns
int[,] array = GetArray(a, b);
PrintArray(array);
ReverseRows(array);
WriteLine();
PrintArray(array);

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 20);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + "\t");
        }
        WriteLine();
    }
}

void ReverseRows(int[,] array)
{
    int row = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        var tmp = array[row, i];
        array[3, i] = array[0, i];
        array[0, i] = tmp;
    }
}


// Clear();
// Write("Введите количество строк массива: ");
// int rows = int.Parse(ReadLine());
// Write("Введите количество столбцов массива: ");
// int columns = int.Parse(ReadLine());

// int[,] array = GetArray(rows, columns, 10, 100);
// PrintArray(array);
// WriteLine();
// Write("Введите строку 1: ");
// int a1 = int.Parse(ReadLine());
// Write("Введите строку 2: ");
// int b1 = int.Parse(ReadLine());
// ChangeRows(array, a1, b1);
// PrintArray(array);


// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// void ChangeRows(int[,] inArray, int a, int b)
// {
//     for (int i = 0; i < inArray.GetLength(1); i++)
//     {
//         int k = inArray[a - 1, i];
//         inArray[a - 1, i] = inArray[b - 1, i];
//         inArray[b - 1, i] = k;
//     }
// }