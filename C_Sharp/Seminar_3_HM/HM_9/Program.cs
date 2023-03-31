// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Enter X-coordinate A: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Enter Y-coordinate A: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Enter Z-coordinate A: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Enter X-coordinate B: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Enter Y-coordinate B: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Enter Z-coordinate B: ");
double z2 = double.Parse(Console.ReadLine());

Console.Write(Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2)));