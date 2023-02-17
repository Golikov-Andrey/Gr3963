// //Метод выводит данные пользователю
// void PrintData(string msg, double val)
// {
//     Console.WriteLine(msg+val);
// }

// // Задача №22
// // Напишите программу, которая принимает на вход число (N) 
// // и выдаёт таблицу квадратов чисел от 1 до N.

// int ReadInput(string mess)
// {
//     Console.Write(mess);
//     return Convert.ToInt32(Console.ReadLine() ?? "0");
// }

// void LineBuilder(int end)
// {
//     for(int i = 1; i<=end; i++)
//     {
//         Console.Write($"{i}\t");
//     }

//     Console.WriteLine();

//     for(int i = 1; i<=end; i++)
//     {
//         Console.Write($"{Math.Pow(i,2)}\t");
//     }
// }

// int N = ReadInput("Введите конечное число: ");
// LineBuilder(N);

// using System;

// class Program
// {

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите число N");
//         int n = int.Parse(Console.ReadLine());
//         for (int i = 1; i <= n; i++)
//             Console.WriteLine("{0}^2 = {1}", i, i * i);
//         Console.ReadKey(true);
//     }
// }

// Задача №22
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

string LineBuilder(int end, int pow)
{
    string res = String.Empty;
    for(int i = 1; i<=end; i++)
    {
        res = res + Math.Pow(i,pow)+"\t";
        //Console.Write($"{Math.Pow(i,pow)}\t");
    }
    return res;
    //Console.WriteLine();
}

int N = ReadInput("Введите конечное число: ");
Console.WriteLine(LineBuilder(N,1));
Console.WriteLine(LineBuilder(N,2));