/*
Напишите программу, которая выводит третью цифру заданного числа
или сообщает что третьей цифры нет.
645 -> 5
78 -> didn't have third-digit
32679 -> 6
*/
Console.Clear();
Console.Write("Enter number: ");
int a = int.Parse(Console.ReadLine());
 if (a < 100)
 {
    Console.Write("Didn't have third digit!");
 }
 else
 { while (a > 999)
   {
   a /= 10;
   }
   Console.Write($"{a % 10}");
 }