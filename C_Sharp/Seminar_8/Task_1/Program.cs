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