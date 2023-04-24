// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;

int Num = new Random().Next(3,20);
int count = 1;

WriteLine(NaturalNumber(Num, count));

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}
