// int ReadData(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// void PrintData(string msg)
// {
//     Console.WriteLine(msg);
// }

// long RaiseToRec(int a, int b)
// {
//     if (b == 0) return 1;
//     else return a * RaiseToRec(a, b-1);
// }

// long MyPow(int a, int b)
// {
//     if(b==2)
//     {
//         return 4;
//     }
//     else
//     {
//         return MyPow(a,b/2)*MyPow(a,b/2);
//     }
// }

// //Console.Clear();
// int num = ReadData("Enter your number: ");
// int deg = ReadData("Enter the degree to raise to: ");
// //PrintData($"{RaiseToRec(num, deg)}");
// //PrintData($"{MyPow(num, deg)}");

// long res1 =0;
// long res2 =0;



// DateTime d2 = DateTime.Now;
// res2 = MyPow(num,deg);
// PrintData("Решение MyPow" + (DateTime.Now - d2));

// // DateTime d1 = DateTime.Now;
// // res1 = RaiseToRec(num,deg);
// // PrintData("Решение RaiseToRec" + (DateTime.Now - d1));

// Console.Clear();
// int ReadData(string WrDate)
// {
//     Console.Write(WrDate);
//     int result = int.Parse(Console.ReadLine() ?? "0");
//     return result;
// }

// long  MyPow(int a,int b)
// {

//      if (b == 1)
//     {
//         return a ;
//     }
//     else
//     {
//        return a*MyPow(a,b-1);
//     }

// }

// int a = ReadData("Введите число a: ");
// int b = ReadData("Введите число b: ");

// long res = MyPow(a,b);
// Console.WriteLine(res);

//takes data from console in reply to welcome msg & returns input as Int32
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}
long RecPow(int a, int b)
{
    if (b <= 1)
    {
        return a;
    }
    else { return a * (RecPow(a, b - 1)); }
}
int a = ReadDataToInt("Enter the base : ");
int b = ReadDataToInt("Enter the power: ");
Console.WriteLine();
Console.WriteLine(RecPow(a, b));