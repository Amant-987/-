﻿//11 Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98 -->

int num = new Random().Next(100, 999);
int a = num / 100;
int b = num % 10;
int c = a*10+b;
Console.WriteLine($"{num} -> {c}");