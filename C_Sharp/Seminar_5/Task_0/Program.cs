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