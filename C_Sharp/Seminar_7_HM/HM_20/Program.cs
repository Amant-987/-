// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;
WriteLine("Enter number to find: ");
int findN = int.Parse(ReadLine()!);

int a = new Random().Next(3, 7); //rows
int b = new Random().Next(4, 8); //columns
int[,] array = GetArray(a, b);
array[2, 2] = 17;
PrintArray(array);
FindNum(array,findN);

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(-20, 20);
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

void FindNum(int[,] array, int findN)
{
    a = 0;
    b = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == findN)
            {
                result = 1;
                a = i;
                b = j;
            }
        }
    }
    if (result == 1) WriteLine($"Yes, position is: {a + 1} row, {b + 1} column.");
    else WriteLine("Massive don't have yours number.");
}