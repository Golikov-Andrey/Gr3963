// //takes double value from console; replaces ',' with '.' if found
// int ReadDataToInt(string msg)
// {
//     Console.Write(msg);
//     string inStr = Console.ReadLine() ?? "0";
//     inStr = inStr.Replace(',', '.');
//     return (int.Parse(inStr));
// }
// //forms 2D array of length 'len' with random values <-> min & max
// int[,] Gen2DArr(int countRow, int countCol, int min, int max)
// {
//     if (min > max) //to ensure min<max
//     { int temp = min; min = max; max = temp; }

//     int[,] arr = new int[countRow, countCol];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countCol; j++)
//         {
//             arr[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return arr;
// }

// void SquaredElemEvenIndexes(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//                 arr[i, j] = arr[i, j] * arr[i, j];
//         }
//     }
// }
// //prints 2D array into console
// void Print2DArrRndColor(int[,] arr)
// {
//     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                                                              ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                                                                                                ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                                                                                                                                     ConsoleColor.Yellow};
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = col[new Random().Next(0, 16)];
//             Console.Write($"{arr[i, j]}\t"); Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }

// int rowNum = ReadDataToInt("Enter a number of rows:    ");
// int colNum = ReadDataToInt("Enter a number of columns: ");
// int[,] testArr = Gen2DArr(rowNum, colNum, 10, 99);
// Print2DArrRndColor(testArr);
// Console.WriteLine();
// SquaredElemEvenIndexes(testArr); Print2DArrRndColor(testArr);

// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
// {
//     // Корректировка входных данных
//     if (min > max)
//     {
//         int buf = min;
//         min = max;
//         max = buf;
//     }
//     Random rnd = new Random();
//     int[,] arr = new int[countRow, countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             arr[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return arr;
// }

// void Print2DArr(int[,] arr)
// {
//     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = col[new Random().Next(0,16)];
//             Console.Write(arr[i, j] + "  ");
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }

// int [,] RemastArr(int[,] arr, int countRow, int countColumn)
// {
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             if((i%2 == 0) && (j%2 ==0))
//             {
//                 arr[i, j] = arr[i, j]*arr[i, j];
//             }
//         }
//     }
//     return arr;
// }

// int row = ReadData("Введите количество строк ");
// int column = ReadData("Введите количество столбцов ");
// int[,] testArr = Gen2DArr(row, column, 1, 10);
// Print2DArr(testArr);
// int[,] resArr = RemastArr(testArr, row, column);
// Print2DArr(resArr);

// Console.Clear();

// int ReadData(string WrDate)
// {
//     Console.WriteLine(WrDate);
//     int result = int.Parse(Console.ReadLine() ?? "0");
//     return result;
// }

// void PrintData(string text, int print)
// {
//     Console.WriteLine($"{text}:{print}");
// }

// int[,] GenArry(int min, int max, int RowCount, int ColCount)
// {
//     int buf;
//     if (min > max)
//     {
//         buf = min;
//         min = max;
//         max = buf;
//     }
//     int[,] binarray = new int[RowCount, ColCount];
//     System.Random numSintezator = new System.Random();
//     for (int i = 0; i < RowCount; i++)
//     {
//         for (int j = 0; j < ColCount; j++)
//         {
          
//             binarray[i,j] = numSintezator.Next(min, max);
//             if(i%2==0 && j%2==0)
//             {
//                 binarray[i,j] *=binarray[i,j];
//             }
            
//         }
//     }
//     return binarray;
// }

// void PrintArry(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}\t");
//         }
//        Console.WriteLine();
//     }

// }
// int row=ReadData("Введите кол-во строк");
// int col=ReadData("Введите кол-во столбцов");
// int[,] array = GenArry(20, 100, row, col);
// Console.WriteLine("Исходный массив:");
// PrintArry(array);


// Console.Clear();
// int ReadData(string WrDate)
// {
//     Console.WriteLine(WrDate);
//     int result = int.Parse(Console.ReadLine() ?? "0");
//     return result;
// }

// void PrintData(string text, int print)
// {
//     Console.WriteLine($"{text}:{print}");
// }

// int[,] GenArry(int min, int max, int RowCount, int ColCount)
// {
//     int buf;
//     if (min > max)
//     {
//         buf = min;
//         min = max;
//         max = buf;
//     }
//     int[,] binarray = new int[RowCount, ColCount];
//     System.Random numSintezator = new System.Random();
//     for (int i = 0; i < RowCount; i++)
//     {
//         for (int j = 0; j < ColCount; j++)
//         {
          
//             binarray[i,j] = numSintezator.Next(min, max);
//             if(i%2==0 && j%2==0)
//             {
//                 binarray[i,j] *=binarray[i,j];
//             }
            
//         }
//     }
//     return binarray;
// }

// void PrintArry(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}\t");
//         }
//        Console.WriteLine();
//     }

// }
// int row=ReadData("Введите кол-во строк");
// int col=ReadData("Введите кол-во столбцов");
// int[,] array = GenArry(20, 100, row, col);
// Console.WriteLine("Исходный массив:");
// PrintArry(array);

// int ReadData(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// int[,] Gen2DArray(int countRows, int countColumn, int min, int max)
// {
//     int[,] arr = new int[countRows, countColumn];
//     for (int i = 0; i < countRows; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             arr[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return arr;
// }

// void Print2DArr(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void Update2DArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (i%2==0 && j%2==0) arr[i,j] = arr[i,j] * arr[i,j];
//         }
//     }
// }

// Console.Clear();

// int rows = ReadData("Enther the desired number of rows: ");
// int col = ReadData("Eneter the desired number of columns: ");
// int[,] testArray = Gen2DArray(rows, col, 10, 99);
// Print2DArr(testArray);
// Console.WriteLine();
// Update2DArray(testArray);
// Print2DArr(testArray);


//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
//метод генерации массива
int[,] Gen2DArr(int Row,int Coloumn,int min,int max)
{
    
    int[,] arr=new int[Row,Coloumn];
    for(int i=0;i<Row;i++)
    {
        for(int j=0;j<Coloumn;j++)
        {
            arr[i,j]=new Random().Next(min,max+1);
        }
    }
    return arr;
} 

void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.DarkRed};
    for(int i=0; i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1);j++)
        {
            Console.ForegroundColor=col[new Random().Next(0,3)];
            Console.Write(arr[i,j]+"\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    } 
}

void Update2DArr(int [,]arr)
{
   for(int i=1; i<arr.GetLength(0);i+=2)
    {
        for(int j=1; j<arr.GetLength(1);j+=2)
        {
           arr[i,j]*=arr[i,j];
        } 
        }
}

void Update2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0) arr[i,j] = arr[i,j] * arr[i,j];
        }
    }
}


int row =ReadData("Количество строк");
int column=ReadData("Количество столбцов");

int[,] arr2D= Gen2DArr(row,column,10,99);

DateTime d2 = DateTime.Now;
Update2DArray(arr2D);
Console.WriteLine(DateTime.Now-d2);

DateTime d1 = DateTime.Now;
Update2DArr(arr2D);
Console.WriteLine(DateTime.Now-d1);



//Print2DArr(arr2D);