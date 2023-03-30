Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number >= 100 || number < 1000)
{
    int result = ((number % 100 - number % 10) / 10);
    Console.WriteLine(result);
}
else
    Console.WriteLine("Это не трехзначное число: ");