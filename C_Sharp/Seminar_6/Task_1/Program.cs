// // **Задача 40:**Напишите программу, 
// // которая принимает на вход три числа и проверяет, может ли 
// // существовать треугольник с сторонами такой длины.


// // ❗ **Теорема о неравенстве треугольника:
// // **каждая сторона треугольника меньше суммы двух других сторон.
// Console.WriteLine("Enter three number: ");
// string[] st = Console.ReadLine().Split(' ');
// // int a = st[0];
// // int b = st[1];
// // int c = st[2];

// bool CheckTriangle(int a, int b, int c){
// return (a+b<c && b+c<a && a+c<b );
// }
// if (CheckTriangle(a,b,c))
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }

// // Console.Clear();
// // Console.Write("Введите стороны треугольника через пробел: ");

// // string[] st = Console.ReadLine().Split(' ');
// // int a = int.Parse(st[0]);
// // int b = int.Parse(st[1]);
// // int c = int.Parse(st[2]);

// // if (IsTriangle(a, b, c)){
// //     Console.WriteLine("Да");
// // }
// // else{
// //     Console.WriteLine("Нет");
// // }

// // bool IsTriangle(int a, int b, int c){
// //     return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
// // }