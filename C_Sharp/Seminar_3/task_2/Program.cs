// 20 Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);

Console.Clear();
Console.Write("Enter X-coordinate A: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Enter Y-coordinate A: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Enter X-coordinate B: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Enter Y-coordinate B: ");
double y2 = double.Parse(Console.ReadLine());

Console.Write(Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)));
