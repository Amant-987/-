//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

double Degree(double num, double num2)
{        double result = 0;
    result = Math.Pow(num,num2);
return result;
}

Console.Clear();
Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Enter degree: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write($"{num} ^ {num2} = {Degree(num,num2)}");
