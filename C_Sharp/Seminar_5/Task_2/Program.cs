/* **Задача 33:**Задайте массив.Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.

4; массив[6, 7, 19, 345, 3]->нет
3; массив[6, 7, 19, 345, 3]->да*/

int[] array = { 6, 7, 19, 345, 3 };
int temp = 3;
int constMe = 0;
foreach (int i in array)
{
    if (i == temp)
    {
        constMe = 1;
    }
    else
    {
        constMe = 0;
    }
}
Console.WriteLine(constMe > 0 ? "Yes" : "No");