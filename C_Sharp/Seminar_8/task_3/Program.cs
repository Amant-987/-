// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент 
// входных данных.

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6 

// 1встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


using System;
using static System.Console;

int a = new Random().Next(3, 7); //rows
int b = new Random().Next(4, 8); //columns
int[,] array = GetArray(a, b);
PrintArray(array);
WriteLine();
BubbleSort(array);
PrintArray(array);
PrintCount(array);


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

void PrintCount(int[,] array)
{
    int count = 0;
    for (int k = 0; k < 10; k++)
    {
        count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == k)
                {
                    count++;
                }
            }
        }
        if (count > 0)
        {
            Console.WriteLine($"Count for number {k} = {count}");
        }
    }
}

void BubbleSort(int[,] inArray)
{
    int[,] temp = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
        for (int j = 0; j < inArray.GetLength(1) - i - 1; j++)
        {
            if (inArray[i, j] > inArray[i, j + 1])
            {
                temp[i, j] = inArray[i, j];
                inArray[i, j] = inArray[i, j + 1];
                inArray[i, j + 1] = temp[i, j];
            }
        }
}



// //Задайте двумерный массив. Напишите программу, 
// //которая поменяет местами первую и последнюю строку массива.
// using System;
// using static System.Console;

// Clear();

// Write("Введите количество строк массива: ");
// int rows = int.Parse(ReadLine());
// Write("Введите количество столбцов массива: ");
// int columns = int.Parse(ReadLine());
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// WriteLine();
// int[] rowAr = GetRowArray(array);
// SortArray(rowAr);
// WriteLine(String.Join(" ", rowAr));
// PrintData(rowAr);

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// int[] GetRowArray(int[,] inArray)
// {
//     int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
//     int index = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             result[index] = inArray[i, j];
//             index++;
//         }
//     }
//     return result;
// }

// void SortArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         for (int j = i + 1; j < inArray.Length; j++)
//         {
//             if (inArray[i] > inArray[j])
//             {
//                 int k = inArray[i];
//                 inArray[i] = inArray[j];
//                 inArray[j] = k;
//             }
//         }
//     }
// }


// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// void PrintData(int[] inArray)
// {
//     int el = inArray[0];
//     int count = 1;
//     for (int i = 1; i < inArray.Length; i++)
//     {
//         if (inArray[i] != el)
//         {
//             WriteLine($"{el} встречается {count}");
//             el = inArray[i];
//             count = 1;
//         }
//         else
//         {
//             count++;
//         }
//     }
//     WriteLine($"{el} встречается {count}");
// }