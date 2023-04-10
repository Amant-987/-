int[] array = getarray(10, -20, 20);
Console.WriteLine(string.Join(", ", array));

int[] getarray(int size, int minv, int maxv)
{
    int[] a = new int[size];
    for (int i = 0; i < size; i++)
    {
        a[i] = new Random().Next(minv, maxv + 1);
    }
    return a;
}

int[] SumPosNeg(int[] array)
{
    int[] result = new int[2];
    foreach (int el in array)//[1, 2, 3, 4, -5, 1, -3] el = -5
    {
        //int a = el > 0 ? el : 0;
        //result[0] += a;
        result[0] += el > 0 ? el : 0;//ps += -5 > 0? 2 : 0;
        result[1] += el < 0 ? el : 0;
    }
    return result;
}