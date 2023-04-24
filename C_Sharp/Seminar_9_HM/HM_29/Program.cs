// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


using System;
using static System.Console;

int Num = new Random().Next(1, 3);
int Num2 = new Random().Next(1, 4);

WriteLine($"Function of Akkerman for number {Num} and {Num2} = {Akkerman(Num, Num2)}");

int Akkerman(int i, int n)
{
    if (i == 0)
        return n + 1;
    if (i > 0 && n == 0)
        return Akkerman(i - 1, 1);
    else
        return Akkerman(i - 1, Akkerman(i, n - 1));
}
