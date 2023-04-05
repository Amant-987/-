// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] Array(int size)
{
    int[] result = new int[size];
    for (int a = 0; a < size; a++)
    {
        result[a] = new Random().Next(100);
    }
    return result;
}

int size = 18;
Console.WriteLine($"[{String.Join(" | ", Array(size))}]");