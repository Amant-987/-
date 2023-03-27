/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.Write("Enter day's number of week: ");
int a = int.Parse(Console.ReadLine());

if ((a == 6) || (a == 7))
{
    Console.WriteLine("Yes");
}
else
{
    if ((a > 0) && (a < 6))
    {
        Console.WriteLine("No");
    }
    else
    {
        Console.WriteLine("Every week have 7 days! Started from 1 to 7   :) ");
    }
}