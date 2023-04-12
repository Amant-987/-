// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter N numbers with space between it: ");
string[] array = Console.ReadLine().Split(' ');

int Count(string[] array)
{
    int c = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (int.Parse(array[i]) > 0) c++;
    }

    return c;
}
Count(array);

Console.WriteLine(String.Join(" / ", array));
Console.WriteLine(Count(array));