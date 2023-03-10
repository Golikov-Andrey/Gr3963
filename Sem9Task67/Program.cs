// Console.Clear();
// int ReadData(string WrDate)
// {
//     Console.Write(WrDate);
//     int result = int.Parse(Console.ReadLine() ?? "0");
//     return result;
// }

// int SumDigit(int num)
// {
//      if (num < 1)
//     {
//         return 0 ;
//     }
//     else
//     {
//        return num%10+SumDigit(num/10);
//     }
   
// }

// int num = ReadData("Введите число");


// int res = SumDigit(num);
// Console.WriteLine(res);

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int SumDigitRec(int num)
{
    if (num == 0) return 0;
    else return num%10 + SumDigitRec(num/10);
}

int inputNum = ReadData("Enter your number: ");
PrintData($"{SumDigitRec(inputNum)}");