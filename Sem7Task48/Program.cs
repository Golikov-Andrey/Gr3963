// Console.Clear();


// int[,] GenArry( int RowCount, int ColCount)
// {
//     int[,] binarray = new int[RowCount, ColCount];

//     for (int i = 0; i < RowCount; i++)
//     {
//         for (int j = 0; j < ColCount; j++)
//         {
//             binarray[i,j] = i+j;
//         }
//     }
//     return binarray;
// }

// void PrintArry(int[,] array)
// {
//      ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};

//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.ForegroundColor = col[new Random().Next(0,16)];
//             Console.Write($"{array[i,j]}\t");
//             Console.ResetColor();
//         }
//        Console.WriteLine();
//     }

// }

// int[,] array = GenArry( 8, 9);
// Console.WriteLine("Исходный массив:");
// PrintArry(array);

int[,] Gen2DArrayMod(int countRows, int countColumn)
{
    int[,] arr = new int[countRows, countColumn];

    for (int i = 0; i < countRows; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = i + j;
        }
    }

    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] testArr = Gen2DArrayMod(8, 9);
Print2DArr(testArr);