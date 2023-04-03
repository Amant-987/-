// 26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5
int Digits(int num)
{
    if (num == 0)
        return 1;

    var result = 0;
    
    while(num > 0)
    {
        num = num / 10;
        result++;
    }
    
    return result;
} 
Console.Clear();
Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
int result = 0;

Console.Write(Digits(num));




// Console.Clear();
// Console.Write("Enter number: ");
// int num = int.Parse(Console.ReadLine());
// int a = 0;
// int num_a = num;
// while (num_a > 0)
// {
//     a = a * 10 + num_a % 10;
//     num_a /= 10;
// }
// if (num == a)
// {
//     Console.Write("This is a Palindrom!");
// }
// else
// {
//     Console.Write("This isn't a Palindrom!");
// }