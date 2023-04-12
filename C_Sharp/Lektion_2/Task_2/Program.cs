int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] array={111,225,34,42,54,62,47,28,59};

int maxF = Max(Max(array[0], array[1], array[2]), 
Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(maxF);