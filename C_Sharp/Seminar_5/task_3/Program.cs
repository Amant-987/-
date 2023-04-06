/* **Задача 35:**Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2]-> 0

[10, 11, 12, 13, 14]-> 5

*/

List<int> list = new List<int>();
int[] array = new int [123];
int a = 10, b = 99, count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 123);
}
foreach (int item in array)
{
    if (item > a && item < b)
    {
        count++;
    }
}
Console.Write(count);

// int a = 10, b = 99, count = 0;
//         List<int> list = new List<int>();
//         //int[] array=new int [123];
        
//         for (int i = 0; i < 123; i++)
//         {
//             list.Add(new Random().Next(0, 123));
//         }


//         /*for (int i = 0; i < array.Length; i++)
//         {
//             array[i]=new Random().Next(0, 123);
//         }*/
        
//         foreach (int k in list)
//         {
//             if (k >= a && k <= b)
//             {
//                 count++;
//                 //Console.WriteLine(k);
//             }
//         }
//         Console.WriteLine(count);