int a = 2;
int b = 6;
int c = 3;
int d = 7;
int e = 5;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max= ");
Console.WriteLine(max);
