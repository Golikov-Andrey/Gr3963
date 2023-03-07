//takes double value from console; replaces ',' with '.' if found
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    string inStr = Console.ReadLine() ?? "0"; inStr = inStr.Replace(',', '.');
    return (int.Parse(inStr));
}
//forms 2D int array of size countRow*countCol with random values <-> min & max
int[,] Gen2DArr(int countRow, int countCol, int min, int max)
{
    if (min > max) //to ensure min<max
    {
        int temp = min; min = max; max = temp;
    }
    int[,] arr = new int[countRow, countCol];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}
//prints 2D array into console
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

void TransposeArray(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
}

Console.Clear();
 int rowNum = ReadDataToInt("Enter a number of rows:    ");
int colNum = ReadDataToInt("Enter a number of columns: ");
Console.WriteLine();

int[,] testArr = Gen2DArr(rowNum, colNum, 10, 99);
Print2DArr(testArr);
if (testArr.GetLength(0) == testArr.GetLength(1))
{
    TransposeArray(testArr);
    Print2DArr(testArr);
}
else
{
    Console.WriteLine("The matrix is not square!");
}
Console.WriteLine(); 
