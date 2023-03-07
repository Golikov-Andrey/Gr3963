// //takes data from console in reply to welcome msg & returns input as Int32
// int ReadDataToInt(string msg)
// {
//     Console.Write(msg);
//     return (int.Parse(Console.ReadLine() ?? "0"));
// }

// // //forms 1D array of length 'len' with random Int values <-> min & max
// // int[] Gen1DArrInt(int len, int min, int max)
// // {
// //     if (min > max) //to ensure min<max
// //     { int temp = min; min = max; max = temp; }
// //     int[] arr = new int[len];
// //     for (int i = 0; i < len; i++)
// //         arr[i] = new Random().Next(min, max + 1);
// //     return arr;
// // }

// //forms 2D int array of size countRow*countCol with random values <-> min & max
// int[,] Gen2DArr(int countRow, int countCol, int min, int max)
// {
//     if (min > max) //to ensure min<max
//     { int temp = min; min = max; max = temp; }
//     int[,] arr = new int[countRow, countCol]; for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countCol; j++)
//         {
//             arr[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return arr;
// }

// //prints 2D array into console
// void Print2DArr(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         { Console.Write($"{arr[i, j]}\t"); }
//         Console.WriteLine();
//     }
// }

// //prints 1D array into console
// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++) Console.Write($"{arr[i]}, ");
//     Console.WriteLine($"{arr[arr.Length - 1]}]");
// }

// //  //output the result
// // void PrintAnswer(string explain, int num)
// // { Console.WriteLine(explain + num); }

// //dictionary with number of symbols 'len'
// int[] FreqDicBuild(int[,] arr, int len)
// {
//     int[] dic = new int[len];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             dic[arr[i, j]]++;
//         }
//     }
//     return dic;
// }

// Console.Clear();
// int rowNum = ReadDataToInt("Enter a number of rows:    ");
// int colNum = ReadDataToInt("Enter a number of columns: ");
// Console.WriteLine();

// int[,] testArr = Gen2DArr(rowNum, colNum, 0, 9);
// Print2DArr(testArr);
//  Console.WriteLine();

//  int[] arr = FreqDicBuild(testArr, 10);
//  Print1DArr(arr);

// Print1DArr(FreqDicBuild(testArr, 10));

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArray(int countRows, int countColumn, int min, int max)
{
    int[,] arr = new int[countRows, countColumn];
    for (int i = 0; i < countRows; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

void Print1DArray(int[] array)
{
    Console.Write("[");
    for (int j = 0; j < array.Length - 1; j++)
    {
        Console.Write($"{array[j]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int[] BuildFreqDic(int[,] arr, int length)
{
    int[] dictionary = new int[length];
    for (int i =0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j< arr.GetLength(1); j++)
        {
            dictionary[arr[i,j]]++;
        }
    }
    return dictionary;
}

int inRow = ReadData("Please enter the desired number of rows: ");
int inCol = ReadData("Please enter the desired number of columns: ");
int[,] testArr = Gen2DArray(inRow, inCol, 1, 9);
Print2DArr(testArr);
Console.WriteLine();

int[] freqDic = BuildFreqDic(testArr, 10);
Print1DArray(freqDic);