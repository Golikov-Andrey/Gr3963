// Задача №31
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//  Найдите сумму отрицательных и положительных элементов массива.

int[] Gen1DArray(int len, int minValue, int maxValue)
{
    //Блок корректировки входных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }

    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr;
}

//Печатае одномерный массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

(int posit, int negot) NegPosSum1(int[] arr)
{
    int positSum = 0;
    int negotSum = 0;

    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        if (arr[i] > 0)
        {
            positSum += arr[i];
        }
        else
        {
            negotSum += arr[i];
        }
    }

    return (positSum, negotSum);
}

int[] NegPosSum2(int[] arr)
{
    int positSum = 0;
    int negotSum = 0;

    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        if (arr[i] > 0)
        {
            positSum += arr[i];
        }
        else
        {
            negotSum += arr[i];
        }
    }

    int[] outArr = new int[2];
    outArr[0] = positSum;
    outArr[1] = negotSum;

    return outArr;
}

int[] testArr = Gen1DArray(12,-9,9);
Print1DArr(testArr);


DateTime d2 = DateTime.Now;
//(int posit,int negot) results = NegPosSum(testArr);
int[] res = NegPosSum2(testArr);
Console.WriteLine(DateTime.Now - d2);

PrintData("Сумма положительных чисел в массиве: ",res[0]);
PrintData("Сумма отрицательных чисел в массиве: ",res[1]);
