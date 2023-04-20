/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

using System;
using static System.Console;

int row_col = /*4;*/ new Random().Next(3,10);
int[,] array = GetSpiralArray(row_col);
int[,] array2 = new int [row_col,row_col];
//Spiral(array2);
WriteLine();
PrintArray(array);



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j]+"\t");
        }
        WriteLine();
    }
}

//Переименую)
//first try GetSpiralArray---------------->
int[,] GetSpiralArray(int a) //a = numbers of row == numbers of column
{
    int[,] result = new int[a, a];
    int i = 0;
    int j = 0;
    int temp = 1; //first number for massive
    while (a != 0) //a=size   Rename it
    {
        int k = 0;
        do
        {
            result[i, j++] = temp++; //insrease number for every column in that row
        } while (++k < a - 1); //while prefix k < then length-1
        for (k = 0; k < a - 1; k++)
        {
            result[i++, j] = temp++;
            //insrease number for every row in that column
        }
        for (k = 0; k < a - 1; k++)
        {
            result[i, j--] = temp++;
            //decrease number for every column(postfix - reverse course) in that row
        }
        for (k = 0; k < a - 1; k++)
        {
            result[i--, j] = temp++;
            //decrease number for every row(postfix - reverse course) in that column
        }

        ++i; //++ as prefix - new round
        ++j;
        if (a < 2)
        {
            a = 0;
        }
        else
        {
            a -= 2;
        }
    }
    return result;
}

//second try GetSpiralArray цшер кусгкышщт---------------->
//Пока нет мыслей для второго варианта - сегодня сяду делать)  - у меня нет.     Я хочу через рекурсию придумать решение