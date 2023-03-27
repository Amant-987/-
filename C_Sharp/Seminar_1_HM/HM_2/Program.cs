// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third number: ");
int c = int.Parse(Console.ReadLine());

if (a > b) {
    if (a > c) {
        Console.Write("This is bigger number: ");
        Console.Write(a);
    }
    else {
        Console.Write("This is bigger number: ");
        Console.Write(c);
    }
}
else {
    if (b > c) {
        Console.Write("This is bigger number: ");
        Console.Write(b);
    }
    else {
        Console.Write("This is bigger number: ");
        Console.Write(c);
    }
}

