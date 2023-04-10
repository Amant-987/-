// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Enter number of size array: ");
int b = int.Parse(Console.ReadLine());
int[] array = getarray(b, 1, 200);
// Array.Sort(array);
// int min_temp = array[0];
// int max_temp = array[b - 1];
// float dev = max_temp - min_temp;
// Console.WriteLine($"Min number from array is {min_temp}, max number from array is {max_temp}, deviation of this two numbers is {dev}");
Console.WriteLine(String.Join(", ",array));
Console.WriteLine($"Min number from array is {FindMin(array)}, max number from array is {FindMax(array)}, deviation of this two numbers is {FindMax(array) - FindMin(array)}");

int[] getarray(int size, int minv, int maxv)
{
    int[] a = new int[size];
    for (int i = 0; i < size; i++)
    {
        a[i] = new Random().Next(minv, maxv + 1);
    }
    return a;
}

int FindMin(int[] array)
{
    int min = int.MaxValue;
    if (array.Length != 0)
    {
        foreach (var i in array)
        {
            if (i < min)
            {
                min = i;
            }
        }
    }
    return min;
}
int FindMax(int[] array)
{
    int max = int.MinValue;
    if (array.Length != 0)
    {
        foreach (var i in array)
        {
            if (i > max)
            {
                max = i;
            }
        }
    }
    return max;
}
