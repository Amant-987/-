// Напишите программу, которая на вход принимает 
//число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.Clear();
Console.Write("Enter number:");
int number = int.Parse(Console.Readline());
inr sqr = number * number;
Console.WriteLine($"Quader number {number} equivalent {sqr}");
int sqrl = Math.Pow(number, 2);