// sort massive
int[] array = newArray(10, 1, 200);
int[] array2 = newArray(10, 1, 200);

int[] newArray(int length, int minValue, int maxValue)
{
    int[] a = new int[length];
    for (int i = 0; i < length; i++)
    {
        a[i] = new Random().Next(minValue, maxValue);
    }
    return a;
}

int MaxVal(int[] array)
{
    int max = array[0];
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) result = array[i];
    }
    return result;
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        int minPos = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPos]) minPos = j;
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }

}

void ReverseSort(int[] array2)
{

    for (int i = 0; i < array2.Length; i++)
    {
        int maxPos = i;

        for (int j = i + 1; j < array2.Length; j++)
        {
            if (array2[j] > array2[maxPos]) maxPos = j;
        }
        int temp = array2[i];
        array2[i] = array2[maxPos];
        array2[maxPos] = temp;
    }

}

PrintArray(array);
SelectionSort(array);
PrintArray(array);
Console.WriteLine();
PrintArray(array2);
ReverseSort(array2);
PrintArray(array2);

int max = MaxVal(array);
Console.WriteLine(max);