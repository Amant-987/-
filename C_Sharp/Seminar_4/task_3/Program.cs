// Напишите программу, которая выводит массив из 8 элементов
// заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]
// int a= new Random().Next(2,7)
// int b = new Random().Next(2)

int[] BinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 1; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
}
Console.Write("Enter number: ");
int size = int.Parse(Console.ReadLine());
//Console.Write($"[{String.Join(", ", BinaryArray)}]");
Console.WriteLine($"[{String.Join(", ", BinaryArray(size))}]");