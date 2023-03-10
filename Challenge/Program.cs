// Программа, которая заполняет спирально массив (квадратный и прямоугольный)
//программа
int m = ReadData("Введите количество строк (не более 9) --->  ");
int n = ReadData("Введите количество столбцов (не более 9)--->  ");

int[,] NewMatrix = InitMatrix(m, n);

//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод, принимает строку, выводит в консоль
static void PrintResult(string line)
{
    Console.WriteLine(line);
}

// метод вывода двумерного массива
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int temp1 = i;
        int temp2 = 0;
        string str = " ";
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            str = String.Format("{0:d2}", arr[i, j]);
            Console.Write(str + ", ");
            temp2 = j + 1;
        }
        str = String.Format("{0:d2}", arr[temp1, temp2]);
        Console.WriteLine(str + "]");
    }
}

int[,] InitMatrix(int rows, int columns)
{ return new int[rows, columns]; }


//Дмитрий
//  Функция заполнения массива по спирали начиная с 1
void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

//Мария Волгунцова
int[,] SpiralArray(int countRow, int countColumn)
{
    int[,] array = new int[countRow, countColumn];
    int value = 1;
    int x = 0, y = 0, dx = 0, dy = 1;

    for (int i = 0; i < countRow * countColumn; i++)
    {
        array[x, y] = value++;
        if (x + dx < 0 || x + dx >= countRow || y + dy < 0 || y + dy >= countColumn || array[x + dx, y + dy] != 0)
        {
            int temp = dx;
            dx = dy;
            dy = -temp;
        }
        x += dx;
        y += dy;
    }
    return array;
}

//Игорь Трибелустов
int[,] GenSpiralArray(int size)
{
    int[,] nums = new int[size, size];

    int num = 1;
    int i = 0;
    int x = 0;

    while (num <= size * size)
    {
        nums[i, x] = num;
        if (i <= x + 1 && i + x < size - 1)
            ++x;
        else if (i < x && i + x >= size - 1)
            ++i;
        else if (i >= x && i + x > size - 1)
            --x;
        else
            --i;
        ++num;
    }
    return nums;
}

//Олег Крючихин
//Метод спирального заполнения массива. !!!Большая часть кода была подсмотренна в ChatGPT!!!
void SpiralGen2DArrey(int[,] array)
{
    int col = 0;
    int str = 0;
    int val = 1;
    while (val <= array.GetLength(0) * array.GetLength(1))
    {
        for (int i = col; i < array.GetLength(1) - col; i++)
        {
            array[str, i] = val++;
        }
        for (int i = str + 1; i < array.GetLength(0) - str; i++)
        {
            array[i, array.GetLength(1) - col - 1] = val++;
        }
        for (int i = array.GetLength(1) - col - 2; i >= col; i--)
        {
            array[array.GetLength(0) - str - 1, i] = val++;
        }
        for (int i = array.GetLength(0) - str - 2; i > str; i--)
        {
            array[i, col] = val++;
        }
        str++;
        col++;

    }
}

//fills 2D int array of side 'countSide' by a spiral 1-2-3-4.. CLOCKWISE
int[,] FillSquareSpiral(int countSide)
{
    int[,] arr = new int[countSide, countSide];

    int limLft = 0;
    int limRgt = countSide - 1;
    int value = 1;

    for (int circ = 0; circ < countSide / 2; circ++)//fills by "circles" clockwise
    {
        int adjustValue = countSide - 2 * circ - 1; //constant for particular circle - just for simplicity

        for (int i = limLft; i < limRgt; i++)//moves rightwards & downwards
        {
            arr[limLft, i] = value;//moves rightwards
            arr[i, limRgt] = value + adjustValue;//moves downwards
            value++;
        }
        value += adjustValue;//adjusts value as two directions were filled in at once

        for (int i = limRgt; i > limLft; i--)//moves leftwards
        {
            arr[limRgt, i] = value;//moves leftwards
            arr[i, limLft] = value + adjustValue;//moves upwards
            value++;
        }
        value += adjustValue;//adjusts value as two directions were filled in at once

        limLft++;//left limit increments
        limRgt--;//right limit decrements
    }

    if (countSide % 2 == 1) arr[countSide / 2, countSide / 2] = value;//fill the center for odd-sided squares

    return arr;
}

int[,] ChatGPT(int n)
{
    int[,] matrix = new int[n, n];

    int num = 1;
    int row = 0;
    int col = 0;
    while (num <= n * n)
    {
        // заполнение верхней строки
        for (int i = col; i < n - col; i++)
        {
            matrix[row, i] = num;
            num++;
        }
        // заполнение правого столбца
        for (int i = row + 1; i < n - row; i++)
        {
            matrix[i, n - col - 1] = num;
            num++;
        }
        // заполнение нижней строки
        for (int i = n - col - 2; i >= col; i--)
        {
            matrix[n - row - 1, i] = num;
            num++;
        }
        // заполнение левого столбца
        for (int i = n - row - 2; i > row; i--)
        {
            matrix[i, col] = num;
            num++;
        }
        // переход к следующему кругу спирали
        row++;
        col++;
    }
    return matrix;


}

//Григория
// создание массива
int[,] GenArry(int RowCount, int ColCount)
{
    int[,] binarray = new int[RowCount, ColCount];
    int buf = 0;
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < RowCount; i++)
    {
        for (int j = 0; j < ColCount; j++)
        {
            buf = SpiralFilling(RowCount, ColCount, j, i);
                binarray[i, j] = (buf);
        }
    }
    return binarray;
}

//Метод заполнения массива по спирали
int SpiralFilling(int w, int h, int x, int y)
{
    if (y != 0)
    {
        return w + SpiralFilling(h - 1, w, y - 1, w - x - 1);
    }
    else return x + 1;
}

int[,] FillSpiral(int[,] matrix, int startNumber = 1, int count = 1)
{
    for (int j = -1 + count; j < matrix.GetLength(1) + 1 - count; j++)
    {
        matrix[-1 + count, j] = startNumber++;
    }
    for (int i = count; i < matrix.GetLength(0) + 1 - count; i++)
    {
        matrix[i, matrix.GetLength(1) - count] = startNumber++;
    }
    for (int j = matrix.GetLength(1) - 1 - count; j > -1 + count; j--)
    {
        matrix[matrix.GetLength(0) - count, j] = startNumber++;
    }
    for (int i = matrix.GetLength(0) - count; i > -1 + count; i--)
    {
        matrix[i, -1 + count] = startNumber++;
    }
    if (startNumber <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        FillSpiral(matrix, startNumber, ++count);
    }
    return matrix;
}

DateTime d7 = DateTime.Now;
int[,] arr2 = FillSpiral(new int[m, n]);//
PrintResult("Решение FillSpiral" + (DateTime.Now - d7));

DateTime d1 = DateTime.Now;
FillArraySpiral(new int[m, n], m);
PrintResult("Решение Дмитрия" + (DateTime.Now - d1));



// DateTime d2 = DateTime.Now;
// int[,] arr2 = SpiralArray(m, n);
// PrintResult("Решение Мария" + (DateTime.Now - d2));

// DateTime d3 = DateTime.Now;
// int[,] arr2 = GenSpiralArray(m);//
// PrintResult("Решение Игорь" + (DateTime.Now - d3));

// DateTime d4 = DateTime.Now;
// SpiralGen2DArrey(InitMatrix(m, n));//
// PrintResult("Решение Олег" + (DateTime.Now - d4));

// DateTime d5 = DateTime.Now;
// int[,] arr2 = FillSquareSpiral(m);//
// PrintResult("Решение Борис>" + (DateTime.Now - d5));

// DateTime d6 = DateTime.Now;
// int[,] arr2 = ChatGPT(m);//
// PrintResult("Решение ChatGPT" + (DateTime.Now - d6));

// DateTime d7 = DateTime.Now;
// int[,] arr2 = GenArry(m,n);//
// PrintResult("Решение Георгий" + (DateTime.Now - d7));





// Print2DArr(arr2);