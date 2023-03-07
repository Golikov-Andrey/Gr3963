//Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//n!/k!*(n-k)!
long Factoreal(int n)
{
    long res = 1;
    for(int i=1;i<=n;i++)
    {
        res=res*i;
    }
    return res;
}

//           1
//          1 1
//         1 2 1
void PrintPascalTriangle(int nRow)
{
    for(int i=0;i<nRow;i++)
    {
        for(int k =0;k<nRow-i;k++)
        {
            Console.Write(" ");
        }

        for(int j =0; j<=i;j++)
        {
           Console.Write(" ");
           Console.Write(Factoreal(i)/(Factoreal(j)*Factoreal(i-j)));
        }
        Console.WriteLine();
    }
}

int countRow = ReadData("Введите количество строк треугольника Паскаля: ");
PrintPascalTriangle(countRow);