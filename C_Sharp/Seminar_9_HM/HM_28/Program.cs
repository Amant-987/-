// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

int Num = new Random().Next(1, 20);
int Num2 = new Random().Next(1, 20);

WriteLine($"Sum number from {Num} to {Num2} = {SumNumber(Num, Num2)}");

int SumNumber(int i, int j)
{
    if (i == j)
        return j;
    return j + SumNumber(i, j - 1);
}
