﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Enter number: ");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0) {
    Console.Write("Even Number");
}
else {
    Console.Write("Odd number");
}