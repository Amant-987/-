//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int Degree(double num, double num2)
// {        double result = 0;
//     result = Math.Pow(num,num2);
// return result;
// }

// Console.Clear();
// Console.WriteLine("Enter number: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter degree: ");
// int num2 = int.Parse(Console.ReadLine());
// Console.Write($"The number {num} to the degree of {num} is {Degree}");


int Degree(int num, int grad){
  int result = 1;
  for(int i=1; i <= grad; i++){
    result = result * num;
  }
    return result;
}
  Console.Write("Number: ");
  int num = int.Parse(Console.ReadLine());
  Console.Write("Degree: ");
  int grad = int.Parse(Console.ReadLine());
  int degree = Degree(num, grad);
  Console.WriteLine("Result: " + degree);