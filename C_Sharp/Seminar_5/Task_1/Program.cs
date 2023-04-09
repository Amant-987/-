/* **Задача 32:**Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]  String.Join(", ", array)*/

int[] Startarray = GetArray(6, -9, 10);
Console.WriteLine(String.Join(", ", Startarray));
InversArray(Startarray);
Console.WriteLine(String.Join(", ", Startarray));
int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minvalue, maxvalue + 1);
    }
    return res;
}
int[] InversArray(int[] Startarray)
{
    int[] result = new int[Startarray.Length];
    for (int j = 0; j < Startarray.Length; j++)
        result[j] = Startarray[j];
    for (int i = 0; i < Startarray.Length; i++)
    {
        Startarray[i] = Startarray[i] * -1;
        //array[i] *= -1;

    }
    return result;
}


// //foreach(var it in array.Select((e, i) => new { Value = e, Index = i })){
//     Console.WriteLine("Element " + it.Value + " present at index " + it.Index);
// }
