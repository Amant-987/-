/*Задача 60. ...Сформируйте трёхмерный массив 
из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

using System;
using static System.Console;
int x = 2; //new Random().Next(2, 5);
int y = 2; //new Random().Next(2, 5);
int z = 2; //new Random().Next(2, 5);

int[,,] array = new int[x,y,z];
GetArray(array);
PrintArray(array);

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Write($"{array[i, j, k]}({i}, {j}, {k})" + "\t");
            }
            WriteLine();
        }
    }
}


void GetArray(int[,,] resultArray)
{
  int[] temp = new int[resultArray.GetLength(0) * resultArray.GetLength(1) * resultArray.GetLength(2)];
  int  a;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 99);
    a = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 99);
          j = 0;
          a = temp[i];
        }
          a = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < resultArray.GetLength(0); x++)
  {
    for (int y = 0; y < resultArray.GetLength(1); y++)
    {
      for (int z = 0; z < resultArray.GetLength(2); z++)
      {
        resultArray[x, y, z] = temp[count];
        count++;
      }
    }
  }
}