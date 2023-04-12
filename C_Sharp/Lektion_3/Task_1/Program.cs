// void - input or not without output
// Method 3 - output without input
// Method 4 - input with output

//Method 1 input = 0, output = 0
void Method1()
{
    Console.WriteLine("Author Amant - Method1");
}

Method1();


//Method 2 input = something, output = 0
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Author Amant - method2");
//or ethod2(msg: "Author Amant - method2"); - when input not only one

void Method22(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;//increment or decrement count--;
    }

}
Method22("Author Amant - method22",2);
Method22(msg: "Author Amant - method22 new",count: 3);
Method22(count: 4, msg: "Author Amant - method22 nue");


//Method 3 input = 0, output = result
int Method3 ()
{
return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


//Method 3 input = something, output = result
string Method4(int count, string text)
{
    int i =0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf, ");
Console.WriteLine(res);
