// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("Enter size of array: ");
int a = int.Parse(Console.ReadLine());
int[] array = getarray(a, -20, 20);
int result = 0;
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Sum of not even index element is {SumElement(result)}");



int[] getarray(int size, int minv, int maxv)
{
    int[] a = new int[size];
    for (int i = 0; i < size; i++)
    {
        a[i] = new Random().Next(minv, maxv + 1);
    }
    return a;
}

int SumElement(int result)
{
    for (int i = 0; i < array.Length; i++)
    {

        if (i % 2 != 0)
        {
            result += array[i];
        }

    }
    return result;
}

