// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
Console.Write($"The sum of the digits of a number {num} equals {SUM(num)}");

int SUM(int num)
{
    int num_a = num;
    int sum = 0;
    while (num_a > 0)
    {
        sum += num_a % 10;
        num_a /= 10;
    }
    return sum;
}


