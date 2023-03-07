// Задача №53
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
void Gen2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


// 2 0 0 0
// 1 1 1 1  temp 
// 0 2 2 2
void Change2DArray(int[,] matr)
{
    int temp =0;
    for(int i =0; i<matr.GetLength(1);i++)
    {
        //(matr[0,i],matr[matr.GetLength(0)-1,i])=(matr[matr.GetLength(0)-1,i],matr[0,i]);
        temp=matr[0,i];
        matr[0,i]=matr[matr.GetLength(0)-1,i];
        matr[matr.GetLength(0)-1,i] = temp;
    }
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];
Gen2DArray(matrix,1,100);
Print2DArray(matrix);
Change2DArray(matrix);
Print2DArray(matrix);