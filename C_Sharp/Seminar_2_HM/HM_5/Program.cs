/* Напишите программы, которая принимает на ввод трехзначное число 
и на выходе показывает только вторую цифру этого числа
456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();
Console.Write("Enter a three-digit number: ");
int num = int.Parse(Console.ReadLine());
int a = (num % 100) / 10;
Console.WriteLine($"{num} -> {a}");