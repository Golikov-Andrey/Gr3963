// Console.Clear();
// int ReadData(string WrDate)
// {
//     Console.WriteLine(WrDate);
//     int result = int.Parse(Console.ReadLine() ?? "0");
//     return result;
// }
// int number = ReadData("Введите число");

// int fact = 1;
// for (int x = 1; x <= number; x++)
// {
// fact *= x;
// }

// Console.WriteLine(fact);



// int ReadData(string msg)
// {
//     Console.Write(msg);
//     return (int.Parse(Console.ReadLine() ?? "0"));
// }
// //output the result
// void PrintAnswer(string explain, int num)
// { Console.WriteLine(explain + num); }
// //method to compute the result
// long FactSimple(int num)
// {
//     long sum = 1;
//     for (int i = 2; i <= num; i++)
//     { 
//         sum *= i;
//     }
//     return sum;
// }
// int num = ReadData("Enter a value: ");
// Console.WriteLine($"The factorial of the value: {FactSimple(num)}");

using System.Numerics;
/*
Задача №28
Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.

*/
// using System.Numerics;

// int ReadInputInt(string mess)
// {
//     Console.Write(mess);
//     return Convert.ToInt32(Console.ReadLine() ?? "0");
// }
// void WriteMess(string mess)
// {
//     Console.WriteLine(mess);
// }

// BigInteger FactorialCalc(int numer)
// {   
//     BigInteger fact = 1;

//     for(int i = 2; i<= numer; i++)
//     {
//         fact *= i;
//     }

//     return fact;
// }

// int num = ReadInputInt("Введите число: ");

// WriteMess($"{num}! = {FactorialCalc(num)}");

using System.Numerics;

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintData(string message)
{
    Console.WriteLine(message);
}

BigInteger FactorCalc (int num)
{
    BigInteger fact = 1;
    for (int i = 2; i <= num; i++)
    {
        fact = fact * i;
    }
    return fact;
}

int N = ReadData("Enter your value: ");
PrintData("The factorial of set value is " + FactorCalc(N));