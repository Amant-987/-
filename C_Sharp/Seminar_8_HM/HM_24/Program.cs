/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


using System;
using static System.Console;
Clear();

int row1 = new Random().Next(2, 4);
int column1 = new Random().Next(2, 4);
int row2 = new Random().Next(2, 4);
int column2 = new Random().Next(2, 4);
int[,] array1 = GetArray(row1, column1);
int[,] array2 = GetArray(row2, column2);
int[,] resultArray = new int[row1, column2];
WriteLine("Second array: ");
PrintArray(array1);
WriteLine();
WriteLine("First array: ");
PrintArray(array2);
WriteLine();

if (array1.GetLength(1) != array2.GetLength(0))
{
    WriteLine("These arrays cannot be multiplied!");
    return;
}
else
{
    WriteLine("Result of multiplied array: ");
    MultiplyArrays(array1,array2,resultArray);
    PrintArray(resultArray);
}


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

void MultiplyArrays(int[,] array1, int[,] array2, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum+= array1[i,k] * array2[k,j];
            }
        resultArray[i,j] = sum;
        }
    }
}