Console.Clear();
int ReadData(string WrDate)
{
    Console.WriteLine(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

void PrintData(string text, int print)
{
    Console.WriteLine($"{text}:{print}");
}

int[,] GenArry(int min, int max, int RowCount, int ColCount)
{
    int buf;
    if (min > max)
    {
        buf = min;
        min = max;
        max = buf;
    }
    int[,] binarray = new int[RowCount, ColCount];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < RowCount; i++)
    {
        for (int j = 0; j < ColCount; j++)
        {
        
            binarray[i,j] = numSintezator.Next(min, max);
            
        }
    }
    return binarray;
}

void PrintArry(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
       Console.WriteLine();
    }

}

int SumDiagElem(int[,] array)
{
    int Result=0;
    int min=array.GetLength(0);
    if(array.GetLength(0)>array.GetLength(1)) min=array.GetLength(1);

    for (int i = 0; i < min; i++)
    {
        Result += array[i,i];
    }
    return Result;
}


int row=ReadData("Введите кол-во строк");
int col=ReadData("Введите кол-во столбцов");
int[,] array = GenArry(20, 100, row, col);
Console.WriteLine("Исходный массив:");
PrintArry(array);

 PrintData("Сумма диагональных элементов", SumDiagElem(array));