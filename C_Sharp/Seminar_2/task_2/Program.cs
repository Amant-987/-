// //*12 Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно числу первому,
// то программа выводит остаток от деления.

// // 34, 5 -> не кратно, остаток 4
// // 16, 4  -> кратно

Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());
if (a % b == 0)
{
    Console.WriteLine("Result - ok");
}
else
{
    Console.WriteLine($"NOK, c={a%b}");
    }