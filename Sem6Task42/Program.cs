/*
Задача №42
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
*/

//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Метод для вывода данных
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}

int num = ReadInputInt("Введите число: ");

string DecToBin(int numer)
{
    string result = "";
    while (numer > 0)
    {
        result = numer % 2 + result;
        numer /= 2;
    }
    return result;
}

string DecToBinNativ(int num, int baseI)
{
    return Convert.ToString(num, baseI);
}

WriteMess($"Число {num} в двоичной системе = {DecToBin(num)}");
WriteMess($"Число {num} в двоичной системе = {DecToBinNativ(num,8)}");
WriteMess($"Число {num} в двоичной системе = {DecToBinNativ(num,16)}");


WriteMess("Число "+num+" в двоичной системе = "+DecToBin(num));
WriteMess("Число "+num+" в двоичной системе = "+DecToBinNativ(num,8));
WriteMess("Число "+num+" в двоичной системе = "+DecToBinNativ(num,16));