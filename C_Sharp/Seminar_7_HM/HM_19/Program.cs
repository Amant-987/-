// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


using System;
using static System.Console;

Write("Enter number of rows array: ");
int rows = int.Parse(ReadLine()!);

Write("Enter number of columns array: ");
int columns = int.Parse(ReadLine()!);

double[,] array = GetArray(rows, columns);

PrintArray(array);

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            //result[i, j] = new Random().NextDouble() * 10;
            result[i, j] = Math.Round(new Random().Next(-30, 50) / 2.5, 2);
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Write("{0,7:F2}", array[i, j]); // {0,6:F2} - format numbers in writeline
            Write(array[i, j] + "\t"); // \t - tab. If the compiler encounters the sequence \t in the text, it will not see the sequence as a slash and the letter t, but as a tab - i.e. a long indent.
        }
        WriteLine();
    }
}