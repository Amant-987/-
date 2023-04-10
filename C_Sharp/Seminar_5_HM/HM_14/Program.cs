// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] array = GetArray(10, 100, 999);
int count = 0;
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($" -> Count even num: {Evennum(count)}");
int[] GetArray(int size, int minv, int maxv)
{
    int[] a = new int[size];
    for (int i = 0; i < size; i++)
    {
        a[i] = new Random().Next(minv, maxv + 1);
    }
    return a;
}
// int Evennum(int count)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }
int Evennum(int count)
{
    int i = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}