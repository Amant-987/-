/*Задача 59: Из двумерного массива целых чисел удалить строку и столбец,
 на пересечении которых расположен наименьший элемент.*/


using System;
using static System.Console;

int a = new Random().Next(3, 7); //rows
int b = new Random().Next(4, 8); //columns
int[,] array = Getarray(a, b);
Printarray(array);
WriteLine();
GetRowColumn(array);
Printarray(array);

int[,] Getarray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            //result[i, j] = new Random().Nextint() * 10;
            result[i, j] = new Random().Next(1, 50);
        }
    }
    return result;
}

void Printarray(int[,] array)
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
int[] GetRowColumn(int[,] oldArray)
{
    int[] result = new int[2];
    int min = oldArray[0, 0];
    for (int i = 0; i < oldArray.GetLength(0); i++)
    {
        for (int j = 0; j < oldArray.GetLength(1); j++)
        {
            if (oldArray[i, j] < min)
            {
                result[0] = i;
                result[1] = j;
                min = oldArray[i, j];
                WriteLine(String.Join(" , ", result));
            }

        }
    }
    return result;
}