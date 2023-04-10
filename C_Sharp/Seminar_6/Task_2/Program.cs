// **Задача 42:**Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10


int a = new Random().Next(1,100);
// string ToBinary(int a)
//     {
//         char[] buff = new char[32];
 
//         for (int i = 31; i >= 0 ; i--)
//         {
//             int mask = 1 << i;
//             buff[31 - i] = (a & mask) != 0 ? '1' : '0';
//         }
 
//         return new string(buff);
//     }
//  Console.WriteLine(a);
// Console.WriteLine(ConvertTo2(num));

//  string ConvertTo2(string num, int round = 5)
//         {
//             string result = ""; //Результат
//             int left = 0; //Целая часть
//             string right = "0"; //Дробная часть
//             string[] temp1 = num.Split(new char[] { '.', ',' }); //Нужна для разделения целой и дробной частей
//             left = Convert.ToInt32(temp1[0]);
//             //Проверяем имеется ли у нас дробная часть
//             if (temp1.Count() > 1)
//             {
//                 right = num.Split(new char[] { '.', ',' })[1]; //Дробная часть
//             }
//             //Алгоритм перевода целой части в двоичную систему
//             while (true)
//             {
//                 result += left % 2; //В ответ помещаем остаток от деления. В конце программы мы перевернём строку, так как в обратном порядке записываются остатки
//                 left = left / 2; //Так как Left целое число, то при делении например числа 2359 на 2, мы получим не 1179,5 а 1179
//                 if (left == 0)
//                     break;
//             }
//             result = new string(result.ToCharArray().Reverse().ToArray()); //Реверсирование строки
            
//             //Прокеряем есть ли у нас дробная часть, можно было бы проверить и так if(temp1.count()>1)
//             if (Convert.ToInt32(right) == 0)
//                 return result;
 
//             //Добавляем разделить целой части от дробной
//             result += '.';
 
//             int count = right.ToString().Count(); // Нам нужно знать кол-во цифр, при превышении которого дописывается единичка
//             int INTright = Convert.ToInt32(right);
 
//             for (int i = 0; i < round; i++)
//             {
//                 /*Умножаем число на 2 и проверяем, стало ли оно больше по количеству цифр, если да,
//                 то в результат идёт "1" и первая цифра у right удаляется */
//                 INTright = INTright * 2;
//                 if (INTright.ToString().Count() > count)
//                 {
//                     string buf = INTright.ToString();
//                     buf = buf.Remove(0, 1);
//                     INTright = Convert.ToInt32(buf);
 
//                     result += '1';
//                 }
//                 else
//                 {
//                     result += '0';
//                 }
//             }
//             return result;
//         }
int number =int.Parse(Console.ReadLine());
string res = DecToNum(number, 2);
Console.WriteLine($"{number}->{res}");
string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        
        res = nums[decNumber%otherSystem] + res;
        decNumber /= otherSystem;
    }
    return res;
}

// Console.Write("Введите число: ");
//             int num = int.Parse(Console.ReadLine()!);
            
//             Console.WriteLine(arrayToNull(num));

//             int arrayToNull(int numer)
//             {
//                 List<int> mass = new List<int>();
//                 while (numer > 1)
//                 {
//                     mass.Add(numer % 2);
//                     //Console.WriteLine(numer % 2);
//                     numer = numer / 2;
//                 }
//                 mass.Add(1);
//                 mass.Reverse();
//                 return (int.Parse(String.Join("", mass)));
//             }