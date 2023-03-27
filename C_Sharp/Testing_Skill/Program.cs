/*
Sample Input
["eat", "tea", "tan", "ate", "nat", "bat"]
Sample Output
[ ["ate", "eat", "tea"], ["nat", "tan"], ["bat"] ]
Т.е. сгруппировать слова по " общим буквам ".
*/
Console.Clear();
string str = "";
string str1 = "";
Console.WriteLine("Enter word: ");
str = Console.ReadLine();
Console.WriteLine("Enter second word: ");
str1 = Console.ReadLine();
 
char[] mass = str.ToCharArray();
char[] mass2 = str1.ToCharArray();
 
Array.Sort(mass);
Array.Sort(mass2);
bool flag = true;

if ((mass.Length == mass2.Length))
    {
    for (int i = 0; i < mass.Length; i++)
        {
        if (mass[i] != mass2[i])
            {
            flag = false;
            }
        }
        if (flag)
           {
            Console.WriteLine("GOOD");
            }
    }
