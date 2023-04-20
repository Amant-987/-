// Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.


using System;
using static System.Console;

Clear();

Write("Enter your number: ");
int number = int.Parse(ReadLine()!);
Write("Enter your pow: ");
int pow = int.Parse(ReadLine()!);
WriteLine($"{PowNumbers(number, pow)}");

// int sum = 0;
// while(a > 0){
//     sum += a % 10;
//     a /= 10;
// }

int PowNumbers(int number, int pow)
{
    if (pow == 0)
        return 1;
    return PowNumbers(number, --pow) * number;
}