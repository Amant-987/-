// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
int a = 0;
int num_a = num;
while (num_a > 0)
{
    a = a * 10 + num_a % 10;
    num_a /= 10;
}
if (num == a)
{
    Console.Write("This is a Palindrom!");
}
else
{
    Console.Write("This isn't a Palindrom!");
}

//Console.Write(a);
