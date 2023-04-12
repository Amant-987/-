int[] array = { 8, 7, 6, 35, 87, 35, 39, 123, 34 };

int n = array.Length;
int find = 35;
int ind = 0;

while (ind < n)
{
    if (array[ind] == find)
    {
        Console.WriteLine(ind);
        break;
    }

    ind++;
}