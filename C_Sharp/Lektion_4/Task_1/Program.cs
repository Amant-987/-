// two-dimensional array 
//type_massive[,] name_of_array=new type_massive[number_line,number_column] 
// int[,] matrix = new int[5,8]; 
//where 5 - rows, matrix.GetLength(0); 8 - columns, matrix.GetLength(1)
//string[,] array = new string[2,3];
//array[0,0] array[0,1] array [0,2] array[1.0] array[1,1] array [1,2]
//string.Empty


string[,] table = new string[2, 5];
table[1, 2] = "text";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"{table[rows, columns]}-");
    }
    Console.WriteLine();
}

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(1,10); //  (1;10)
    }
}

}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);