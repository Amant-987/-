// Задача 67: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


using System;
using static System.Console;

Clear();

Write("Enter your number: ");
int a = int.Parse(ReadLine());
Write(SumNumbers(a));

// int sum = 0;
// while(a > 0){
//     sum += a % 10;
//     a /= 10;
// }

int SumNumbers(int number)
{
    if (number == 0)
        return 0;
    return (number % 10 + SumNumbers(number / 10));
}