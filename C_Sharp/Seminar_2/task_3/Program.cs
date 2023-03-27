// Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.
//if((a > b || a < c) && (x > b || x < c) || d == 5) &&
//     0    +    0          1    +   0
 //         0          *          1
 //                    0                   +   1
 //                                1    
// 14  ->  нет
// 46  ->  нет
// 161 ->  да

Console.Write("Enter number: ");
int a = int.Parse(Console.ReadLine());
if ((a%7 == 0) && (a%23 == 0))
{
    Console.WriteLine("Yes");
}
else
{
    Console.Write("No");
}