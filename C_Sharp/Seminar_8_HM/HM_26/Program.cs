/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

using System;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        int row_col = /*4;*/ new Random().Next(3, 10);

        int[,] array = GetSpiralArray(row_col);
        int[,] array2 = new int[row_col, row_col];
        GetSpiral2(array2);
        WriteLine();
        WriteLine();
        PrintArray(array2);
        WriteLine();
        //PrintArray(array1);


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


        //first try GetSpiralArray------ONLY QUADRATISH---------->
        int[,] GetSpiralArray(int size) //a = result of row == result of column
        {
            int[,] result = new int[size, size];
            int i = 0;
            int j = 0;
            int temp = 1; //first number for massive
            while (size != 0)
            {
                int k = 0;
                do
                {
                    result[i, j++] = temp++; //insrease number for every column in that row
                } while (++k < size - 1); //while prefix k < then length-1
                for (k = 0; k < size - 1; k++)
                {
                    result[i++, j] = temp++;
                    //insrease number for every row in that column
                }
                for (k = 0; k < size - 1; k++)
                {
                    result[i, j--] = temp++;
                    //decrease number for every column(postfix - reverse course) in that row
                }
                for (k = 0; k < size - 1; k++)
                {
                    result[i--, j] = temp++;
                    //decrease number for every row(postfix - reverse course) in that column
                }

                ++i; //++ as prefix - new round
                ++j;
                if (size < 2)
                {
                    size = 0;
                }
                else
                {
                    size -= 2;
                }
            }
            return result;
        }

        //second try GetSpiralArray------ONLY QUADRATISH---------->
        int[,] GetSpiral2(int[,] result)
        {
            int temp = 1;
            int i = 0;
            int j = 0;
            while (temp <= result.GetLength(0) * result.GetLength(1))
            {
                result[i, j] = temp;
                temp++;
                if (i <= j + 1 && i + j < result.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= result.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > result.GetLength(1) - 1)
                    j--;
                else
                    i--;
            }
            return result;
        }


        //third try GetSpiralArray------ONLY QUADRATISH---------->
        
        



        
    }
}