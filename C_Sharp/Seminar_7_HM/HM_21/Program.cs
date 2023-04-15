// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;

int[,] array = GetArray(4, 3, 0, 10);
PrintArray(array);

int[,] GetArray(int rows, int columns, int minVal, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minVal, maxValue);
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
            Write("{0,3}", array[i, j]);  //{0,3} means it should render the 0th (i.e. the first) format-argument and right-align it with spaces so it's a minimum of 3 characters wide.    
        }
        WriteLine();
    }

}


double avg = 0;
int count = 0;
for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avg += array[i, j];
        count++;
    }
    avg /= count;
    WriteLine($"Average of columns {j + 1} is: {avg}");
    avg = 0;
    count = 0;
}
