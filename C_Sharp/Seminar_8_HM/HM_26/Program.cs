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
        int[,] array3 = new int[new Random().Next(3,6),new Random().Next(4,7)];
        GetSpiral2(array2);
        SpiralArray(array3);
        WriteLine();
        WriteLine();
        PrintArray(array3);
        WriteLine();
        //PrintArray(array1);


        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Write($"{array[i, j]:00}"+"\t");
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


        //third try GetSpiralArray-------------->

        void SpiralArray(int[,] array)
        {
            var total = array.GetLength(0) * array.GetLength(1);
            var numb = 1;

            int X = 0;
            int Y = 0;

            int h = array.GetLength(0); //height
            int w = array.GetLength(1);  //weight

            while (total >= numb)
            {
                for (int i = 0; i < w; i++)
                    array[X, Y + i] = numb++;

                for (int i = 1; i < h; i++)
                    array[X + i, Y + w - 1] = numb++;

                for (int i = 1; i < w && numb <= total; i++)
                    array[X + h - 1, (Y + w - 1) - i] = numb++;

                for (int i = 1; i < h - 1 && numb <= total; i++)
                    array[(X + h - 1) - i, Y] = numb++;
                X++;
                Y++;
                h -= 2;
                w -= 2;
            }
        }
    }
}