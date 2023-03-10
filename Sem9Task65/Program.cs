// // ---------------------------------------------------------------------
// //                                 Задача 65
// // Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.
// // ---------------------------------------------------------------------

// // Чтение данных из консоли
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// // Печать результата
// void PrintResult(string prefix)
// {
//     Console.WriteLine(prefix);
// }

// string RecMN(int m, int n)
// {
//     string res = string.Empty;
//     if (m >= n)
//     {
//         res = n.ToString();
//     }
//     else
//     {
//         res = res + m + " " + RecMN(m + 1, n);
//     }
//     return res;
// }

// int number1 = ReadData("Введите число M: ");
// int number2 = ReadData("Введите число N: ");
// string resultLine = number1<number2?RecMN(number1, number2):RecMN(number2, number1);
// PrintResult(resultLine);


int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

string RecMN(int m, int n)
{
    string res = string.Empty;
    if (m >= n)
    {
        res = res + n;
    }
    else
    {
        res = res + m + " " + RecMN(m + 1, n);
    }
    return res;
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int m = ReadData("Enter your first number: ");
int n = ReadData("Enetr your second number: ");
string result = "";

if (m < n) result = RecMN(m, n);
else result = RecMN(n, m);

PrintData(result);