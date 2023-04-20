// Задача 63: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

using System;
using static System.Console;

Clear();
Write("Enter your first number: ");
int number1 = int.Parse(ReadLine()!);
Write("Enter your second number: ");
int number2 = int.Parse(ReadLine()!);
Write(WriteNow(number1, number2));

// void WriteNow(int number1, int number2)
// {
//     if (number1 <= number2)
//     {
//         Write(number1 + ", ");
//         number1++;
//         WriteNow(number1, number2);
//     }
// }

string WriteNow(int number1, int number2)
{
    if (number1==number2)
    {
        return number1.ToString();
    }
return number1+ ", "+WriteNow(++number1, number2);
}