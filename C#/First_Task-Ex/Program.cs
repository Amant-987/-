﻿/*1.Напишите программу, которая на вход принимает два числа и проверяет,
 является ли первое число квадратом второго.

a = 25; b = 5->да
a = 2 b = 10->нет
a = 9; b = -3->да
a = -3 b = 9->нет*/

Console.Clear();
Console.Write("Enter number:");
int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());
int C = numB * numB;

if (
    numA == C)

{
    Console.Write("Yes");

}
else
{
    Console.Write("No");
}