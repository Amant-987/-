// 5! = 5*4*3*2*1 factorial
// 5! = 5*4! = 5*4*3!/// and so on

double Factorial(int n) 
//for biiig nu,bers use type double, for less numbers use type int
{// 1! = 1
 // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    //Console.WriteLine(Factorial(i));
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
//Console.WriteLine(Factorial(5)); //1*2*3=6
