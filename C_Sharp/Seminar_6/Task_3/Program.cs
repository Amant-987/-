// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.

// Если N = 5-> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

// <aside>
// ❗ Числа Фибоначчи — числовая ****последовательность,
//  каждый элемент которой равен сумме двух предыдущих.
int num = new Random().Next(0, 10);
Console.WriteLine(num);
int first = 0;
int second = 1;
int temp = 0;
Console.WriteLine(first);
for (int i = 0; i < num - 1; i++)
{
    Console.WriteLine(second);
    temp = second;
    second = second + first;
    first = temp;
}
//0, 1, 1, 2, 3, 5, 8, 13, 21

// static int fib(int n)
// {
//   return n > 1 ? fib(n - 1) + fib(n - 2) : n;
// }

// int[] Fib(int n){
//     int[] mas_f = new int[n];
//     mas_f[0] = 0;
//     if(n >= 2){
//         mas_f[1] = 1;
//     }else { return mas_f; }
//     for (int i = 2; i < n; i++){
//         mas_f[i] = mas_f[i - 1] + mas_f[i - 2];
//     }
//     return mas_f;
// }