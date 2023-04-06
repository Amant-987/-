// // Напишите программу, которая принимает на вход число N 
// // и выдает произведение чисел от 1 до N 
// 4->24
// 5-> 120 == 1*2*3*4*5

int multiply(int num)
{
    int result = 1;
    for (int i = 2; i < num + 1; i++)
    {
        result = result * i;
    }
    return result;
}

Console.Clear();
Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

Console.Write(multiply(num));