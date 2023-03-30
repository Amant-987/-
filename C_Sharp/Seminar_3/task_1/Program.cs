// **Задача 18:**

// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
class task_1
{
public static void Main()
{
    Console.Clear();
    Console.Write("Enter number of quadra: ");
    int quad = int.Parse(Console.ReadLine());

switch (quad)
{
    case 1:
    Console.Write("x>0, y>0");
    break;
    case 2:
    Console.Write("x<0, y>0");
    break;
    case 3:
    Console.Write("x<0, y<0");
    break;
    case 4:
    Console.Write("x>0, y<0");
    break;
    default:{
    Console.Write("Quadra didn't have number like yours!");
     break;
    }
}

}


}