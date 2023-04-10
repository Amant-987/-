/*Задача 45: Напишите программу,
 которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

// Console.WriteLine("Enter number of size array: ");
// int b = int.Parse(Console.ReadLine());
// int[] array = getarray(b, 1, 200);
// Console.WriteLine(string.Join(", ",CopyMass(copy)));

// int[] getarray(int size, int minv, int maxv)
// {
//     int[] a = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         a[i] = new Random().Next(minv, maxv + 1);
//     }
//     return a;
// }

// int[] CopyMass(int[] array){
//     int[] copyarray = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         copy[i]=array[i];
//     }
//     return copy;
// }

int[] ArrayAll = GenerateArray(); // задаем инфу для метода создания массива
        Console.WriteLine($"[{String.Join(", ", ArrayAll)}]");
        int[] newArray2 = copyMe(ArrayAll, ArrayAll.Length);
        Console.WriteLine($"[{String.Join(", ", newArray2)}]");

        int[] GenerateArray() // генератор массива с произвольными числами
        {
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = new Random().Next(-100, 100);
            }
            return array;
        }

        int[] copyMe(int[] array, int len)
        {
            int[] newArray = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }