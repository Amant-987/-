// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// k1*x+b1=k2*x+b2
// k1*x-k2*x=b1-b2
// x=(b2-b1)/(k1-k2) or x=(b1-b2)/(k2-k1)
// y=k1*((b2-b1)/(k1-k2))+b1 or y=(k2*b1-k1*b2)/(k2-k1)

Console.WriteLine("Enter 4 numbers with space between it(b1,k1,b2,k2): ");
string[] array = Console.ReadLine().Split(' ');
double b1 = double.Parse(array[0]);
double k1 = double.Parse(array[1]);
double b2 = double.Parse(array[2]);
double k2 = double.Parse(array[3]);

void Formula(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) Console.WriteLine("They don't cross over.");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        Console.WriteLine($"x={x}");
        double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
        Console.WriteLine($"y={y}");
        Console.WriteLine(String.Join("; ", x, y));
        Console.WriteLine();

        //second variation
        double x2 = (b1 - b2) / (k2 - k1);
        Console.WriteLine($"x2={x2}");
        double y2 = (k2 * b1 - k1 * b2) / (k2 - k1);
        Console.WriteLine($"y2={y2}");
        Console.WriteLine(String.Join(";", x2, y2));
    }
}

Formula(b1, k1, b2, k2);