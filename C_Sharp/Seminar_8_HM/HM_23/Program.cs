/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

using System;
using static System.Console;
Clear();

int row = new Random().Next(3, 8);
int column = row;
int[,] array = GetArray(row, column);
PrintArray(array);
WriteLine();
PrintSumRow(array);
FindMinSum(SumRow(array));

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray(int[,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            Write(tempArray[i, j] + "\t");
        }
        WriteLine();
    }
}
void PrintSumRow(int[,] tempArray)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        WriteLine($"Sum in row {i + 1} is: {sum}");
        sum = 0;
    }
}

int[] SumRow(int[,] tempArray)
{
    int[] sumrows = new int[tempArray.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumrows[i] = sum;
        sum = 0;
    }
    return sumrows;
}

void FindMinSum(int[] tempArray)
{
    int rowMinSum = 0;
    int minSum = tempArray[0];
    for (int i = 1; i < tempArray.Length; i++)
    {
        if (minSum > tempArray[i])
        {
            minSum = tempArray[i];
            rowMinSum = i;
        }
    }
    WriteLine();
    WriteLine($"Minimal Sum in row {rowMinSum+1} is {minSum}");
}
